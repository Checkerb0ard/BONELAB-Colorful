using BreadSoup.Colorful.Melon;
using HarmonyLib;
using Il2CppSLZ.Bonelab;
using Il2CppSLZ.Marrow.Utilities;
using Il2CppTMPro;
using MelonLoader;
using UnityEngine;

namespace BreadSoup.Colorful.Coloring;

[HarmonyPatch(typeof(PageView), "Start")]
public class PageViewStartPatch
{
    public static void Postfix(PageView __instance)
    {
        CursorUtils.ApplyCursorColors(Preferences.Cursor.Value);
        PopUpUIUtils.ApplyPopUpUIColors(__instance, Preferences.PopUpUI.Value);
    }
}

public static class PopUpUIUtils
{
    public static void ApplyPopUpUIColors(PageView popUpUI, Color color)
    {
        foreach (var bullShitText in popUpUI.TextCanvas.GetComponentsInChildren<TextMeshProUGUI>(true))
        {
            bullShitText.color = color;
        }
        
        foreach (var bullShitImage in popUpUI.TextCanvas.GetComponentsInChildren<UnityEngine.UI.Image>(true))
        {
            bullShitImage.color = color;
        }

        foreach (var button in popUpUI.buttons)
        {
            button.color1 = color;
            button.color2 = color;
        }
        
        popUpUI.cancelButton.color1 = color;
        popUpUI.cancelButton.color2 = color;
    }
}