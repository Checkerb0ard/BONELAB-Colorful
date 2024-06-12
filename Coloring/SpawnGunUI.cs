using BoneLib;
using BreadSoup.Colorful.Melon;
using Il2CppSLZ.Bonelab;
using HarmonyLib;
using Il2CppSLZ.UI;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

namespace BreadSoup.Colorful.Coloring;

[HarmonyPatch (typeof (SpawnablesPanelView), "Activate")]
public class SpawnGunUIActivatePatch
{
    public static void Postfix (SpawnablesPanelView __instance)
    {
        SpawnGunUIUtils.ApplySpawnGunUIColors(__instance, Preferences.SpawnGunUI.Value);
    }
}

public static class SpawnGunUIUtils
{
    public static void ApplySpawnGunUIColors(SpawnablesPanelView spawnGunUI, Color color)
    {
        foreach (var tabButton in spawnGunUI.tabButtons)
        {
            tabButton.tmp.color = color;
            tabButton.highlight.color = color;
            tabButton.transform.FindChild("image_icon").GetComponent<Image>().color = color;
        }

        foreach (var treeButton in spawnGunUI.treeButtons)
        {
            treeButton.tmp.color = color;
            treeButton.highlight.color = color;
            treeButton.special.color = color;
        }

        foreach (var itemButton in spawnGunUI.itemButtons)
        {
            itemButton.tmp.color = color;
            itemButton.highlight.color = color;
        }
        
        spawnGunUI.treeBackButton.highlight.color = color;
        spawnGunUI.treeBackButton.special.color = color;
        
        spawnGunUI.swapSortButton.highlight.color = color;
        spawnGunUI.swapSortButton.special.color = color;
        
        spawnGunUI.treePathText.color = color;
        
        spawnGunUI.labelText.color = color;
        
        spawnGunUI.treeScrollUpButton.highlight.color = color;
        spawnGunUI.treeScrollUpButton.special.color = color;
        
        spawnGunUI.treeScrollDownButton.highlight.color = color;
        spawnGunUI.treeScrollDownButton.special.color = color;
        
        spawnGunUI.itemScrollDownButton.highlight.color = color;
        spawnGunUI.itemScrollDownButton.special.color = color;
        
        spawnGunUI.itemScrollUpButton.highlight.color = color;
        spawnGunUI.itemScrollUpButton.special.color = color;
        
        spawnGunUI.itemPageText.color = color;
        
        spawnGunUI.selectedTitle.color = color;
        spawnGunUI.selectedPallet.color = color;
        spawnGunUI.selectedAuthor.color = color;
        spawnGunUI.selectedDescription.color = color;
        spawnGunUI.selectedTags.color = color;
        
        spawnGunUI.capsuleButton.tmp.color = color;
        spawnGunUI.capsuleButton.special.color = color;
        spawnGunUI.capsuleButton.transform.parent.GetComponent<Image>().color = color;

        spawnGunUI.transform.Find("group_tabs/image----------------").GetComponent<Image>().color = color;

        spawnGunUI.transform.Find("HEADER/button_Close/image_frontline").GetComponent<Image>().color = color;
    }
}