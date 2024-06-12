using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(BreadSoup.Colorful.Main.Description)]
[assembly: AssemblyDescription(BreadSoup.Colorful.Main.Description)]
[assembly: AssemblyCompany(BreadSoup.Colorful.Main.Company)]
[assembly: AssemblyProduct(BreadSoup.Colorful.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + BreadSoup.Colorful.Main.Author)]
[assembly: AssemblyTrademark(BreadSoup.Colorful.Main.Company)]
[assembly: AssemblyVersion(BreadSoup.Colorful.Main.Version)]
[assembly: AssemblyFileVersion(BreadSoup.Colorful.Main.Version)]
[assembly:
    MelonInfo(typeof(BreadSoup.Colorful.Main), BreadSoup.Colorful.Main.Name, BreadSoup.Colorful.Main.Version,
        BreadSoup.Colorful.Main.Author, BreadSoup.Colorful.Main.DownloadLink)]
[assembly: MelonColor(255, 255, 255, 255)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]