using MelonLoader;
using MelonLoader.Utils;
using UnityEngine;

namespace BreadSoup.Colorful.Melon;

internal static class Preferences
{
    public static readonly MelonPreferences_Category ModCategory = MelonPreferences.CreateCategory("Colorful");
    
    public static MelonPreferences_Entry<Color> SpawnGunUI;
    
    public static MelonPreferences_Entry<Color> ItemSlotsPanelView;

    public static MelonPreferences_Entry<Color> PreferencesUI;
    
    public static MelonPreferences_Entry<Color> AvatarMenuUI;
    
    public static MelonPreferences_Entry<Color> BodyMallUI;
    
    public static MelonPreferences_Entry<Color> LevelUI;

    public static MelonPreferences_Entry<Color> Cursor;
    
    // Pop up UI colors, this is going to be bad
    public static MelonPreferences_Entry<Color> PopUpUI_N;
    public static MelonPreferences_Entry<Color> PopUpUI_NE;
    public static MelonPreferences_Entry<Color> PopUpUI_E;
    public static MelonPreferences_Entry<Color> PopUpUI_SE;
    public static MelonPreferences_Entry<Color> PopUpUI_S;
    public static MelonPreferences_Entry<Color> PopUpUI_SW;
    public static MelonPreferences_Entry<Color> PopUpUI_W;
    public static MelonPreferences_Entry<Color> PopUpUI_NW;

    public static void Setup()
    {
        SpawnGunUI = ModCategory.CreateEntry("SpawnGunUI", Color.blue, "Spawn Gun UI Color");
        
        ItemSlotsPanelView = ModCategory.CreateEntry("ItemSlotsPanelView", Color.red, "Inventory slot Color");
        
        PreferencesUI = ModCategory.CreateEntry("PreferencesUI", Color.cyan, "Preferences UI Color");
        
        AvatarMenuUI = ModCategory.CreateEntry("AvatarMenuUI", Color.yellow, "Avatar menu UI Color");
        
        BodyMallUI = ModCategory.CreateEntry("BodyMallUI", new Color(255, 115, 0, 1), "Body Mall UI Color");
        
        LevelUI = ModCategory.CreateEntry("LevelUI", Color.white, "Level UI Color");
        
        Cursor = ModCategory.CreateEntry("Cursor", Color.magenta, "Cursor Color");
        
        PopUpUI_N = ModCategory.CreateEntry("PopUpUI_N", Color.green, "PopUp UI Color (North)");
        PopUpUI_NE = ModCategory.CreateEntry("PopUpUI_NE", Color.green, "PopUp UI Color (North East)");
        PopUpUI_E = ModCategory.CreateEntry("PopUpUI_E", Color.green, "PopUp UI Color (East)");
        PopUpUI_SE = ModCategory.CreateEntry("PopUpUI_SE", Color.green, "PopUp UI Color (South East)");
        PopUpUI_S = ModCategory.CreateEntry("PopUpUI_S", Color.green, "PopUp UI Color (South)");
        PopUpUI_SW = ModCategory.CreateEntry("PopUpUI_SW", Color.green, "PopUp UI Color (South West)");
        PopUpUI_W = ModCategory.CreateEntry("PopUpUI_W", Color.green, "PopUp UI Color (West)");
        PopUpUI_NW = ModCategory.CreateEntry("PopUpUI_NW", Color.green, "PopUp UI Color (North West)");

        ModCategory.SetFilePath(MelonEnvironment.UserDataDirectory + "/Colorful.cfg");
        ModCategory.SaveToFile(false);
    }
}