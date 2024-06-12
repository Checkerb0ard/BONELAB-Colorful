using MelonLoader;
using MelonLoader.Utils;
using UnityEngine;

namespace BreadSoup.Colorful.Melon;

internal static class Preferences
{
    public static readonly MelonPreferences_Category ModCategory = MelonPreferences.CreateCategory("Colorful");
    
    public static MelonPreferences_Entry<Color> SpawnGunUI;
    
    public static MelonPreferences_Entry<Color> PopUpUI;
    
    public static MelonPreferences_Entry<Color> ItemSlotsPanelView;

    public static MelonPreferences_Entry<Color> PreferencesUI;
    
    public static MelonPreferences_Entry<Color> AvatarMenuUI;
    
    public static MelonPreferences_Entry<Color> BodyMallUI;
    
    public static MelonPreferences_Entry<Color> LevelUI;

    public static MelonPreferences_Entry<Color> Cursor;

    public static void Setup()
    {
        SpawnGunUI = ModCategory.CreateEntry("SpawnGunUI", Color.blue, "Spawn Gun UI Color");
        
        PopUpUI = ModCategory.CreateEntry("PopUpUI", Color.green, "PopUp UI Color");
        
        ItemSlotsPanelView = ModCategory.CreateEntry("ItemSlotsPanelView", Color.red, "Inventory slot Color");
        
        PreferencesUI = ModCategory.CreateEntry("PreferencesUI", Color.cyan, "Preferences UI Color");
        
        AvatarMenuUI = ModCategory.CreateEntry("AvatarMenuUI", Color.yellow, "Avatar menu UI Color");
        
        BodyMallUI = ModCategory.CreateEntry("BodyMallUI", new Color(255, 115, 0, 1), "Body Mall UI Color");
        
        LevelUI = ModCategory.CreateEntry("LevelUI", Color.white, "Level UI Color");
        
        Cursor = ModCategory.CreateEntry("Cursor", Color.magenta, "Cursor Color");

        ModCategory.SetFilePath(MelonEnvironment.UserDataDirectory + "/Colorful.cfg");
        ModCategory.SaveToFile(false);
    }
}