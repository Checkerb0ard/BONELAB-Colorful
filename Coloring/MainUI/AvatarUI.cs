using BoneLib;
using BreadSoup.Colorful.Melon;
using HarmonyLib;
using Il2CppSLZ.Bonelab;
using Il2CppSLZ.UI;
using Il2CppTMPro;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

namespace BreadSoup.Colorful.Coloring.MainUI;

[HarmonyPatch(typeof(AvatarsPanelView), "Start")]
public class AvatarPanelViewAwakePatch
{
    public static void Postfix(AvatarsPanelView __instance)
    {
        if (__instance.transform.root.name != "RigManager (Blank) [0]")
            AvatarsPanelViewUtils.ApplyBodymallAvatarsPanelViewColors(__instance, Preferences.BodyMallUI.Value);
        else
            AvatarsPanelViewUtils.ApplyPlayerAvatarsPanelViewColors(Player.uiRig.popUpMenu.avatarsPanelView, Preferences.AvatarMenuUI.Value);
    }
}

public static class AvatarsPanelViewUtils
{
    public static void ApplyPlayerAvatarsPanelViewColors(AvatarsPanelView avatarsPanelView, Color color)
    {
        var images = avatarsPanelView.GetComponentsInChildren<Image>(true);
        foreach (var image in images)
        {
            if (image.name is "image_bgFade")
            {
                
            }
            else
            {
                image.color = color;
            }
        }
        var tmpTexts = avatarsPanelView.GetComponentsInChildren<TMP_Text>(true);
        foreach (var tmp in tmpTexts)
        {
            tmp.color = color;
        }
    }

    public static void ApplyBodymallAvatarsPanelViewColors(AvatarsPanelView avatarsPanelView, Color color)
    {
        var images = avatarsPanelView.GetComponentsInChildren<Image>(true);
        foreach (var image in images)
        {
            if (image.name is "image_bg" or "img_outline" or "img_bg" or "image_backline")
                continue;

            image.color = color;
        }
        var tmpTexts = avatarsPanelView.GetComponentsInChildren<TMP_Text>(true);
        foreach (var tmp in tmpTexts)
        {
            tmp.color = color;
        }
        
        if (avatarsPanelView.spiderChart != null)
        {
            var allRenderers = avatarsPanelView.spiderChart.GetComponentsInChildren<Renderer>(true);
            foreach (var renderer in allRenderers)
            {
                if (renderer.gameObject.name == "Chart")
                    renderer.material.color = color;
            }
        }
    }
}
