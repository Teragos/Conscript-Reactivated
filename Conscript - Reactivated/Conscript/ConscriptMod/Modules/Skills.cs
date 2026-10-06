using System;
using RoR2;
using RoR2.Skills;
using UnityEngine;
namespace ConscriptMod.Modules;

internal static class Skills
{
    public static void CreateSkillFamilies(GameObject targetPrefab, bool destroyExisting = true)
    {
        if (destroyExisting)
        {
            GenericSkill[] componentsInChildren = targetPrefab.GetComponentsInChildren<GenericSkill>();
            for (int i = 0; i < componentsInChildren.Length; i++)
            {
                UnityEngine.Object.DestroyImmediate(componentsInChildren[i]);
            }
        }
        SkillLocator component = targetPrefab.GetComponent<SkillLocator>();
        component.primary = Skills.CreateGenericSkillWithSkillFamily(targetPrefab, "Primary");
        component.secondary = Skills.CreateGenericSkillWithSkillFamily(targetPrefab, "Secondary");
        component.utility = Skills.CreateGenericSkillWithSkillFamily(targetPrefab, "Utility");
        component.special = Skills.CreateGenericSkillWithSkillFamily(targetPrefab, "Special");
    }

    public static GenericSkill CreateGenericSkillWithSkillFamily(GameObject targetPrefab, string familyName, bool hidden = false)
    {
        GenericSkill genericSkill = targetPrefab.AddComponent<GenericSkill>();
        genericSkill.skillName = familyName;
        genericSkill.hideInCharacterSelect = hidden;
        SkillFamily skillFamily = ScriptableObject.CreateInstance<SkillFamily>();
        ((UnityEngine.Object)skillFamily).name = targetPrefab.name + familyName + "Family";
        skillFamily.variants = new SkillFamily.Variant[0];
        genericSkill._skillFamily = skillFamily;
        Content.AddSkillFamily(skillFamily);
        return genericSkill;
    }

    public static void AddSkillToFamily(SkillFamily skillFamily, SkillDef skillDef, UnlockableDef unlockableDef = null)
    {
        Array.Resize(ref skillFamily.variants, skillFamily.variants.Length + 1);
        skillFamily.variants[skillFamily.variants.Length - 1] = new SkillFamily.Variant
        {
            skillDef = skillDef,
            unlockableDef = unlockableDef,
            viewableNode = new ViewablesCatalog.Node(skillDef.skillNameToken, isFolder: false)
        };
    }

    public static void AddSkillsToFamily(SkillFamily skillFamily, params SkillDef[] skillDefs)
    {
        for (int i = 0; i < skillDefs.Length; i++)
        {
            Skills.AddSkillToFamily(skillFamily, skillDefs[i]);
        }
    }

    public static void AddPrimarySkills(GameObject targetPrefab, params SkillDef[] skillDefs)
    {
        Skills.AddSkillsToFamily(targetPrefab.GetComponent<SkillLocator>().primary.skillFamily, skillDefs);
    }

    public static void AddSecondarySkills(GameObject targetPrefab, params SkillDef[] skillDefs)
    {
        Skills.AddSkillsToFamily(targetPrefab.GetComponent<SkillLocator>().secondary.skillFamily, skillDefs);
    }

    public static void AddUtilitySkills(GameObject targetPrefab, params SkillDef[] skillDefs)
    {
        Skills.AddSkillsToFamily(targetPrefab.GetComponent<SkillLocator>().utility.skillFamily, skillDefs);
    }

    public static void AddSpecialSkills(GameObject targetPrefab, params SkillDef[] skillDefs)
    {
        Skills.AddSkillsToFamily(targetPrefab.GetComponent<SkillLocator>().special.skillFamily, skillDefs);
    }

    public static void AddUnlockablesToFamily(SkillFamily skillFamily, params UnlockableDef[] unlockableDefs)
    {
        for (int i = 0; i < unlockableDefs.Length; i++)
        {
            SkillFamily.Variant variant = skillFamily.variants[i];
            variant.unlockableDef = unlockableDefs[i];
            skillFamily.variants[i] = variant;
        }
    }

    public static SkillDef CreateSkillDef(SkillDefInfo skillDefInfo)
    {
        return Skills.CreateSkillDef<SkillDef>(skillDefInfo);
    }

    public static T CreateSkillDef<T>(SkillDefInfo skillDefInfo) where T : SkillDef
    {
        T val = ScriptableObject.CreateInstance<T>();
        val.skillName = skillDefInfo.skillName;
        ((UnityEngine.Object)val).name = skillDefInfo.skillName;
        val.skillNameToken = skillDefInfo.skillNameToken;
        val.skillDescriptionToken = skillDefInfo.skillDescriptionToken;
        val.icon = skillDefInfo.skillIcon;
        val.activationState = skillDefInfo.activationState;
        val.activationStateMachineName = skillDefInfo.activationStateMachineName;
        val.baseMaxStock = skillDefInfo.baseMaxStock;
        val.baseRechargeInterval = skillDefInfo.baseRechargeInterval;
        val.beginSkillCooldownOnSkillEnd = skillDefInfo.beginSkillCooldownOnSkillEnd;
        val.canceledFromSprinting = skillDefInfo.canceledFromSprinting;
        val.forceSprintDuringState = skillDefInfo.forceSprintDuringState;
        val.fullRestockOnAssign = skillDefInfo.fullRestockOnAssign;
        val.interruptPriority = skillDefInfo.interruptPriority;
        val.resetCooldownTimerOnUse = skillDefInfo.resetCooldownTimerOnUse;
        val.isCombatSkill = skillDefInfo.isCombatSkill;
        val.mustKeyPress = skillDefInfo.mustKeyPress;
        val.cancelSprintingOnActivation = skillDefInfo.cancelSprintingOnActivation;
        val.rechargeStock = skillDefInfo.rechargeStock;
        val.requiredStock = skillDefInfo.requiredStock;
        val.stockToConsume = skillDefInfo.stockToConsume;
        val.keywordTokens = skillDefInfo.keywordTokens;
        Content.AddSkillDef(val);
        return val;
    }
}
