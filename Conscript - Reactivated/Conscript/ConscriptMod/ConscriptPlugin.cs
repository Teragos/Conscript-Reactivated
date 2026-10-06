using System.Security;
using System.Security.Permissions;

using BepInEx;
using ConscriptMod.Modules;
using ConscriptMod.Modules.Survivors;
using On.RoR2;
using R2API.Utils;
using RoR2;

[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
namespace ConscriptMod;

[BepInDependency(R2API.ContentManagement.R2APIContentManager.PluginGUID, BepInDependency.DependencyFlags.HardDependency)]
[BepInDependency(R2API.LanguageAPI.PluginGUID, BepInDependency.DependencyFlags.HardDependency)]
[BepInDependency(R2API.PrefabAPI.PluginGUID, BepInDependency.DependencyFlags.HardDependency)]
[BepInDependency(R2API.RecalculateStatsAPI.PluginGUID, BepInDependency.DependencyFlags.HardDependency)]
[BepInDependency(R2API.SoundAPI.PluginGUID, BepInDependency.DependencyFlags.HardDependency)]
[NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod)]
[BepInPlugin("com.score.ConscriptMod", "ConscriptMod", "1.1.0")]
public class ConscriptPlugin : BaseUnityPlugin
{
    public const string MODUID = "com.score.ConscriptMod";

    public const string MODNAME = "ConscriptMod";

    public const string MODVERSION = "1.1.0";

    public const string DEVELOPER_PREFIX = "MANTI";

    public static ConscriptPlugin instance;

    private void Awake()
    {
        ConscriptPlugin.instance = this;
        Log.Init(Logger);
        ConscriptMod.Modules.Assets.Initialize();
        ConscriptMod.Modules.Config.ReadConfig();
        States.RegisterStates();
        Buffs.RegisterBuffs();
        Projectiles.RegisterProjectiles();
        Tokens.AddTokens();
        ItemDisplays.PopulateDisplays();
        new MyCharacter().Initialize();
        new ContentPacks().Initialize();
        this.Hook();
    }

    private void Hook()
    {
        R2API.RecalculateStatsAPI.GetStatCoefficients += RecalculateStatsAPI_GetStatCoefficients;
    }

    private void RecalculateStatsAPI_GetStatCoefficients(RoR2.CharacterBody sender, R2API.RecalculateStatsAPI.StatHookEventArgs args)
    {
        if (sender.HasBuff(Buffs.armorBuff))
        {
            args.armorAdd += 300f;
        }
    }
}
