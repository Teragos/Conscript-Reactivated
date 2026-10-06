using System.Collections.Generic;
using BepInEx.Configuration;
using ConscriptMod.Modules.Characters;
using RoR2;
using RoR2.Skills;
using UnityEngine;

namespace ConscriptMod.Modules.Survivors;

internal abstract class SurvivorBase : CharacterBase
{
    public abstract string survivorTokenPrefix { get; }

    public abstract UnlockableDef characterUnlockableDef { get; }

    public virtual ConfigEntry<bool> characterEnabledConfig { get; }

    public virtual GameObject displayPrefab { get; set; }

    public override void InitializeCharacter()
    {
        if (this.characterEnabledConfig == null || this.characterEnabledConfig.Value)
        {
            this.InitializeUnlockables();
            base.InitializeCharacter();
            this.InitializeSurvivor();
        }
    }

    protected override void InitializeCharacterBodyAndModel()
    {
        base.InitializeCharacterBodyAndModel();
        this.InitializeDisplayPrefab();
    }

    protected virtual void InitializeSurvivor()
    {
        SurvivorBase.RegisterNewSurvivor(this.bodyPrefab, this.displayPrefab, Color.grey, this.survivorTokenPrefix, this.characterUnlockableDef, this.bodyInfo.sortPosition);
    }

    protected virtual void InitializeDisplayPrefab()
    {
        this.displayPrefab = Prefabs.CreateDisplayPrefab(this.prefabBodyName + "Display", this.bodyPrefab, this.bodyInfo);
        this.displayPrefab.AddComponent<MenuSoundComponent>();
    }

    public virtual void InitializeUnlockables()
    {
    }

    public static void RegisterNewSurvivor(GameObject bodyPrefab, GameObject displayPrefab, Color charColor, string tokenPrefix)
    {
        SurvivorBase.RegisterNewSurvivor(bodyPrefab, displayPrefab, charColor, tokenPrefix, null, 100f);
    }

    public static void RegisterNewSurvivor(GameObject bodyPrefab, GameObject displayPrefab, Color charColor, string tokenPrefix, float sortPosition)
    {
        SurvivorBase.RegisterNewSurvivor(bodyPrefab, displayPrefab, charColor, tokenPrefix, null, sortPosition);
    }

    public static void RegisterNewSurvivor(GameObject bodyPrefab, GameObject displayPrefab, Color charColor, string tokenPrefix, UnlockableDef unlockableDef)
    {
        SurvivorBase.RegisterNewSurvivor(bodyPrefab, displayPrefab, charColor, tokenPrefix, unlockableDef, 100f);
    }

    public static void RegisterNewSurvivor(GameObject bodyPrefab, GameObject displayPrefab, Color charColor, string tokenPrefix, UnlockableDef unlockableDef, float sortPosition)
    {
        SurvivorDef survivorDef = ScriptableObject.CreateInstance<SurvivorDef>();
        survivorDef.bodyPrefab = bodyPrefab;
        survivorDef.displayPrefab = displayPrefab;
        survivorDef.primaryColor = charColor;
        survivorDef.cachedName = bodyPrefab.name.Replace("Body", "");
        survivorDef.displayNameToken = tokenPrefix + "NAME";
        survivorDef.descriptionToken = tokenPrefix + "DESCRIPTION";
        survivorDef.outroFlavorToken = tokenPrefix + "OUTRO_FLAVOR";
        survivorDef.mainEndingEscapeFailureFlavorToken = tokenPrefix + "OUTRO_FAILURE";
        survivorDef.desiredSortPosition = sortPosition;
        survivorDef.unlockableDef = unlockableDef;
        Content.AddSurvivorDef(survivorDef);
    }

    protected virtual void AddCssPreviewSkill(int indexFromEditor, SkillFamily skillFamily, SkillDef skillDef)
    {
        CharacterSelectSurvivorPreviewDisplayController component = this.displayPrefab.GetComponent<CharacterSelectSurvivorPreviewDisplayController>();
        if (!component)
        {
            Log.Error("trying to add skillChangeResponse to null CharacterSelectSurvivorPreviewDisplayController.\nMake sure you created one on your Display prefab in editor");
            return;
        }
        component.skillChangeResponses[indexFromEditor].triggerSkillFamily = skillFamily;
        component.skillChangeResponses[indexFromEditor].triggerSkill = skillDef;
    }

    protected virtual void AddCssPreviewSkin(int indexFromEditor, SkinDef skinDef)
    {
        CharacterSelectSurvivorPreviewDisplayController component = this.displayPrefab.GetComponent<CharacterSelectSurvivorPreviewDisplayController>();
        if (!component)
        {
            Log.Error("trying to add skinChangeResponse to null CharacterSelectSurvivorPreviewDisplayController.\nMake sure you created one on your Display prefab in editor");
        }
        else
        {
            component.skinChangeResponses[indexFromEditor].triggerSkin = skinDef;
        }
    }

    protected virtual void FinalizeCSSPreviewDisplayController()
    {
        if (!this.displayPrefab)
        {
            return;
        }
        CharacterSelectSurvivorPreviewDisplayController component = this.displayPrefab.GetComponent<CharacterSelectSurvivorPreviewDisplayController>();
        if (!component)
        {
            return;
        }
        component.bodyPrefab = this.bodyPrefab;
        List<CharacterSelectSurvivorPreviewDisplayController.SkillChangeResponse> list = new List<CharacterSelectSurvivorPreviewDisplayController.SkillChangeResponse>();
        for (int i = 0; i < component.skillChangeResponses.Length; i++)
        {
            if (component.skillChangeResponses[i].triggerSkillFamily != null)
            {
                list.Add(component.skillChangeResponses[i]);
            }
        }
        component.skillChangeResponses = list.ToArray();
    }
}
