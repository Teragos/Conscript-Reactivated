using System.Collections.Generic;
using RoR2;
using UnityEngine;

namespace ConscriptMod.Modules.Characters;

internal class ConscriptItemDisplays : ItemDisplaysBase
{
    protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
    {
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.Jetpack,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBugWings"),
                        childName = "Chest",
                        localPos = new Vector3(0.0047f, -0.05416f, -0.04788f),
                        localAngles = new Vector3(21.4993f, 358.6616f, 358.3334f),
                        localScale = new Vector3(0.03965f, 0.03965f, 0.03965f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.GoldGat,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayGoldGat"),
                        childName = "Chest",
                        localPos = new Vector3(-0.06489f, 0.08793f, -0.10512f),
                        localAngles = new Vector3(313.1709f, 106.9412f, 269.1895f),
                        localScale = new Vector3(0.04469f, 0.04469f, 0.04469f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.BFG,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBFG"),
                        childName = "Chest",
                        localPos = new Vector3(0.05243f, 0.08063f, -0.06034f),
                        localAngles = new Vector3(334.9649f, 335.0073f, 323.3783f),
                        localScale = new Vector3(0.1226f, 0.1226f, 0.1226f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.CritGlasses,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayGlasses"),
                        childName = "Head",
                        localPos = new Vector3(-0.00021f, 0.04557f, -0.0222f),
                        localAngles = new Vector3(336.5759f, 180f, 180f),
                        localScale = new Vector3(0.06847f, 0.06462f, 0.06462f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Syringe,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplaySyringeCluster"),
                        childName = "Chest",
                        localPos = new Vector3(0.00531f, 0.07047f, 0.03099f),
                        localAngles = new Vector3(6.70467f, 96.32048f, 46.8391f),
                        localScale = new Vector3(0.05046f, 0.05046f, 0.05046f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Behemoth,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBehemoth"),
                        childName = "Rifle",
                        localPos = new Vector3(-0.00356f, 0.04084f, 0.22348f),
                        localAngles = new Vector3(270f, 180f, 0f),
                        localScale = new Vector3(0.01434f, 0.01434f, 0.01434f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Missile,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayMissileLauncher"),
                        childName = "Rifle",
                        localPos = new Vector3(-0.00224f, 0.09272f, 0.08964f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.01978f, 0.01978f, 0.01978f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Dagger,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayDagger"),
                        childName = "Chest",
                        localPos = new Vector3(-0.00339f, 0.0286f, -0.00061f),
                        localAngles = new Vector3(287.6318f, 230.354f, 179.7385f),
                        localScale = new Vector3(0.39583f, 0.39583f, 0.39172f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Hoof,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayHoof"),
                        childName = "CalfL",
                        localPos = new Vector3(-0.0071f, 0.12429f, -0.02391f),
                        localAngles = new Vector3(85.80507f, 0f, 0f),
                        localScale = new Vector3(0.03693f, 0.03693f, 0.03309f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.ChainLightning,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayUkulele"),
                        childName = "Chest",
                        localPos = new Vector3(-0.03951f, 0.01729f, -0.08842f),
                        localAngles = new Vector3(0f, 180f, 63.48869f),
                        localScale = new Vector3(0.19345f, 0.19345f, 0.19345f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.GhostOnKill,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayMask"),
                        childName = "Head",
                        localPos = new Vector3(-0.00017f, 0.03197f, -0.00202f),
                        localAngles = new Vector3(333.085f, 180f, 0f),
                        localScale = new Vector3(0.20391f, 0.20391f, 0.29722f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Mushroom,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayMushroom"),
                        childName = "Head",
                        localPos = new Vector3(0.01053f, 0.05384f, 0.00108f),
                        localAngles = new Vector3(16.45763f, 0f, 0f),
                        localScale = new Vector3(0.02563f, 0.02563f, 0.02563f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.AttackSpeedOnCrit,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayWolfPelt"),
                        childName = "Head",
                        localPos = new Vector3(0.00056f, 0.04605f, -0.01354f),
                        localAngles = new Vector3(332.7386f, 180.0813f, 359.8312f),
                        localScale = new Vector3(0.17237f, 0.17237f, 0.17237f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.BleedOnHit,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayTriTip"),
                        childName = "Baton",
                        localPos = new Vector3(0f, -0.01991f, 0.33902f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.2615f, 0.2615f, 0.2615f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.WardOnLevel,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayWarbanner"),
                        childName = "Chest",
                        localPos = new Vector3(0.0168f, -0.02212f, -0.04576f),
                        localAngles = new Vector3(0f, 0f, 90f),
                        localScale = new Vector3(0.13128f, 0.13128f, 0.13128f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.HealOnCrit,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayScythe"),
                        childName = "Baton",
                        localPos = new Vector3(0f, -0.0115f, 0.24021f),
                        localAngles = new Vector3(354.251f, 0f, 270f),
                        localScale = new Vector3(0.08654f, 0.08654f, 0.12655f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.HealWhileSafe,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplaySnail"),
                        childName = "UpperArmL",
                        localPos = new Vector3(0f, 0.03435f, 0f),
                        localAngles = new Vector3(90f, 0f, 0f),
                        localScale = new Vector3(0.02276f, 0.02276f, 0.02276f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Clover,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayClover"),
                        childName = "Rifle",
                        localPos = new Vector3(-0.003f, 0.05211f, 0.0464f),
                        localAngles = new Vector3(0f, 180f, 0f),
                        localScale = new Vector3(0.12737f, 0.12737f, 0.12737f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.BarrierOnOverHeal,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayAegis"),
                        childName = "LowerArmL",
                        localPos = new Vector3(1E-05f, 0.04119f, 0.0202f),
                        localAngles = new Vector3(86.47136f, 179.9999f, 1E-05f),
                        localScale = new Vector3(0.06076f, 0.06076f, 0.06076f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.GoldOnHit,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBoneCrown"),
                        childName = "Head",
                        localPos = new Vector3(-0.00022f, 0.03879f, 0.00908f),
                        localAngles = new Vector3(40.55924f, 0f, 0f),
                        localScale = new Vector3(0.30814f, 0.30814f, 0.30814f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.WarCryOnMultiKill,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayPauldron"),
                        childName = "UpperArmL",
                        localPos = new Vector3(0f, -0.00209f, 0.01169f),
                        localAngles = new Vector3(79.83609f, 180f, 180f),
                        localScale = new Vector3(0.21083f, 0.21083f, 0.21083f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.SprintArmor,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBuckler"),
                        childName = "LowerArmR",
                        localPos = new Vector3(-0.00596f, 0.07005f, -0.01865f),
                        localAngles = new Vector3(358.4802f, 192.347f, 88.48111f),
                        localScale = new Vector3(0.03929f, 0.03929f, 0.03929f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.IceRing,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayIceRing"),
                        childName = "Rifle",
                        localPos = new Vector3(-0.00021f, 0.04136f, 0.23683f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.12893f, 0.12893f, 0.12893f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.FireRing,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayFireRing"),
                        childName = "Rifle",
                        localPos = new Vector3(-0.00381f, 0.03895f, 0.2116f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.14859f, 0.14859f, 0.14859f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.UtilitySkillMagazine,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.03563f, 0.00417f),
                        localAngles = new Vector3(270f, 0f, 0f),
                        localScale = new Vector3(0.16784f, 0.16784f, 0.16784f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.JumpBoost,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayWaxBird"),
                        childName = "Chest",
                        localPos = new Vector3(0.05115f, -0.05518f, 0.0228f),
                        localAngles = new Vector3(337.5489f, 0f, 0f),
                        localScale = new Vector3(0.25186f, 0.25186f, 0.25186f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.ArmorReductionOnHit,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayWarhammer"),
                        childName = "Baton",
                        localPos = new Vector3(0f, -0.01586f, 0.339f),
                        localAngles = new Vector3(0f, 0f, 270f),
                        localScale = new Vector3(0.10631f, 0.10631f, 0.10631f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.NearbyDamageBonus,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayDiamond"),
                        childName = "Baton",
                        localPos = new Vector3(0f, -0.02004f, -0.09198f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.04048f, 0.04048f, 0.04048f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.ArmorPlate,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayRepulsionArmorPlate"),
                        childName = "ThighL",
                        localPos = new Vector3(-0.00934f, 0.10359f, -0.02423f),
                        localAngles = new Vector3(87.14611f, 180f, 180f),
                        localScale = new Vector3(0.1032f, 0.1032f, 0.1032f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.CommandMissile,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayMissileRack"),
                        childName = "Chest",
                        localPos = new Vector3(0f, 0.08026f, -0.09314f),
                        localAngles = new Vector3(90f, 180f, 0f),
                        localScale = new Vector3(0.12355f, 0.12355f, 0.12355f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Feather,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayFeather"),
                        childName = "Chest",
                        localPos = new Vector3(-0.03433f, 0.03494f, -0.04964f),
                        localAngles = new Vector3(0f, 0f, 89.63007f),
                        localScale = new Vector3(0.00878f, 0.00878f, 0.00878f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Crowbar,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayCrowbar"),
                        childName = "Baton",
                        localPos = new Vector3(0.0052f, -0.01521f, 0.2916f),
                        localAngles = new Vector3(270f, 180f, 0f),
                        localScale = new Vector3(0.1936f, 0.1936f, 0.1936f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.FallBoots,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[2]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayGravBoots"),
                        childName = "FootL",
                        localPos = new Vector3(0f, 0.00532f, -0.001f),
                        localAngles = new Vector3(305.5352f, 0f, 0f),
                        localScale = new Vector3(0.07526f, 0.07526f, 0.07526f),
                        limbMask = LimbFlags.None
                    },
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayGravBoots"),
                        childName = "FootR",
                        localPos = new Vector3(0f, -0.00341f, 0.00034f),
                        localAngles = new Vector3(305f, 0f, 0f),
                        localScale = new Vector3(0.07526f, 0.07526f, 0.07526f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.ExecuteLowHealthElite,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayGuillotine"),
                        childName = "ThighR",
                        localPos = new Vector3(0.02955f, 0.05561f, 0f),
                        localAngles = new Vector3(90f, 90f, 0f),
                        localScale = new Vector3(0.05942f, 0.05942f, 0.05942f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.EquipmentMagazine,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBattery"),
                        childName = "Chest",
                        localPos = new Vector3(0.06026f, 0.05342f, -0.05672f),
                        localAngles = new Vector3(90f, 0f, 0f),
                        localScale = new Vector3(0.0773f, 0.0773f, 0.0773f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.NovaOnHeal,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[2]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                        childName = "Head",
                        localPos = new Vector3(0.0423f, 0.027f, 0.00335f),
                        localAngles = new Vector3(277.2105f, 180f, 180f),
                        localScale = new Vector3(0.18166f, 0.18166f, 0.18166f),
                        limbMask = LimbFlags.None
                    },
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                        childName = "Head",
                        localPos = new Vector3(-0.05319f, 0.02663f, 0.0044f),
                        localAngles = new Vector3(279.6517f, 180f, 180f),
                        localScale = new Vector3(-0.18166f, 0.18166f, 0.18166f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Infusion,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayInfusion"),
                        childName = "Pelvis",
                        localPos = new Vector3(-0.06088f, 0.03834f, -0.02718f),
                        localAngles = new Vector3(0f, 45f, 0f),
                        localScale = new Vector3(0.19484f, 0.19484f, 0.19484f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Medkit,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayMedkit"),
                        childName = "Chest",
                        localPos = new Vector3(0.0039f, 0.02686f, -0.0561f),
                        localAngles = new Vector3(270.7317f, 180f, 0f),
                        localScale = new Vector3(0.23913f, 0.23913f, 0.23913f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Bandolier,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBandolier"),
                        childName = "Spine",
                        localPos = new Vector3(0.0035f, 0.01688f, 0f),
                        localAngles = new Vector3(270f, 0f, 0f),
                        localScale = new Vector3(0.12122f, 0.16602f, 0.17421f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.BounceNearby,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayHook"),
                        childName = "Rifle",
                        localPos = new Vector3(0.01294f, 0.03493f, 0.07667f),
                        localAngles = new Vector3(0f, 0f, 270f),
                        localScale = new Vector3(0.12371f, 0.12371f, 0.12371f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.IgniteOnKill,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayGasoline"),
                        childName = "Chest",
                        localPos = new Vector3(-0.02939f, -0.02452f, -0.03023f),
                        localAngles = new Vector3(0.66687f, 90f, 90f),
                        localScale = new Vector3(0.18922f, 0.18922f, 0.18922f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.StunChanceOnHit,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayStunGrenade"),
                        childName = "Chest",
                        localPos = new Vector3(0.02909f, 0.02256f, 0.0565f),
                        localAngles = new Vector3(270f, 192.1914f, 0f),
                        localScale = new Vector3(0.29737f, 0.29737f, 0.29737f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Firework,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayFirework"),
                        childName = "Chest",
                        localPos = new Vector3(-0.05939f, 0.05847f, -0.04566f),
                        localAngles = new Vector3(290.0954f, 248.8155f, 112.4254f),
                        localScale = new Vector3(0.0715f, 0.0715f, 0.0715f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.LunarDagger,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayLunarDagger"),
                        childName = "Baton",
                        localPos = new Vector3(0f, 0.00206f, 0.32321f),
                        localAngles = new Vector3(289.8539f, 0f, 90f),
                        localScale = new Vector3(0.16939f, 0.16939f, 0.16939f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Knurl,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayKnurl"),
                        childName = "Pelvis",
                        localPos = new Vector3(0.01983f, 0.04585f, -0.03196f),
                        localAngles = new Vector3(270f, 1E-05f, 0f),
                        localScale = new Vector3(0.02523f, 0.02523f, 0.02523f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.BeetleGland,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBeetleGland"),
                        childName = "Chest",
                        localPos = new Vector3(0.08678f, 0.08516f, -2E-05f),
                        localAngles = new Vector3(359.9584f, 0.1329f, 39.8304f),
                        localScale = new Vector3(0.03374f, 0.03374f, 0.03374f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.SprintBonus,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplaySoda"),
                        childName = "Spine",
                        localPos = new Vector3(-0.05302f, 0.01865f, -0.03683f),
                        localAngles = new Vector3(270f, 251.0168f, 0f),
                        localScale = new Vector3(0.07089f, 0.07089f, 0.07089f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.SecondarySkillMagazine,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayDoubleMag"),
                        childName = "Rifle",
                        localPos = new Vector3(0.00218f, -0.01551f, 0.07582f),
                        localAngles = new Vector3(0f, 0f, 8f),
                        localScale = new Vector3(0.02222f, 0.02222f, 0.02222f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.StickyBomb,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayStickyBomb"),
                        childName = "Baton",
                        localPos = new Vector3(0f, -0.01888f, -0.0952f),
                        localAngles = new Vector3(270f, 0f, 0f),
                        localScale = new Vector3(0.12521f, 0.12521f, 0.12521f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.TreasureCache,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayKey"),
                        childName = "Head",
                        localPos = new Vector3(0.0618f, 0.03117f, 0.00483f),
                        localAngles = new Vector3(330f, 0f, 270f),
                        localScale = new Vector3(0.4092f, 0.4092f, 0.4092f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.BossDamageBonus,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayAPRound"),
                        childName = "Rifle",
                        localPos = new Vector3(0.01655f, 0.04291f, 0.01187f),
                        localAngles = new Vector3(0f, 180f, 39.95623f),
                        localScale = new Vector3(0.2279f, 0.2279f, 0.2279f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.SlowOnHit,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBauble"),
                        childName = "Rifle",
                        localPos = new Vector3(0f, -0.00208f, 0f),
                        localAngles = new Vector3(0f, 76.45711f, 0f),
                        localScale = new Vector3(0.0687f, 0.0687f, 0.0687f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.ExtraLife,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayHippo"),
                        childName = "Chest",
                        localPos = new Vector3(0f, 0.06643f, 0.05304f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.10479f, 0.10479f, 0.10479f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.KillEliteFrenzy,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBrainstalk"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.03668f, -0.00843f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.09168f, 0.09168f, 0.09168f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.RepeatHeal,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayCorpseFlower"),
                        childName = "Head",
                        localPos = new Vector3(-0.06125f, 0.03657f, 0.00364f),
                        localAngles = new Vector3(270f, 90f, 0f),
                        localScale = new Vector3(0.0814f, 0.0814f, 0.0814f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.AutoCastEquipment,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayFossil"),
                        childName = "Chest",
                        localPos = new Vector3(0f, 0.08985f, -0.05593f),
                        localAngles = new Vector3(0f, 0f, 270f),
                        localScale = new Vector3(0.15953f, 0.16038f, 0.15953f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.IncreaseHealing,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[2]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayAntler"),
                        childName = "Head",
                        localPos = new Vector3(0.04343f, 0.0374f, -0.0024f),
                        localAngles = new Vector3(0f, 90f, 0f),
                        localScale = new Vector3(0.11331f, 0.11331f, 0.11331f),
                        limbMask = LimbFlags.None
                    },
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayAntler"),
                        childName = "Head",
                        localPos = new Vector3(-0.04568f, 0.03301f, 0.00412f),
                        localAngles = new Vector3(0f, 90f, 0f),
                        localScale = new Vector3(0.11331f, 0.11331f, -0.11331f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.TitanGoldDuringTP,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayGoldHeart"),
                        childName = "ThighL",
                        localPos = new Vector3(-0.02075f, 0.03029f, -0.03316f),
                        localAngles = new Vector3(3.24886f, 246.3021f, 310.8707f),
                        localScale = new Vector3(0.06739f, 0.06739f, 0.06739f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.SprintWisp,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBrokenMask"),
                        childName = "Head",
                        localPos = new Vector3(0.03127f, 0.06145f, -0.00595f),
                        localAngles = new Vector3(321.8948f, 99.26497f, 30.80987f),
                        localScale = new Vector3(0.05651f, 0.05651f, 0.05651f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.BarrierOnKill,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBrooch"),
                        childName = "Rifle",
                        localPos = new Vector3(-0.01055f, 0.03834f, 0.19449f),
                        localAngles = new Vector3(0f, 0f, 84.3456f),
                        localScale = new Vector3(0.1841f, 0.1841f, 0.1841f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.TPHealingNova,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayGlowFlower"),
                        childName = "Head",
                        localPos = new Vector3(-0.02319f, 0.07421f, -0.00386f),
                        localAngles = new Vector3(301.2068f, 226.0266f, 206.2806f),
                        localScale = new Vector3(0.10548f, 0.10548f, 0.01054f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.LunarUtilityReplacement,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBirdFoot"),
                        childName = "CalfR",
                        localPos = new Vector3(0f, 0.03967f, -0.03549f),
                        localAngles = new Vector3(0f, 90f, 270f),
                        localScale = new Vector3(0.35221f, 0.35221f, 0.35221f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Thorns,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayRazorwireLeft"),
                        childName = "UpperArmL",
                        localPos = new Vector3(0f, 0f, 0f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.16058f, 0.16058f, 0.16058f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.LunarPrimaryReplacement,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBirdEye"),
                        childName = "Rifle",
                        localPos = new Vector3(0f, 0.04152f, 0.27104f),
                        localAngles = new Vector3(270f, 0f, 0f),
                        localScale = new Vector3(0.10389f, 0.17895f, 0.10389f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.NovaOnLowHealth,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayJellyGuts"),
                        childName = "Head",
                        localPos = new Vector3(-0.038f, 0.04571f, 0.01565f),
                        localAngles = new Vector3(18.11864f, 78.01108f, 294.8757f),
                        localScale = new Vector3(0.03252f, 0.03221f, 0.03252f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.LunarTrinket,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBeads"),
                        childName = "Rifle",
                        localPos = new Vector3(4E-05f, 0.03317f, 0.22795f),
                        localAngles = new Vector3(351.1129f, 175.109f, 300.3956f),
                        localScale = new Vector3(0.36351f, 0.36351f, 0.36351f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Plant,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayInterstellarDeskPlant"),
                        childName = "UpperArmR",
                        localPos = new Vector3(0f, 0f, 0f),
                        localAngles = new Vector3(26.52649f, 144.4444f, 162.2959f),
                        localScale = new Vector3(0.02854f, 0.02854f, 0.02854f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Bear,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBear"),
                        childName = "UpperArmL",
                        localPos = new Vector3(0f, 0.04803f, 0.02208f),
                        localAngles = new Vector3(0f, 0f, 180f),
                        localScale = new Vector3(0.10278f, 0.10278f, 0.10278f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.DeathMark,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayDeathMark"),
                        childName = "Rifle",
                        localPos = new Vector3(0f, 0.06162f, 0.23776f),
                        localAngles = new Vector3(270f, 1E-05f, 0f),
                        localScale = new Vector3(0.01378f, 0.01378f, 0.01378f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.ExplodeOnDeath,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayWilloWisp"),
                        childName = "Pelvis",
                        localPos = new Vector3(0.07062f, 0.03613f, -0.03009f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.01346f, 0.01346f, 0.01346f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Seed,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplaySeed"),
                        childName = "Rifle",
                        localPos = new Vector3(-0.00142f, 0.03692f, -0.126f),
                        localAngles = new Vector3(331.5163f, 274.8272f, 17.51875f),
                        localScale = new Vector3(0.02042f, 0.02042f, 0.02042f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.SprintOutOfCombat,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayWhip"),
                        childName = "Pelvis",
                        localPos = new Vector3(0.08145f, -0.00096f, 0f),
                        localAngles = new Vector3(0f, 0f, 20.1526f),
                        localScale = new Vector3(0.10903f, 0.10903f, 0.10903f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = JunkContent.Items.CooldownOnCrit,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplaySkull"),
                        childName = "Baton",
                        localPos = new Vector3(0.00363f, -0.01429f, -0.08907f),
                        localAngles = new Vector3(286.3018f, 49.60558f, 143.1146f),
                        localScale = new Vector3(0.04216f, 0.04216f, 0.04216f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Phasing,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayStealthkit"),
                        childName = "CalfL",
                        localPos = new Vector3(-0.0063f, 0.10249f, -0.02807f),
                        localAngles = new Vector3(90f, 0f, 0f),
                        localScale = new Vector3(0.07173f, 0.11835f, 0.07893f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.PersonalShield,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayShieldGenerator"),
                        childName = "Chest",
                        localPos = new Vector3(0f, 0.0564f, 0.04175f),
                        localAngles = new Vector3(270f, 1E-05f, 0f),
                        localScale = new Vector3(0.06006f, 0.06006f, 0.06006f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.ShockNearby,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayTeslaCoil"),
                        childName = "Chest",
                        localPos = new Vector3(0.00071f, 0.07149f, -0.06519f),
                        localAngles = new Vector3(297.6866f, 1.3864f, 358.5596f),
                        localScale = new Vector3(0.10647f, 0.10647f, 0.10647f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.ShieldOnly,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[2]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayShieldBug"),
                        childName = "Head",
                        localPos = new Vector3(0.02605f, 0.06514f, -0.00029f),
                        localAngles = new Vector3(348.1819f, 268.0985f, 0.3896f),
                        localScale = new Vector3(0.1f, 0.1f, 0.1f),
                        limbMask = LimbFlags.None
                    },
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayShieldBug"),
                        childName = "Head",
                        localPos = new Vector3(-0.02177f, 0.06402f, 0.00042f),
                        localAngles = new Vector3(11.8181f, 268.0985f, 359.6104f),
                        localScale = new Vector3(0.1f, 0.1f, -0.1f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.AlienHead,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayAlienHead"),
                        childName = "Chest",
                        localPos = new Vector3(0.03101f, -0.0072f, -0.05478f),
                        localAngles = new Vector3(297.5977f, 172.7464f, 328.6774f),
                        localScale = new Vector3(0.22178f, 0.22178f, 0.22178f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.HeadHunter,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplaySkullCrown"),
                        childName = "Head",
                        localPos = new Vector3(-0.0001f, 0.05127f, 0.01717f),
                        localAngles = new Vector3(331.1531f, 180f, 0f),
                        localScale = new Vector3(0.14681f, 0.04894f, 0.04894f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.EnergizedOnEquipmentUse,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayWarHorn"),
                        childName = "Chest",
                        localPos = new Vector3(0.02474f, 0.0105f, -0.05646f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.18286f, 0.18286f, 0.18286f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.FlatHealth,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplaySteakCurved"),
                        childName = "Head",
                        localPos = new Vector3(-0.00012f, 0.0796f, -0.01928f),
                        localAngles = new Vector3(306.0168f, 180f, 180f),
                        localScale = new Vector3(0.02869f, 0.02661f, 0.02661f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Tooth,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayToothMeshLarge"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.03619f, -0.02263f),
                        localAngles = new Vector3(353.1556f, 180f, 180f),
                        localScale = new Vector3(0.88799f, 0.88799f, 0.88799f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Pearl,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayPearl"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0f, 0f),
                        localAngles = new Vector3(289.627f, 0f, 0f),
                        localScale = new Vector3(0.1f, 0.1f, 0.1f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.ShinyPearl,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayShinyPearl"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0f, 0f),
                        localAngles = new Vector3(52.61448f, 180f, 180f),
                        localScale = new Vector3(0.1f, 0.1f, 0.1f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.BonusGoldPackOnKill,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayTome"),
                        childName = "LowerArmR",
                        localPos = new Vector3(0f, 0.0418f, -0.02433f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.01921f, 0.01921f, 0.01921f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Squid,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplaySquidTurret"),
                        childName = "Head",
                        localPos = new Vector3(-0.00359f, 0.0733f, -0.01583f),
                        localAngles = new Vector3(0f, 90f, 336.2744f),
                        localScale = new Vector3(0.01275f, 0.00998f, 0.01112f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Icicle,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayFrostRelic"),
                        childName = "Root",
                        localPos = new Vector3(-0.17866f, 0.35009f, -0.14278f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(1f, 1f, 1f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.Talisman,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayTalisman"),
                        childName = "Chest",
                        localPos = new Vector3(0.11261f, 0.16229f, 0.00626f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.5f, 0.5f, 0.5f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.LaserTurbine,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayLaserTurbine"),
                        childName = "Chest",
                        localPos = new Vector3(0f, 0.0622f, -0.0822f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.09956f, 0.09956f, 0.09956f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.FocusConvergence,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayFocusedConvergence"),
                        childName = "Root",
                        localPos = new Vector3(0f, 0.46238f, 0f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.04654f, 0.04654f, 0.03415f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = JunkContent.Items.Incubator,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayAncestralIncubator"),
                        childName = "Chest",
                        localPos = new Vector3(-0.01867f, 0.0138f, -0.04336f),
                        localAngles = new Vector3(353.0521f, 317.2421f, 69.6292f),
                        localScale = new Vector3(0.01259f, 0.01259f, 0.01259f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.FireballsOnHit,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayFireballsOnHit"),
                        childName = "Rifle",
                        localPos = new Vector3(0f, 0.05766f, 0.20269f),
                        localAngles = new Vector3(328.2433f, 0f, 0f),
                        localScale = new Vector3(0.02612f, 0.02612f, 0.02612f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.SiphonOnLowHealth,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplaySiphonOnLowHealth"),
                        childName = "Pelvis",
                        localPos = new Vector3(0.06582f, 0.03565f, -0.00359f),
                        localAngles = new Vector3(0f, 303.4368f, 0f),
                        localScale = new Vector3(0.02143f, 0.02143f, 0.02143f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.BleedOnHitAndExplode,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBleedOnHitAndExplode"),
                        childName = "ThighR",
                        localPos = new Vector3(0.02741f, 0.0575f, -0.0178f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.0198f, 0.0198f, 0.0198f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.MonstersOnShrineUse,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayMonstersOnShrineUse"),
                        childName = "Chest",
                        localPos = new Vector3(0.00835f, 0.03611f, -0.08661f),
                        localAngles = new Vector3(45f, 90f, 0f),
                        localScale = new Vector3(0.0246f, 0.0246f, 0.0246f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Items.RandomDamageZone,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayRandomDamageZone"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.08864f, 0.01107f),
                        localAngles = new Vector3(55.57692f, 180f, 0f),
                        localScale = new Vector3(0.02385f, 0.02385f, 0.02416f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.Fruit,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayFruit"),
                        childName = "Chest",
                        localPos = new Vector3(-0.00013f, -0.00733f, -0.00938f),
                        localAngles = new Vector3(328.0267f, 35.52949f, 355.4515f),
                        localScale = new Vector3(0.07109f, 0.07109f, 0.07109f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.AffixRed,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[2]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteHorn"),
                        childName = "Head",
                        localPos = new Vector3(0.05757f, 0.03f, 0f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.02837f, 0.02837f, 0.02837f),
                        limbMask = LimbFlags.None
                    },
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteHorn"),
                        childName = "Head",
                        localPos = new Vector3(-0.05818f, 0.03152f, 0f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(-0.02837f, 0.02837f, 0.02837f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.AffixBlue,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[2]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteRhinoHorn"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.05495f, 0.04836f),
                        localAngles = new Vector3(298.2584f, 0f, 0f),
                        localScale = new Vector3(0.07033f, 0.07033f, 0.07033f),
                        limbMask = LimbFlags.None
                    },
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteRhinoHorn"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.08064f, 0.01387f),
                        localAngles = new Vector3(311.1068f, 180f, 180f),
                        localScale = new Vector3(0.06426f, 0.06426f, 0.06426f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.AffixWhite,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteIceCrown"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.05282f, 0.03441f),
                        localAngles = new Vector3(54.68565f, 180f, 180f),
                        localScale = new Vector3(0.00944f, 0.00944f, 0.00944f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.AffixPoison,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteUrchinCrown"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.06553f, 0.00717f),
                        localAngles = new Vector3(270f, 0f, 0f),
                        localScale = new Vector3(0.01417f, 0.01417f, 0.01417f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.AffixHaunted,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteStealthCrown"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.06732f, 0.01814f),
                        localAngles = new Vector3(74.92312f, 180f, 180f),
                        localScale = new Vector3(0.01482f, 0.01482f, 0.01482f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.CritOnUse,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayNeuralImplant"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.0511f, -0.03913f),
                        localAngles = new Vector3(28.34902f, 0f, 0f),
                        localScale = new Vector3(11f / 160f, 11f / 160f, 11f / 160f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.DroneBackup,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayRadio"),
                        childName = "Chest",
                        localPos = new Vector3(-0.02549f, 0.0581f, -0.08068f),
                        localAngles = new Vector3(0f, 180f, 0f),
                        localScale = new Vector3(0.2641f, 0.2641f, 0.2641f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.Lightning,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayLightningArmRight"),
                        childName = "UpperArmR",
                        localPos = new Vector3(0f, 0f, 0f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(-0.2f, 0.2f, -0.2f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.BurnNearby,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayPotion"),
                        childName = "Chest",
                        localPos = new Vector3(-0.0495f, 0.03002f, -0.02524f),
                        localAngles = new Vector3(0f, 0f, 320.8099f),
                        localScale = new Vector3(0.01399f, 0.01399f, 0.01399f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.CrippleWard,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayEffigy"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.06763f, -0.02059f),
                        localAngles = new Vector3(18.04323f, 0f, 0f),
                        localScale = new Vector3(0.10249f, 0.10249f, 0.10249f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.QuestVolatileBattery,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayBatteryArray"),
                        childName = "Chest",
                        localPos = new Vector3(0f, 0.04039f, -0.06211f),
                        localAngles = new Vector3(0f, 180f, 180f),
                        localScale = new Vector3(0.12393f, 0.12393f, 0.12393f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.GainArmor,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayElephantFigure"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.08699f, 0.02645f),
                        localAngles = new Vector3(340.5016f, 180f, 0f),
                        localScale = new Vector3(0.24832f, 0.24832f, 0.24832f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.Recycle,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayRecycler"),
                        childName = "Chest",
                        localPos = new Vector3(0f, 0.03217f, -0.08486f),
                        localAngles = new Vector3(0f, 90f, 0f),
                        localScale = new Vector3(0.02845f, 0.02845f, 0.02845f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.FireBallDash,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayEgg"),
                        childName = "Pelvis",
                        localPos = new Vector3(0.04674f, 0.03364f, -0.02617f),
                        localAngles = new Vector3(270f, 0f, 0f),
                        localScale = new Vector3(0.09202f, 0.09202f, 0.09202f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.Cleanse,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayWaterPack"),
                        childName = "Chest",
                        localPos = new Vector3(0f, 0.01014f, -0.05824f),
                        localAngles = new Vector3(0f, 180f, 0f),
                        localScale = new Vector3(0.04889f, 0.04889f, 0.04889f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.Tonic,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayTonic"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.01873f, -0.05893f),
                        localAngles = new Vector3(80.57673f, 0f, 0f),
                        localScale = new Vector3(0.05755f, 0.05755f, 0.05755f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.Gateway,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayVase"),
                        childName = "Pelvis",
                        localPos = new Vector3(-0.07923f, 0.06542f, -0.00362f),
                        localAngles = new Vector3(338.047f, 90f, 0f),
                        localScale = new Vector3(0.06548f, 0.06548f, 0.06548f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.Meteor,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayMeteor"),
                        childName = "Root",
                        localPos = new Vector3(0f, 0.49952f, 0f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(1f, 1f, 1f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.Saw,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplaySawmerangFollower"),
                        childName = "Root",
                        localPos = new Vector3(-0.15871f, 0.0981f, -0.28686f),
                        localAngles = new Vector3(68.86717f, 0f, 0f),
                        localScale = new Vector3(0.03977f, 0.03977f, 0.03977f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.Blackhole,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayGravCube"),
                        childName = "Root",
                        localPos = new Vector3(0.15328f, 0.28365f, -0.1076f),
                        localAngles = new Vector3(0f, 0f, 0f),
                        localScale = new Vector3(0.5f, 0.5f, 0.5f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.Scanner,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayScanner"),
                        childName = "Chest",
                        localPos = new Vector3(0f, 0.03692f, -0.0652f),
                        localAngles = new Vector3(347.8537f, 180f, 180f),
                        localScale = new Vector3(0.0861f, 0.0861f, 0.0861f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.DeathProjectile,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayDeathProjectile"),
                        childName = "Pelvis",
                        localPos = new Vector3(0f, 0.03595f, -0.06205f),
                        localAngles = new Vector3(0f, 180f, 0f),
                        localScale = new Vector3(0.02732f, 0.02732f, 0.02732f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.LifestealOnHit,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayLifestealOnHit"),
                        childName = "Head",
                        localPos = new Vector3(-0.04641f, 0.10242f, -0.02726f),
                        localAngles = new Vector3(44.0939f, 33.5151f, 43.5058f),
                        localScale = new Vector3(0.02995f, 0.02995f, 0.02995f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
        itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
        {
            keyAsset = RoR2Content.Equipment.TeamWarCry,
            displayRuleGroup = new DisplayRuleGroup
            {
                rules = new ItemDisplayRule[1]
                {
                    new ItemDisplayRule
                    {
                        ruleType = ItemDisplayRuleType.ParentedPrefab,
                        followerPrefab = ItemDisplays.LoadDisplay("DisplayTeamWarCry"),
                        childName = "Head",
                        localPos = new Vector3(0f, 0.07703f, 0.01562f),
                        localAngles = new Vector3(278.4872f, 0f, 0f),
                        localScale = new Vector3(0.02094f, 0.02094f, 0.02094f),
                        limbMask = LimbFlags.None
                    }
                }
            }
        });
    }
}
