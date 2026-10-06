using System;
using EntityStates;
using HG;
using RoR2;
using RoR2.ContentManagement;
using UnityEngine;

namespace ConscriptMod.Modules.Characters;

internal abstract class CharacterBase
{
    public abstract string prefabBodyName { get; }

    public abstract BodyInfo bodyInfo { get; set; }

    public abstract CustomRendererInfo[] customRendererInfos { get; set; }

    public abstract Type characterMainState { get; }

    public virtual Type characterSpawnState { get; }

    public virtual ItemDisplaysBase itemDisplays { get; } = null;


    public virtual GameObject bodyPrefab { get; set; }

    public virtual CharacterBody prefabCharacterBody { get; set; }

    public virtual CharacterModel prefabCharacterModel { get; set; }

    public string fullBodyName => this.prefabBodyName + "Body";

    public virtual void Initialize()
    {
        this.InitializeCharacter();
    }

    public virtual void InitializeCharacter()
    {
        this.InitializeCharacterBodyAndModel();
        this.InitializeCharacterMaster();
        this.InitializeEntityStateMachine();
        this.InitializeSkills();
        this.InitializeHitboxes();
        this.InitializeHurtboxes();
        this.InitializeSkins();
        this.InitializeItemDisplays();
        this.InitializeDoppelganger("Commando");
    }

    protected virtual void InitializeCharacterBodyAndModel()
    {
        this.bodyPrefab = Prefabs.CreateBodyPrefab(this.prefabBodyName + "Body", "mdl" + this.prefabBodyName, this.bodyInfo);
        this.prefabCharacterBody = this.bodyPrefab.GetComponent<CharacterBody>();
        this.InitializeCharacterModel();
    }

    protected virtual void InitializeCharacterModel()
    {
        this.prefabCharacterModel = Prefabs.SetupCharacterModel(this.bodyPrefab, this.customRendererInfos);
    }

    protected virtual void InitializeCharacterMaster()
    {
    }

    protected virtual void InitializeEntityStateMachine()
    {
        this.bodyPrefab.GetComponent<EntityStateMachine>().mainStateType = new SerializableEntityStateType(this.characterMainState);
        Content.AddEntityState(this.characterMainState);
        if (this.characterSpawnState != null)
        {
            this.bodyPrefab.GetComponent<EntityStateMachine>().initialStateType = new SerializableEntityStateType(this.characterSpawnState);
            Content.AddEntityState(this.characterSpawnState);
        }
    }

    public abstract void InitializeSkills();

    public virtual void InitializeHitboxes()
    {
    }

    public virtual void InitializeHurtboxes()
    {
        Prefabs.SetupHurtBoxes(this.bodyPrefab);
    }

    public virtual void InitializeSkins()
    {
    }

    public virtual void InitializeDoppelganger(string clone)
    {
        Prefabs.CreateGenericDoppelganger(this.bodyPrefab, this.bodyInfo.bodyName + "MonsterMaster", clone);
    }

    public virtual void InitializeItemDisplays()
    {
        ItemDisplayRuleSet itemDisplayRuleSet = ScriptableObject.CreateInstance<ItemDisplayRuleSet>();
        itemDisplayRuleSet.name = "idrs" + this.prefabBodyName;
        this.prefabCharacterModel.itemDisplayRuleSet = itemDisplayRuleSet;
        if (this.itemDisplays != null)
        {
            ContentManager.onContentPacksAssigned += SetItemDisplays;
        }
    }

    public void SetItemDisplays(ReadOnlyArray<ReadOnlyContentPack> obj)
    {
        this.itemDisplays.SetItemDisplays(this.prefabCharacterModel.itemDisplayRuleSet);
    }
}
