using BreadSoup.Colorful.Melon;
using HarmonyLib;
using Il2CppSLZ.Bonelab;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BreadSoup.Colorful.Coloring.MainUI;

[HarmonyPatch(typeof(LevelsPanelView), "Awake")]
public class LevelsPanelViewAwakePatch
{
    public static void Postfix(LevelsPanelView __instance)
    {
        LevelsPanelViewUtils.ApplyLevelsPanelViewColors(__instance, Preferences.LevelUI.Value);
    }
}

public static class LevelsPanelViewUtils
{
    public static void ApplyLevelsPanelViewColors(LevelsPanelView levelsPanelView, Color color)
    {
        if (levelsPanelView == null) return;

        if (levelsPanelView.pageText != null)
            levelsPanelView.pageText.color = color;

        var titleText = levelsPanelView.transform.Find("text_TITLE")?.GetComponent<TextMeshProUGUI>();
        if (titleText != null)
            titleText.color = color;

        var image = levelsPanelView.transform.Find("image----------------")?.GetComponent<Image>();
        if (image != null)
            image.color = color;

        if (levelsPanelView.items != null)
        {
            foreach (var sceneButtons in levelsPanelView.items)
            {
                var backlineImage = sceneButtons?.transform.Find("image_backline")?.GetComponent<Image>();
                if (backlineImage != null)
                    backlineImage.color = color;
            }
        }

        if (levelsPanelView.text != null)
        {
            foreach (var sceneButtonText in levelsPanelView.text)
            {
                if (sceneButtonText != null)
                    sceneButtonText.color = color;
            }
        }

        if (levelsPanelView.forwardButton != null)
        {
            var forwardButtonImages = levelsPanelView.forwardButton.GetComponentsInChildren<Image>(true);
            foreach (var buttonImage in forwardButtonImages)
            {
                if (buttonImage != null)
                    buttonImage.color = color;
            }
        }

        if (levelsPanelView.backButton != null)
        {
            var backwardsButtonImages = levelsPanelView.backButton.GetComponentsInChildren<Image>(true);
            foreach (var buttonImage in backwardsButtonImages)
            {
                if (buttonImage != null)
                    buttonImage.color = color;
            }
        }

        var returnButton = levelsPanelView.transform.Find("button_return");
        if (returnButton != null)
        {
            var returnButtonImages = returnButton.GetComponentsInChildren<Image>(true);
            foreach (var buttonImage in returnButtonImages)
            {
                if (buttonImage != null)
                    buttonImage.color = color;
            }
        }
    }

}
