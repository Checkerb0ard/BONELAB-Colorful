using BreadSoup.Colorful.Melon;
using HarmonyLib;
using Il2CppSLZ.Bonelab;
using UnityEngine;

namespace BreadSoup.Colorful.Coloring;

[HarmonyPatch(typeof(ItemSlotsPanelView), "Activate")]
public class ItemSlotsPanelViewActivatePatch
{
    public static void Postfix(ItemSlotsPanelView __instance)
    {
        ItemSlotsPanelViewUtils.ApplyItemSlotsPanelViewColors(__instance, Preferences.ItemSlotsPanelView.Value);
    }
}

public static class ItemSlotsPanelViewUtils
{
    public static void ApplyItemSlotsPanelViewColors(ItemSlotsPanelView itemSlotsPanelView, Color color)
    {
        foreach (var slot in itemSlotsPanelView.slots)
        {
            slot.highlightColor1 = color;
            slot.highlightColor2 = color;
            slot.color1 = color;
            slot.color2 = color;
            
            slot.elements[0].SetColors(color, color);
        }
    }
}