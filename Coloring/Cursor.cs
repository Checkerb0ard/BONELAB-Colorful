using BoneLib;
using BreadSoup.Colorful.Melon;
using HarmonyLib;
using Il2CppSLZ.Bonelab;
using MelonLoader;
using UnityEngine;

namespace BreadSoup.Colorful.Coloring;

public class CursorUtils
{
    public static void ApplyCursorColors(Color color)
    {
        var cursor = Player.uiRig.transform.Find("PLAYERUI/CURSOR");
        
        var highlightUIs = cursor.GetComponentsInChildren<HighlightUI>(true);
        var pageElementViews = cursor.GetComponentsInChildren<PageElementView>(true);
        
        foreach (var highlightUI in highlightUIs)
        {
            highlightUI.color1 = color;
            highlightUI.color2 = color;
        }
        
        foreach (var pageElementView in pageElementViews)
        {
            pageElementView.color1 = color;
            pageElementView.color2 = color;
            pageElementView.highlightColor1 = color;
            pageElementView.highlightColor2 = color;
        }
    }
    
    public static void ApplySLZCursorColors(Color color)
    {
        var cursors = UnityEngine.Object.FindObjectsOfType<LaserCursor>();

        foreach (var cursor in cursors)
        {
            var elementsHighlightUis = cursor.GetComponentsInChildren<PageElementView>(true);
            if (elementsHighlightUis.Length == 0)
            {
                MelonLogger.Msg("No HighlightUI found in Cursor");
            }
            foreach (var element in elementsHighlightUis)
            {
                element.color1 = color;
                element.color2 = color;
                element.highlightColor1 = color;
                element.highlightColor2 = color;
            }
            cursor.cursorLine.startColor = color;
            cursor.cursorLine.endColor = color;
            cursor.cursorLine.material.color = color;
            
            cursor.cursorLine.material.SetColor("_Color1", color);
        }
    }
}

[HarmonyPatch(typeof(LaserCursor), "Awake")]
public class LaserCursorAwakePatch
{
    public static void Postfix(LaserCursor __instance)
    {
        CursorUtils.ApplySLZCursorColors(Preferences.Cursor.Value);
    }
}