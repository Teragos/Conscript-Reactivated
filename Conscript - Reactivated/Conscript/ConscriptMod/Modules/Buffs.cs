using RoR2;
using UnityEngine;

namespace ConscriptMod.Modules;

public static class Buffs
{
    internal static BuffDef armorBuff;

    internal static void RegisterBuffs()
    {
        Buffs.armorBuff = Buffs.AddNewBuff("ArmorBuff", LegacyResourcesAPI.Load<BuffDef>("BuffDefs/HiddenInvincibility").iconSprite, Color.white, canStack: false, isDebuff: false);
    }

    internal static BuffDef AddNewBuff(string buffName, Sprite buffIcon, Color buffColor, bool canStack, bool isDebuff)
    {
        BuffDef buffDef = ScriptableObject.CreateInstance<BuffDef>();
        buffDef.name = buffName;
        buffDef.buffColor = buffColor;
        buffDef.canStack = canStack;
        buffDef.isDebuff = isDebuff;
        buffDef.eliteDef = null;
        buffDef.iconSprite = buffIcon;
        Content.AddBuffDef(buffDef);
        return buffDef;
    }
}
