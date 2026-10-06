using System.Collections.Generic;
using R2API;
using RoR2;
using UnityEngine;

namespace ConscriptMod.Modules;

internal static class ItemDisplays
{
    private static Dictionary<string, GameObject> itemDisplayPrefabs = new Dictionary<string, GameObject>();

    internal static void PopulateDisplays()
    {
        ItemDisplays.PopulateFromBody("MageBody");
        ItemDisplays.PopulateFromBody("LunarExploderBody");
        ItemDisplays.PopulateCustomLightningArm();
    }

    private static void PopulateFromBody(string bodyName)
    {
        ItemDisplayRuleSet.KeyAssetRuleGroup[] keyAssetRuleGroups = LegacyResourcesAPI.Load<GameObject>("Prefabs/CharacterBodies/" + bodyName).GetComponent<ModelLocator>().modelTransform.GetComponent<CharacterModel>().itemDisplayRuleSet.keyAssetRuleGroups;
        for (int i = 0; i < keyAssetRuleGroups.Length; i++)
        {
            ItemDisplayRule[] rules = keyAssetRuleGroups[i].displayRuleGroup.rules;
            for (int j = 0; j < rules.Length; j++)
            {
                GameObject followerPrefab = rules[j].followerPrefab;
                if ((bool)followerPrefab)
                {
                    string key = followerPrefab.name?.ToLowerInvariant();
                    if (!ItemDisplays.itemDisplayPrefabs.ContainsKey(key))
                    {
                        ItemDisplays.itemDisplayPrefabs[key] = followerPrefab;
                    }
                }
            }
        }
    }

    private static void PopulateCustomLightningArm()
    {
        GameObject gameObject = PrefabAPI.InstantiateClone(ItemDisplays.itemDisplayPrefabs["displaylightningarmright"], "DisplayLightningCustom", false);
        LimbMatcher component = gameObject.GetComponent<LimbMatcher>();
        component.limbPairs[0].targetChildLimb = "LightningArm1";
        component.limbPairs[1].targetChildLimb = "LightningArm2";
        component.limbPairs[2].targetChildLimb = "LightningArmEnd";
        ItemDisplays.itemDisplayPrefabs["displaylightningarmcustom"] = gameObject;
    }

    public static GameObject LoadDisplay(string name)
    {
        if (ItemDisplays.itemDisplayPrefabs.ContainsKey(name.ToLowerInvariant()) && (bool)ItemDisplays.itemDisplayPrefabs[name.ToLowerInvariant()])
        {
            return ItemDisplays.itemDisplayPrefabs[name.ToLowerInvariant()];
        }
        Log.Error("item display " + name + " returned null");
        return null;
    }
}
