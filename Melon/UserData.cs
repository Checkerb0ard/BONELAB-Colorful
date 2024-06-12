using System.IO;
using MelonLoader;

namespace BreadSoup.Colorful.Melon;

internal static class UserData
{
    private static readonly string ModPath = Path.Combine(MelonUtils.UserDataDirectory, "Colorful");

    public static void Setup()
    {
        if (!Directory.Exists(ModPath))
        {
            Directory.CreateDirectory(ModPath);
        }
    }
}