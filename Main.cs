using BoneLib;
using BreadSoup.Colorful.Coloring;
using BreadSoup.Colorful.Melon;
using BreadSoup.Colorful.Menu;
using MelonLoader;

namespace BreadSoup.Colorful;

public class Main : MelonMod
{
    internal const string Name = "Colorful";
    internal const string Description = "Makes all menus from the radial menu colorful!";
    internal const string Author = "BreadSoup";
    internal const string Company = null;
    internal const string Version = "2.0.0";
    internal const string DownloadLink = null;
    
    public override void OnInitializeMelon()
    {
        Preferences.Setup();
        BoneMenu.Setup();
        UserData.Setup();
    }
}