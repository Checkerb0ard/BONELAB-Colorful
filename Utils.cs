using Il2CppSLZ.Bonelab;
using Il2CppSLZ.UI;
using MelonLoader;
using UnityEngine;

namespace BreadSoup.Colorful;

public static class GameObjectExtensions
{
    public static string GetPath(this GameObject gameObject)
    {
        string path = "/" + gameObject.name;
        while (gameObject.transform.parent != null)
        {
            gameObject = gameObject.transform.parent.gameObject;
            path = "/" + gameObject.name + path;
        }
        return path;
    }
}