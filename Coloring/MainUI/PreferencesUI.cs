using BreadSoup.Colorful.Melon;
using HarmonyLib;
using Il2CppSLZ.Bonelab;
using UnityEngine;

namespace BreadSoup.Colorful.Coloring.MainUI;

[HarmonyPatch (typeof (Control_UI_InGameData), "Start")]
public class Control_UI_InGameDataStartPatch
{
    public static void Postfix (Control_UI_InGameData __instance)
    {
        Control_UI_InGameDataUtils.ApplyControl_UI_InGameDataColors(__instance, Preferences.PreferencesUI.Value);
    }
}

public static class Control_UI_InGameDataUtils
{
    public static void ApplyControl_UI_InGameDataColors(Control_UI_InGameData control_UI_InGameData, Color color)
    {
        // Terrible way to do this
        
        var tmpTexts = control_UI_InGameData.GetComponentsInChildren<Il2CppTMPro.TextMeshProUGUI>(true);
        foreach (var tmp in tmpTexts)
        {
            tmp.color = color;
        }
        
        var uiImages = control_UI_InGameData.GetComponentsInChildren<UnityEngine.UI.Image>(true);
        foreach (var image in uiImages)
        {
            if (image.name.Contains("Viewport"))
            {
                var childImages = image.GetComponentsInChildren<UnityEngine.UI.Image>(true);
                foreach (var childImage in childImages)
                {
                    if (childImage != image)
                    {
                        childImage.color = color;
                    }
                }
                continue;
            }
            if (image.name.Contains("image_bgFade"))
            {
                continue;
            }
            image.color = color;
        }
        
        var rawImages = control_UI_InGameData.GetComponentsInChildren<UnityEngine.UI.RawImage>(true);
        foreach (var image in rawImages)
        {
            image.color = color;
        }
    }
}