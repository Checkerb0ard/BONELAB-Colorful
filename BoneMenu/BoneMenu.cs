using BoneLib;
using BoneLib.BoneMenu;
using BoneLib.BoneMenu.Elements;
using BreadSoup.Colorful.Coloring;
using BreadSoup.Colorful.Coloring.MainUI;
using BreadSoup.Colorful.Melon;
using Il2CppSLZ.Bonelab;
using Il2CppSLZ.UI;
using MelonLoader;
using UnityEngine;
using Object = System.Object;

namespace BreadSoup.Colorful.Menu;

internal static class BoneMenu
{
    public static MenuCategory MainCategory;

    public static SubPanelElement ColorPicker;

    public static MenuCategory MainUI;

    public static Color MixedSelectedColor = Color.white;

    public static MenuElement ColorRed;
    public static MenuElement ColorGreen;
    public static MenuElement ColorBlue;
    
    // Elements for all the options
    
    private static MenuElement SpawnGunUI;
    private static MenuElement PopUpUI;
    private static MenuElement ItemSlotsPanelView;
    private static MenuElement PreferencesUI;
    private static MenuElement AvatarMenuUI;
    private static MenuElement BodyMallUI;
    private static MenuElement LevelUI;
    private static MenuElement Cursor;
    
    public static void Setup()
    {
        MainCategory = MenuManager.CreateCategory("<color=#FF0000>C</color><color=#FF7F00>o</color><color=#FFFF00>l</color><color=#00FF00>o</color><color=#0000FF>r</color><color=#4B0082>f</color><color=#FF0000>u</color><color=#9400D3>l</color>", Color.white);
        
        ColorPicker = MainCategory.CreateSubPanel("Color Picker", Color.white);
        
        var colorPreview = ColorPicker.CreateFunctionElement("Color Preview", Color.white, () => {});
        
        ColorRed = ColorPicker.CreateFloatElement("Red", Color.red, 1f, .1f, 0f, 1f, value =>
        {
            MixedSelectedColor.r = value;
            ColorRed.SetColor(new Color(value, 0, 0, 1));
            colorPreview.SetColor(MixedSelectedColor);
        });
        ColorGreen = ColorPicker.CreateFloatElement("Green", Color.green, 1f, .1f, 0f, 1f, value =>
        {
            MixedSelectedColor.g = value;
            ColorGreen.SetColor(new Color(0, value, 0, 1));
            colorPreview.SetColor(MixedSelectedColor);
        });
        ColorBlue = ColorPicker.CreateFloatElement("Blue", Color.blue, 1f, .1f, 0f, 1f, value =>
        {
            MixedSelectedColor.b = value;
            ColorBlue.SetColor(new Color(0, 0, value, 1));
            colorPreview.SetColor(MixedSelectedColor);
        });
        
        MainUI = MainCategory.CreateCategory("Main UI", Color.cyan);
        
        PreferencesUI = MainUI.CreateFunctionElement("Apply to Preferences UI", Preferences.PreferencesUI.Value, () =>
        {
            Control_UI_InGameDataUtils.ApplyControl_UI_InGameDataColors(Player.uiRig.transform.Find("PLAYERUI/UI_PREFERENCES/scaleOffset/canvas_UI/group_Options/panel_Preferences").GetComponent<Control_UI_InGameData>(), MixedSelectedColor);
            
            Preferences.PreferencesUI.Value = MixedSelectedColor;
            Preferences.ModCategory.SaveToFile(true);
            PreferencesUI.SetColor(MixedSelectedColor);
        });
        
        AvatarMenuUI = MainUI.CreateFunctionElement("Apply to Avatar menu UI", Preferences.AvatarMenuUI.Value, () =>
        {
            AvatarsPanelViewUtils.ApplyPlayerAvatarsPanelViewColors(Player.uiRig.popUpMenu.avatarsPanelView, MixedSelectedColor);
            
            Preferences.AvatarMenuUI.Value = MixedSelectedColor;
            Preferences.ModCategory.SaveToFile(true);
            AvatarMenuUI.SetColor(MixedSelectedColor);
        });
        
        BodyMallUI = MainUI.CreateFunctionElement("Apply to Body Mall UI", Preferences.BodyMallUI.Value, () =>
        {
            var go = UnityEngine.Object.FindObjectsOfType<AvatarsPanelView>();
            foreach (var obj in go)
            {
                if (obj.transform.root.name != "RigManager (Blank) [0]")
                    AvatarsPanelViewUtils.ApplyBodymallAvatarsPanelViewColors(obj, Preferences.BodyMallUI.Value);
            }
            
            Preferences.BodyMallUI.Value = MixedSelectedColor;
            Preferences.ModCategory.SaveToFile(true);
            BodyMallUI.SetColor(MixedSelectedColor);
        });
        
        LevelUI = MainUI.CreateFunctionElement("Apply to Level UI", Preferences.LevelUI.Value, () =>
        {
            LevelsPanelViewUtils.ApplyLevelsPanelViewColors(Player.uiRig.popUpMenu.levelsPanelView, MixedSelectedColor);
            
            Preferences.LevelUI.Value = MixedSelectedColor;
            Preferences.ModCategory.SaveToFile(true);
            LevelUI.SetColor(MixedSelectedColor);
        });
        
        SpawnGunUI = MainCategory.CreateFunctionElement("Apply to Spawn Gun UI", Preferences.SpawnGunUI.Value, () =>
        {
            SpawnGunUIUtils.ApplySpawnGunUIColors(Player.uiRig.popUpMenu.spawnablesPanelView, MixedSelectedColor);
            
            Preferences.SpawnGunUI.Value = MixedSelectedColor;
            Preferences.ModCategory.SaveToFile(true);
            SpawnGunUI.SetColor(MixedSelectedColor);
        });
        
        PopUpUI = MainCategory.CreateFunctionElement("Apply to Pop Up UI", Preferences.PopUpUI.Value, () =>
        {
            PopUpUIUtils.ApplyPopUpUIColors(Player.uiRig.popUpMenu.radialPageView, MixedSelectedColor);

            Preferences.PopUpUI.Value = MixedSelectedColor;
            Preferences.ModCategory.SaveToFile(true);
            PopUpUI.SetColor(MixedSelectedColor);
        });
        
        ItemSlotsPanelView = MainCategory.CreateFunctionElement("Apply to Inventory Slots", Preferences.ItemSlotsPanelView.Value, () =>
        {
            ItemSlotsPanelViewUtils.ApplyItemSlotsPanelViewColors(Player.uiRig.popUpMenu.itemSlotsPanelView, MixedSelectedColor);

            Preferences.ItemSlotsPanelView.Value = MixedSelectedColor;
            Preferences.ModCategory.SaveToFile(true);
            ItemSlotsPanelView.SetColor(MixedSelectedColor);
        });
        
        Cursor = MainCategory.CreateFunctionElement("Apply to Cursor", Preferences.Cursor.Value, () =>
        {
            CursorUtils.ApplyCursorColors(MixedSelectedColor);
            CursorUtils.ApplySLZCursorColors(MixedSelectedColor);
            
            Preferences.Cursor.Value = MixedSelectedColor;
            Preferences.ModCategory.SaveToFile(true);
            Cursor.SetColor(MixedSelectedColor);
        });
    }
}