using BepInEx;
using BepInEx.Configuration;

namespace ConscriptMod.Modules;

public static class Config
{
    public static void ReadConfig()
    {
    }

    public static ConfigEntry<bool> CharacterEnableConfig(string characterName, string description = "Set to false to disable this character", bool enabledDefault = true)
    {
        return ((BaseUnityPlugin)ConscriptPlugin.instance).Config.Bind<bool>("General", "Enable " + characterName, enabledDefault, description);
    }
}
