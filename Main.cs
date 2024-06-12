using BoneLib;
using BreadSoup.Colorful.Coloring;
using BreadSoup.Colorful.Melon;
using BreadSoup.Colorful.Menu;
using MelonLoader;

namespace BreadSoup.Colorful;

public class Main : MelonMod
{
    internal const string Name = "Colorful";
    internal const string Description = "Description";
    internal const string Author = "BreadSoup";
    internal const string Company = null;
    internal const string Version = "0.0.1";
    internal const string DownloadLink = null;
    
    public override void OnInitializeMelon()
    {
        Preferences.Setup();
        BoneMenu.Setup();
        UserData.Setup();
    }
}