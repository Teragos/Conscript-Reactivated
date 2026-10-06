using System.Collections.Generic;
using ConscriptMod.Modules.Characters;
using R2API;
using RoR2;
using UnityEngine;
using UnityEngine.Rendering;

namespace ConscriptMod.Modules;

internal static class Prefabs
{
    private static PhysicMaterial ragdollMaterial;

    public static GameObject CreateDisplayPrefab(string displayModelName, GameObject prefab, BodyInfo bodyInfo)
    {
        GameObject gameObject = Assets.LoadSurvivorModel(displayModelName);
        CharacterModel characterModel = gameObject.GetComponent<CharacterModel>();
        if (!characterModel)
        {
            characterModel = gameObject.AddComponent<CharacterModel>();
        }
        characterModel.baseRendererInfos = prefab.GetComponentInChildren<CharacterModel>().baseRendererInfos;
        Assets.ConvertAllRenderersToHopooShader(gameObject);
        return gameObject.gameObject;
    }

    public static GameObject CreateBodyPrefab(string bodyName, string modelName, BodyInfo bodyInfo)
    {
        GameObject gameObject = LegacyResourcesAPI.Load<GameObject>("Prefabs/CharacterBodies/" + bodyInfo.bodyNameToClone + "Body");
        if (!gameObject)
        {
            Log.Error(bodyInfo.bodyNameToClone + "Body is not a valid body, character creation failed");
            return null;
        }
        GameObject gameObject2 = PrefabAPI.InstantiateClone(gameObject, bodyName);
        Transform transform = null;
        GameObject gameObject3 = null;
        if (modelName != "mdl")
        {
            gameObject3 = Assets.LoadSurvivorModel(modelName);
            if (gameObject3 == null)
            {
                gameObject3 = gameObject2.GetComponentInChildren<CharacterModel>().gameObject;
            }
            transform = Prefabs.AddCharacterModelToSurvivorBody(gameObject2, gameObject3.transform, bodyInfo);
        }
        CharacterBody component = gameObject2.GetComponent<CharacterBody>();
        component.name = bodyInfo.bodyName;
        component.baseNameToken = bodyInfo.bodyNameToken;
        component.subtitleNameToken = bodyInfo.subtitleNameToken;
        component.portraitIcon = bodyInfo.characterPortrait;
        component.bodyColor = bodyInfo.bodyColor;
        RoR2.UI.CrosshairUtils.RequestOverrideForBody(
            component,
            bodyInfo.crosshair,
            RoR2.UI.CrosshairUtils.OverridePriority.Sprint
        );
        component.hideCrosshair = false;
        component.preferredPodPrefab = bodyInfo.podPrefab;
        component.baseMaxHealth = bodyInfo.maxHealth;
        component.baseRegen = bodyInfo.healthRegen;
        component.baseArmor = bodyInfo.armor;
        component.baseMaxShield = bodyInfo.shield;
        component.baseDamage = bodyInfo.damage;
        component.baseAttackSpeed = bodyInfo.attackSpeed;
        component.baseCrit = bodyInfo.crit;
        component.baseMoveSpeed = bodyInfo.moveSpeed;
        component.baseJumpPower = bodyInfo.jumpPower;
        component.autoCalculateLevelStats = bodyInfo.autoCalculateLevelStats;
        if (bodyInfo.autoCalculateLevelStats)
        {
            component.levelMaxHealth = Mathf.Round(component.baseMaxHealth * 0.3f);
            component.levelMaxShield = Mathf.Round(component.baseMaxShield * 0.3f);
            component.levelRegen = component.baseRegen * 0.2f;
            component.levelMoveSpeed = 0f;
            component.levelJumpPower = 0f;
            component.levelDamage = component.baseDamage * 0.2f;
            component.levelAttackSpeed = 0f;
            component.levelCrit = 0f;
            component.levelArmor = 0f;
        }
        else
        {
            component.levelMaxHealth = bodyInfo.healthGrowth;
            component.levelMaxShield = bodyInfo.shieldGrowth;
            component.levelRegen = bodyInfo.regenGrowth;
            component.levelMoveSpeed = bodyInfo.moveSpeedGrowth;
            component.levelJumpPower = bodyInfo.jumpPowerGrowth;
            component.levelDamage = bodyInfo.damageGrowth;
            component.levelAttackSpeed = bodyInfo.attackSpeedGrowth;
            component.levelCrit = bodyInfo.critGrowth;
            component.levelArmor = bodyInfo.armorGrowth;
        }
        component.baseAcceleration = bodyInfo.acceleration;
        component.baseJumpCount = bodyInfo.jumpCount;
        component.sprintingSpeedMultiplier = 1.45f;
        component.bodyFlags = CharacterBody.BodyFlags.ImmuneToExecutes;
        component.rootMotionInMainState = false;
        component.hullClassification = HullClassification.Human;
        component.isChampion = false;
        Prefabs.SetupCameraTargetParams(gameObject2, bodyInfo);
        Prefabs.SetupModelLocator(gameObject2, transform, gameObject3.transform);
        Prefabs.SetupCapsuleCollider(gameObject2);
        Prefabs.SetupMainHurtbox(gameObject2, gameObject3);
        Prefabs.SetupAimAnimator(gameObject2, gameObject3);
        if (transform != null)
        {
            Prefabs.SetupCharacterDirection(gameObject2, transform, gameObject3.transform);
        }
        Prefabs.SetupFootstepController(gameObject3);
        Prefabs.SetupRagdoll(gameObject3);
        Content.AddCharacterBodyPrefab(gameObject2);
        return gameObject2;
    }

    public static void CreateGenericDoppelganger(GameObject bodyPrefab, string masterName, string masterToCopy)
    {
        GameObject gameObject = PrefabAPI.InstantiateClone(LegacyResourcesAPI.Load<GameObject>("Prefabs/CharacterMasters/" + masterToCopy + "MonsterMaster"), masterName, true);
        gameObject.GetComponent<CharacterMaster>().bodyPrefab = bodyPrefab;
        Content.AddMasterPrefab(gameObject);
    }

    private static Transform AddCharacterModelToSurvivorBody(GameObject bodyPrefab, Transform modelTransform, BodyInfo bodyInfo)
    {
        for (int num = bodyPrefab.transform.childCount - 1; num >= 0; num--)
        {
            Object.DestroyImmediate(bodyPrefab.transform.GetChild(num).gameObject);
        }
        Transform transform = new GameObject("ModelBase").transform;
        transform.parent = bodyPrefab.transform;
        transform.localPosition = bodyInfo.modelBasePosition;
        transform.localRotation = Quaternion.identity;
        modelTransform.parent = transform.transform;
        modelTransform.localPosition = Vector3.zero;
        modelTransform.localRotation = Quaternion.identity;
        GameObject gameObject = new GameObject("CameraPivot");
        gameObject.transform.parent = bodyPrefab.transform;
        gameObject.transform.localPosition = bodyInfo.cameraPivotPosition;
        gameObject.transform.localRotation = Quaternion.identity;
        GameObject gameObject2 = new GameObject("AimOrigin");
        gameObject2.transform.parent = bodyPrefab.transform;
        gameObject2.transform.localPosition = bodyInfo.aimOriginPosition;
        gameObject2.transform.localRotation = Quaternion.identity;
        bodyPrefab.GetComponent<CharacterBody>().aimOriginTransform = gameObject2.transform;
        return transform.transform;
    }

    public static CharacterModel SetupCharacterModel(GameObject prefab)
    {
        return Prefabs.SetupCharacterModel(prefab, null);
    }

    public static CharacterModel SetupCharacterModel(GameObject prefab, CustomRendererInfo[] customInfos)
    {
        CharacterModel characterModel = prefab.GetComponent<ModelLocator>().modelTransform.gameObject.GetComponent<CharacterModel>();
        bool flag = characterModel != null;
        if (!flag)
        {
            characterModel = prefab.GetComponent<ModelLocator>().modelTransform.gameObject.AddComponent<CharacterModel>();
        }
        characterModel.body = prefab.GetComponent<CharacterBody>();
        characterModel.autoPopulateLightInfos = true;
        characterModel.invisibilityCount = 0;
        characterModel.temporaryOverlays = new List<TemporaryOverlayInstance>();
        if (!flag)
        {
            Prefabs.SetupCustomRendererInfos(characterModel, customInfos);
        }
        else
        {
            Prefabs.SetupPreAttachedRendererInfos(characterModel);
        }
        return characterModel;
    }

    public static void SetupPreAttachedRendererInfos(CharacterModel characterModel)
    {
        for (int i = 0; i < characterModel.baseRendererInfos.Length; i++)
        {
            if (characterModel.baseRendererInfos[i].defaultMaterial == null)
            {
                characterModel.baseRendererInfos[i].defaultMaterial = characterModel.baseRendererInfos[i].renderer.sharedMaterial;
            }
            characterModel.baseRendererInfos[i].defaultMaterial.SetHopooMaterial();
        }
    }

    public static void SetupCustomRendererInfos(CharacterModel characterModel, CustomRendererInfo[] customInfos)
    {
        ChildLocator component = characterModel.GetComponent<ChildLocator>();
        if (!component)
        {
            Log.Error("Failed CharacterModel setup: ChildLocator component does not exist on the model");
            return;
        }
        List<CharacterModel.RendererInfo> list = new List<CharacterModel.RendererInfo>();
        for (int i = 0; i < customInfos.Length; i++)
        {
            if (!component.FindChild(customInfos[i].childName))
            {
                Log.Error("Trying to add a RendererInfo for a renderer that does not exist: " + customInfos[i].childName);
                continue;
            }
            Renderer component2 = component.FindChild(customInfos[i].childName).GetComponent<Renderer>();
            if ((bool)component2)
            {
                Material material = customInfos[i].material;
                if (material == null)
                {
                    material = ((!customInfos[i].dontHotpoo) ? component2.material.SetHopooMaterial() : component2.material);
                }
                list.Add(new CharacterModel.RendererInfo
                {
                    renderer = component2,
                    defaultMaterial = material,
                    ignoreOverlays = customInfos[i].ignoreOverlays,
                    defaultShadowCastingMode = ShadowCastingMode.On
                });
            }
        }
        characterModel.baseRendererInfos = list.ToArray();
    }

    private static void SetupCharacterDirection(GameObject prefab, Transform modelBaseTransform, Transform modelTransform)
    {
        if ((bool)prefab.GetComponent<CharacterDirection>())
        {
            CharacterDirection component = prefab.GetComponent<CharacterDirection>();
            component.targetTransform = modelBaseTransform;
            component.overrideAnimatorForwardTransform = null;
            component.rootMotionAccumulator = null;
            component.modelAnimator = modelTransform.GetComponent<Animator>();
            component.driveFromRootRotation = false;
            component.turnSpeed = 720f;
        }
    }

    private static void SetupCameraTargetParams(GameObject prefab, BodyInfo bodyInfo)
    {
        CameraTargetParams component = prefab.GetComponent<CameraTargetParams>();
        component.cameraParams = bodyInfo.cameraParams;
        component.cameraPivotTransform = prefab.transform.Find("CameraPivot");
    }

    private static void SetupModelLocator(GameObject prefab, Transform modelBaseTransform, Transform modelTransform)
    {
        ModelLocator component = prefab.GetComponent<ModelLocator>();
        component.modelTransform = modelTransform;
        component.modelBaseTransform = modelBaseTransform;
    }

    private static void SetupCapsuleCollider(GameObject prefab)
    {
        CapsuleCollider component = prefab.GetComponent<CapsuleCollider>();
        component.center = new Vector3(0f, 0f, 0f);
        component.radius = 0.5f;
        component.height = 1.82f;
        component.direction = 1;
    }

    private static void SetupMainHurtbox(GameObject prefab, GameObject model)
    {
        ChildLocator component = model.GetComponent<ChildLocator>();
        if (!component.FindChild("MainHurtbox"))
        {
            Debug.LogWarning("Could not set up main hurtbox: make sure you have a transform pair in your prefab's ChildLocator component called 'MainHurtbox'");
            return;
        }
        HurtBoxGroup hurtBoxGroup = model.AddComponent<HurtBoxGroup>();
        HurtBox hurtBox = component.FindChild("MainHurtbox").gameObject.AddComponent<HurtBox>();
        hurtBox.gameObject.layer = LayerIndex.entityPrecise.intVal;
        hurtBox.healthComponent = prefab.GetComponent<HealthComponent>();
        hurtBox.isBullseye = true;
        hurtBox.damageModifier = HurtBox.DamageModifier.Normal;
        hurtBox.hurtBoxGroup = hurtBoxGroup;
        hurtBox.indexInGroup = 0;
        hurtBoxGroup.hurtBoxes = new HurtBox[1] { hurtBox };
        hurtBoxGroup.mainHurtBox = hurtBox;
        hurtBoxGroup.bullseyeCount = 1;
    }

    public static void SetupHurtBoxes(GameObject bodyPrefab)
    {
        HealthComponent component = bodyPrefab.GetComponent<HealthComponent>();
        HurtBoxGroup[] componentsInChildren = bodyPrefab.GetComponentsInChildren<HurtBoxGroup>();
        foreach (HurtBoxGroup hurtBoxGroup in componentsInChildren)
        {
            hurtBoxGroup.mainHurtBox.healthComponent = component;
            for (int j = 0; j < hurtBoxGroup.hurtBoxes.Length; j++)
            {
                hurtBoxGroup.hurtBoxes[j].healthComponent = component;
            }
        }
    }

    private static void SetupFootstepController(GameObject model)
    {
        FootstepHandler footstepHandler = model.AddComponent<FootstepHandler>();
        footstepHandler.baseFootstepString = "Play_player_footstep";
        footstepHandler.sprintFootstepOverrideString = "";
        footstepHandler.enableFootstepDust = true;
        footstepHandler.footstepDustPrefab = LegacyResourcesAPI.Load<GameObject>("Prefabs/GenericFootstepDust");
    }

    private static void SetupRagdoll(GameObject model)
    {
        RagdollController component = model.GetComponent<RagdollController>();
        if (!component)
        {
            return;
        }
        if (Prefabs.ragdollMaterial == null)
        {
            Prefabs.ragdollMaterial = LegacyResourcesAPI.Load<GameObject>("Prefabs/CharacterBodies/CommandoBody").GetComponentInChildren<RagdollController>().bones[1].GetComponent<Collider>().material;
        }
        Transform[] bones = component.bones;
        foreach (Transform transform in bones)
        {
            if ((bool)transform)
            {
                transform.gameObject.layer = LayerIndex.ragdoll.intVal;
                Collider component2 = transform.GetComponent<Collider>();
                if ((bool)component2)
                {
                    component2.material = Prefabs.ragdollMaterial;
                    component2.sharedMaterial = Prefabs.ragdollMaterial;
                }
            }
        }
    }

    private static void SetupAimAnimator(GameObject prefab, GameObject model)
    {
        AimAnimator aimAnimator = model.AddComponent<AimAnimator>();
        aimAnimator.directionComponent = prefab.GetComponent<CharacterDirection>();
        aimAnimator.pitchRangeMax = 60f;
        aimAnimator.pitchRangeMin = -60f;
        aimAnimator.yawRangeMin = -80f;
        aimAnimator.yawRangeMax = 80f;
        aimAnimator.pitchGiveupRange = 30f;
        aimAnimator.yawGiveupRange = 10f;
        aimAnimator.giveupDuration = 3f;
        aimAnimator.inputBank = prefab.GetComponent<InputBankTest>();
    }

    public static void SetupHitbox(GameObject prefab, Transform hitboxTransform, string hitboxName)
    {
        HitBoxGroup hitBoxGroup = prefab.AddComponent<HitBoxGroup>();
        HitBox hitBox = hitboxTransform.gameObject.AddComponent<HitBox>();
        hitboxTransform.gameObject.layer = LayerIndex.projectile.intVal;
        hitBoxGroup.hitBoxes = new HitBox[1] { hitBox };
        hitBoxGroup.groupName = hitboxName;
    }

    public static void SetupHitbox(GameObject prefab, string hitboxName, params Transform[] hitboxTransforms)
    {
        HitBoxGroup hitBoxGroup = prefab.AddComponent<HitBoxGroup>();
        List<HitBox> list = new List<HitBox>();
        foreach (Transform transform in hitboxTransforms)
        {
            HitBox item = transform.gameObject.AddComponent<HitBox>();
            transform.gameObject.layer = LayerIndex.projectile.intVal;
            list.Add(item);
        }
        hitBoxGroup.hitBoxes = list.ToArray();
        hitBoxGroup.groupName = hitboxName;
    }
}
