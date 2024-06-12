using System.Text.RegularExpressions;
using BreadSoup.Colorful.Melon;
using HarmonyLib;
using Il2CppSLZ.Bonelab;
using Il2CppSLZ.Marrow.Utilities;
using Il2CppTMPro;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

namespace BreadSoup.Colorful.Coloring;

[HarmonyPatch(typeof(PageView), "Start")]
public class PageViewStartPatch
{
    public static void Postfix(PageView __instance)
    {
        PopUpUIUtils.ApplyPopUpUIColors(__instance);
        CursorUtils.ApplyCursorColors(Preferences.Cursor.Value);
        CursorUtils.ApplySLZCursorColors(Preferences.Cursor.Value);
    }
}

public static class PopUpUIUtils
{
    public static void ApplyPopUpUIColors(PageView popUpUI)
    {
        foreach (var button in popUpUI.buttons)
        {
            var match = Regex.Match(button.gameObject.name, @"Region_([A-Z]+)");
            if (match.Success)
            {
                string regionDirection = match.Groups[1].Value;
                Color regionColor = GetColorPreferenceForRegion(regionDirection);
                button.color1 = regionColor;
                button.color2 = regionColor;

                button.textMesh.color = regionColor;

                button.icon.GetComponent<Image>().color = regionColor;
            }
            else
            {
                button.color1 = Color.white;
                button.color2 = Color.white;
            }
        }
    }
    
    public static Color GetColorPreferenceForRegion(string regionDirection)
    {
        switch (regionDirection)
        {
            case "N":
                return Preferences.PopUpUI_N.Value;
            case "NE":
                return Preferences.PopUpUI_NE.Value;
            case "E":
                return Preferences.PopUpUI_E.Value;
            case "SE":
                return Preferences.PopUpUI_SE.Value;
            case "S":
                return Preferences.PopUpUI_S.Value;
            case "SW":
                return Preferences.PopUpUI_SW.Value;
            case "W":
                return Preferences.PopUpUI_W.Value;
            case "NW":
                return Preferences.PopUpUI_NW.Value;
            default:
                return Color.white;
        }
    }
}