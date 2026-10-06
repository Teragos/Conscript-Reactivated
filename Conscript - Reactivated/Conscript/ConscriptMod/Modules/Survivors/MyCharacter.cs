using System;
using System.Collections.Generic;
using BepInEx.Configuration;
using ConscriptMod.Modules.Characters;
using ConscriptMod.SkillStates;
using EntityStates;
using RoR2;
using RoR2.Skills;
using UnityEngine;

namespace ConscriptMod.Modules.Survivors;

internal class MyCharacter : SurvivorBase
{
    public const string CONSCRIPT_PREFIX = "MANTI_CONSCRIPT_BODY_";

    private static UnlockableDef masterySkinUnlockableDef;

    public override string prefabBodyName => "Conscript";

    public override string survivorTokenPrefix => "MANTI_CONSCRIPT_BODY_";

    public override BodyInfo bodyInfo { get; set; } = new BodyInfo
    {
        bodyName = "Conscript",
        bodyNameToken = "MANTI_CONSCRIPT_BODY_NAME",
        subtitleNameToken = "MANTI_CONSCRIPT_BODY_SUBTITLE",
        characterPortrait = Assets.mainAssetBundle.LoadAsset<Texture>("texConscriptIcon"),
        bodyColor = Color.magenta,
        crosshair = Assets.LoadCrosshair("Standard"),
        podPrefab = LegacyResourcesAPI.Load<GameObject>("Prefabs/NetworkedObjects/SurvivorPod"),
        maxHealth = 115f,
        healthRegen = 1.2f,
        armor = 0f,
        jumpCount = 1
    };


    public override CustomRendererInfo[] customRendererInfos { get; set; } = new CustomRendererInfo[3]
    {
        new CustomRendererInfo
        {
            childName = "krontroop",
            material = Materials.CreateHopooMaterial("kronMaterial")
        },
        new CustomRendererInfo
        {
            childName = "krongun",
            material = Materials.CreateHopooMaterial("kronMaterial")
        },
        new CustomRendererInfo
        {
            childName = "kronbaton",
            material = Materials.CreateHopooMaterial("kronMaterial")
        }
    };


    public override UnlockableDef characterUnlockableDef => null;

    public override Type characterMainState => typeof(GenericCharacterMain);

    public override ItemDisplaysBase itemDisplays => new ConscriptItemDisplays();

    public override ConfigEntry<bool> characterEnabledConfig => null;

    public override void InitializeCharacter()
    {
        base.InitializeCharacter();
    }

    public override void InitializeUnlockables()
    {
    }

    public override void InitializeHitboxes()
    {
        Prefabs.SetupHitbox(hitboxTransform: this.bodyPrefab.GetComponentInChildren<ChildLocator>().FindChild("BatonHitbox"), prefab: this.prefabCharacterModel.gameObject, hitboxName: "Baton");
    }

    public override void InitializeSkills()
    {
        Skills.CreateSkillFamilies(this.bodyPrefab);
        string text = "MANTI";
        SkillDefInfo skillDefInfo = new SkillDefInfo();
        skillDefInfo.skillName = text + "_CONSCRIPT_BODY_PRIMARY_RIFLE_NAME";
        skillDefInfo.skillNameToken = text + "_CONSCRIPT_BODY_PRIMARY_RIFLE_NAME";
        skillDefInfo.skillDescriptionToken = text + "_CONSCRIPT_BODY_PRIMARY_RIFLE_DESCRIPTION";
        skillDefInfo.skillIcon = Assets.mainAssetBundle.LoadAsset<Sprite>("texPrimarySkill");
        skillDefInfo.activationState = new SerializableEntityStateType(typeof(Shoot));
        skillDefInfo.activationStateMachineName = "Slide";
        skillDefInfo.baseMaxStock = 1;
        skillDefInfo.baseRechargeInterval = 0f;
        skillDefInfo.beginSkillCooldownOnSkillEnd = true;
        skillDefInfo.canceledFromSprinting = false;
        skillDefInfo.forceSprintDuringState = false;
        skillDefInfo.fullRestockOnAssign = true;
        skillDefInfo.interruptPriority = InterruptPriority.Skill;
        skillDefInfo.resetCooldownTimerOnUse = false;
        skillDefInfo.isCombatSkill = true;
        skillDefInfo.mustKeyPress = false;
        skillDefInfo.cancelSprintingOnActivation = true;
        skillDefInfo.rechargeStock = 1;
        skillDefInfo.requiredStock = 1;
        skillDefInfo.stockToConsume = 1;
        SkillDef skillDef = Skills.CreateSkillDef(skillDefInfo);
        skillDefInfo = new SkillDefInfo();
        skillDefInfo.skillName = text + "_CONSCRIPT_BODY_PRIMARY_ALT_RIFLE_NAME";
        skillDefInfo.skillNameToken = text + "_CONSCRIPT_BODY_PRIMARY_ALT_RIFLE_NAME";
        skillDefInfo.skillDescriptionToken = text + "_CONSCRIPT_BODY_PRIMARY_ALT_RIFLE_DESCRIPTION";
        skillDefInfo.skillIcon = Assets.mainAssetBundle.LoadAsset<Sprite>("texPrimarySkill");
        skillDefInfo.activationState = new SerializableEntityStateType(typeof(ShootBurst));
        skillDefInfo.activationStateMachineName = "Slide";
        skillDefInfo.baseMaxStock = 1;
        skillDefInfo.baseRechargeInterval = 0f;
        skillDefInfo.beginSkillCooldownOnSkillEnd = true;
        skillDefInfo.canceledFromSprinting = false;
        skillDefInfo.forceSprintDuringState = false;
        skillDefInfo.fullRestockOnAssign = true;
        skillDefInfo.interruptPriority = InterruptPriority.Skill;
        skillDefInfo.resetCooldownTimerOnUse = false;
        skillDefInfo.isCombatSkill = true;
        skillDefInfo.mustKeyPress = false;
        skillDefInfo.cancelSprintingOnActivation = true;
        skillDefInfo.rechargeStock = 1;
        skillDefInfo.requiredStock = 1;
        skillDefInfo.stockToConsume = 1;
        SkillDef skillDef2 = Skills.CreateSkillDef(skillDefInfo);
        Skills.AddPrimarySkills(this.bodyPrefab, skillDef);
        Skills.AddPrimarySkills(this.bodyPrefab, skillDef2);
        skillDefInfo = new SkillDefInfo();
        skillDefInfo.skillName = text + "_CONSCRIPT_BODY_SECONDARY_BATON_NAME";
        skillDefInfo.skillNameToken = text + "_CONSCRIPT_BODY_SECONDARY_BATON_NAME";
        skillDefInfo.skillDescriptionToken = text + "_CONSCRIPT_BODY_SECONDARY_BATON_DESCRIPTION";
        skillDefInfo.skillIcon = Assets.mainAssetBundle.LoadAsset<Sprite>("texSecondarySkill");
        skillDefInfo.activationState = new SerializableEntityStateType(typeof(BatonAttack));
        skillDefInfo.activationStateMachineName = "Weapon";
        skillDefInfo.baseMaxStock = 1;
        skillDefInfo.baseRechargeInterval = 6f;
        skillDefInfo.beginSkillCooldownOnSkillEnd = false;
        skillDefInfo.canceledFromSprinting = false;
        skillDefInfo.forceSprintDuringState = false;
        skillDefInfo.fullRestockOnAssign = true;
        skillDefInfo.interruptPriority = InterruptPriority.Any;
        skillDefInfo.resetCooldownTimerOnUse = false;
        skillDefInfo.isCombatSkill = true;
        skillDefInfo.mustKeyPress = false;
        skillDefInfo.cancelSprintingOnActivation = true;
        skillDefInfo.rechargeStock = 1;
        skillDefInfo.requiredStock = 1;
        skillDefInfo.stockToConsume = 1;
        SkillDef skillDef3 = Skills.CreateSkillDef(skillDefInfo);
        Skills.AddSecondarySkills(this.bodyPrefab, skillDef3);
        skillDefInfo = new SkillDefInfo();
        skillDefInfo.skillName = text + "_CONSCRIPT_BODY_UTILITY_KICK_NAME";
        skillDefInfo.skillNameToken = text + "_CONSCRIPT_BODY_UTILITY_KICK_NAME";
        skillDefInfo.skillDescriptionToken = text + "_CONSCRIPT_BODY_UTILITY_KICK_DESCRIPTION";
        skillDefInfo.skillIcon = Assets.mainAssetBundle.LoadAsset<Sprite>("texUtilitySkill");
        skillDefInfo.activationState = new SerializableEntityStateType(typeof(KickAttack));
        skillDefInfo.activationStateMachineName = "Body";
        skillDefInfo.baseMaxStock = 1;
        skillDefInfo.baseRechargeInterval = 8f;
        skillDefInfo.beginSkillCooldownOnSkillEnd = false;
        skillDefInfo.canceledFromSprinting = false;
        skillDefInfo.forceSprintDuringState = true;
        skillDefInfo.fullRestockOnAssign = true;
        skillDefInfo.interruptPriority = InterruptPriority.PrioritySkill;
        skillDefInfo.resetCooldownTimerOnUse = false;
        skillDefInfo.isCombatSkill = false;
        skillDefInfo.mustKeyPress = false;
        skillDefInfo.cancelSprintingOnActivation = false;
        skillDefInfo.rechargeStock = 1;
        skillDefInfo.requiredStock = 1;
        skillDefInfo.stockToConsume = 1;
        SkillDef skillDef4 = Skills.CreateSkillDef(skillDefInfo);
        Skills.AddUtilitySkills(this.bodyPrefab, skillDef4);
        skillDefInfo = new SkillDefInfo();
        skillDefInfo.skillName = text + "_CONSCRIPT_BODY_SPECIAL_GRENADE_NAME";
        skillDefInfo.skillNameToken = text + "_CONSCRIPT_BODY_SPECIAL_GRENADE_NAME";
        skillDefInfo.skillDescriptionToken = text + "_CONSCRIPT_BODY_SPECIAL_GRENADE_DESCRIPTION";
        skillDefInfo.skillIcon = Assets.mainAssetBundle.LoadAsset<Sprite>("texSpecialSkill");
        skillDefInfo.activationState = new SerializableEntityStateType(typeof(ThrowBomb));
        skillDefInfo.activationStateMachineName = "Weapon";
        skillDefInfo.baseMaxStock = 2;
        skillDefInfo.baseRechargeInterval = 20f;
        skillDefInfo.beginSkillCooldownOnSkillEnd = false;
        skillDefInfo.canceledFromSprinting = false;
        skillDefInfo.forceSprintDuringState = false;
        skillDefInfo.fullRestockOnAssign = true;
        skillDefInfo.interruptPriority = InterruptPriority.Any;
        skillDefInfo.resetCooldownTimerOnUse = false;
        skillDefInfo.isCombatSkill = true;
        skillDefInfo.mustKeyPress = false;
        skillDefInfo.cancelSprintingOnActivation = true;
        skillDefInfo.rechargeStock = 1;
        skillDefInfo.requiredStock = 1;
        skillDefInfo.stockToConsume = 1;
        SkillDef skillDef5 = Skills.CreateSkillDef(skillDefInfo);
        Skills.AddSpecialSkills(this.bodyPrefab, skillDef5);
    }

    public override void InitializeSkins()
    {
        ModelSkinController modelSkinController = this.prefabCharacterModel.gameObject.AddComponent<ModelSkinController>();
        ChildLocator component = this.prefabCharacterModel.GetComponent<ChildLocator>();
        CharacterModel.RendererInfo[] baseRendererInfos = this.prefabCharacterModel.baseRendererInfos;
        List<SkinDef> list = new List<SkinDef>();
        SkinDef skinDef = Skins.CreateSkinDef("MANTI_CONSCRIPT_BODY_DEFAULT_SKIN_NAME", Assets.mainAssetBundle.LoadAsset<Sprite>("texConscriptDefault"), baseRendererInfos, this.prefabCharacterModel.gameObject);
        skinDef.meshReplacements = Skins.getMeshReplacements(baseRendererInfos, "krontroop", "krongun", "kronbaton");
        list.Add(skinDef);
        SkinDef skinDef2 = Skins.CreateSkinDef("MANTI_CONSCRIPT_BODY_MASTERY_SKIN_NAME", Assets.mainAssetBundle.LoadAsset<Sprite>("texConscriptMastery"), baseRendererInfos, this.prefabCharacterModel.gameObject, MyCharacter.masterySkinUnlockableDef);
        skinDef2.meshReplacements = Skins.getMeshReplacements(baseRendererInfos, "kronmastery", null, "kronmasterybaton");
        skinDef2.rendererInfos[0].defaultMaterial = Materials.CreateHopooMaterial("kronMasteryMaterial");
        skinDef2.rendererInfos[1].defaultMaterial = Materials.CreateHopooMaterial("kronMasteryMaterial");
        skinDef2.rendererInfos[2].defaultMaterial = Materials.CreateHopooMaterial("kronMasteryMaterial");
        list.Add(skinDef2);
        modelSkinController.skins = list.ToArray();
    }
}
