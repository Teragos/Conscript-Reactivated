using System;
using System.IO;
using System.Reflection;
using R2API;
using RoR2;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Rendering;

namespace ConscriptMod.Modules;

internal static class Assets
{
    internal static GameObject batonSwingEffect;

    internal static GameObject greandeExplosionEffect;

    internal static GameObject muzzleFlash;

    internal static GameObject bulletImpact;

    internal static GameObject kickEffect;

    internal static NetworkSoundEventDef batonHitSoundEvent;

    internal static AssetBundle mainAssetBundle;

    private const string assetbundleName = "conscriptassets";

    private const string csProjName = "ConscriptMod";

    internal static void Initialize()
    {
        bool flag = false;
        Assets.LoadAssetBundle();
        Assets.PopulateAssets();
    }

    internal static void LoadAssetBundle()
    {
        try
        {
            if ((UnityEngine.Object)(object)Assets.mainAssetBundle == null)
            {
                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ConscriptMod.conscriptassets"))
                {
                    Assets.mainAssetBundle = AssetBundle.LoadFromStream(stream);
                    return;
                }
            }
        }
        catch (Exception ex)
        {
            Log.Error("Failed to load assetbundle. Make sure your assetbundle name is setup correctly\n" + ex);
        }
    }

    internal static void PopulateAssets()
    {
        if (!(UnityEngine.Object)(object)Assets.mainAssetBundle)
        {
            Log.Error("There is no AssetBundle to load assets from.");
            return;
        }
        Assets.batonHitSoundEvent = Assets.CreateNetworkSoundEventDef("ConscriptBatonHit");
        Assets.greandeExplosionEffect = Assets.LoadEffect("ConscriptGrenadeExplosion", "ConscriptGrenadeExplode");
        Assets.muzzleFlash = Assets.LoadEffect("ConscriptMuzzle");
        Assets.bulletImpact = Assets.LoadEffect("ConscriptImpact");
        if ((bool)Assets.greandeExplosionEffect)
        {
            ShakeEmitter shakeEmitter = Assets.greandeExplosionEffect.AddComponent<ShakeEmitter>();
            shakeEmitter.amplitudeTimeDecay = true;
            shakeEmitter.duration = 0.5f;
            shakeEmitter.radius = 200f;
            shakeEmitter.scaleShakeRadiusWithLocalScale = false;
            shakeEmitter.wave = new Wave
            {
                amplitude = 1.5f,
                frequency = 45f,
                cycleOffset = 0f
            };
        }
        Assets.batonSwingEffect = Assets.LoadEffect("ConscriptBatonSwing", parentToTransform: true);
        Assets.kickEffect = Assets.LoadEffect("ConscriptKickWave", parentToTransform: true);
    }

    private static GameObject CreateTracer(string originalTracerName, string newTracerName)
    {
        if (LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/" + originalTracerName) == null)
        {
            return null;
        }
        GameObject gameObject = PrefabAPI.InstantiateClone(LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/" + originalTracerName), newTracerName, true);
        if (!gameObject.GetComponent<EffectComponent>())
        {
            gameObject.AddComponent<EffectComponent>();
        }
        if (!gameObject.GetComponent<VFXAttributes>())
        {
            gameObject.AddComponent<VFXAttributes>();
        }
        if (!gameObject.GetComponent<NetworkIdentity>())
        {
            gameObject.AddComponent<NetworkIdentity>();
        }
        gameObject.GetComponent<Tracer>().speed = 250f;
        gameObject.GetComponent<Tracer>().length = 50f;
        ContentAddition.AddEffect(gameObject);
        return gameObject;
    }

    internal static NetworkSoundEventDef CreateNetworkSoundEventDef(string eventName)
    {
        NetworkSoundEventDef networkSoundEventDef = ScriptableObject.CreateInstance<NetworkSoundEventDef>();
        networkSoundEventDef.akId = AkSoundEngine.GetIDFromString(eventName);
        networkSoundEventDef.eventName = eventName;
        Content.AddNetworkSoundEventDef(networkSoundEventDef);
        return networkSoundEventDef;
    }

    internal static void ConvertAllRenderersToHopooShader(GameObject objectToConvert)
    {
        if ((bool)objectToConvert)
        {
            Renderer[] componentsInChildren = objectToConvert.GetComponentsInChildren<Renderer>();
            for (int i = 0; i < componentsInChildren.Length; i++)
            {
                componentsInChildren[i]?.material?.SetHopooMaterial();
            }
        }
    }

    internal static CharacterModel.RendererInfo[] SetupRendererInfos(GameObject obj)
    {
        MeshRenderer[] componentsInChildren = obj.GetComponentsInChildren<MeshRenderer>();
        CharacterModel.RendererInfo[] array = new CharacterModel.RendererInfo[componentsInChildren.Length];
        for (int i = 0; i < componentsInChildren.Length; i++)
        {
            array[i] = new CharacterModel.RendererInfo
            {
                defaultMaterial = componentsInChildren[i].material,
                renderer = componentsInChildren[i],
                defaultShadowCastingMode = ShadowCastingMode.On,
                ignoreOverlays = false
            };
        }
        return array;
    }

    public static GameObject LoadSurvivorModel(string modelName)
    {
        GameObject gameObject = Assets.mainAssetBundle.LoadAsset<GameObject>(modelName);
        if (gameObject == null)
        {
            Log.Error("Trying to load a null model- check to see if the BodyName in your code matches the prefab name of the object in Unity\nFor Example, if your prefab in unity is 'mdlHenry', then your BodyName must be 'Henry'");
            return null;
        }
        return PrefabAPI.InstantiateClone(gameObject, gameObject.name, false);
    }

    internal static GameObject LoadCrosshair(string crosshairName)
    {
        if (LegacyResourcesAPI.Load<GameObject>("Prefabs/Crosshair/" + crosshairName + "Crosshair") == null)
        {
            return LegacyResourcesAPI.Load<GameObject>("Prefabs/Crosshair/StandardCrosshair");
        }
        return LegacyResourcesAPI.Load<GameObject>("Prefabs/Crosshair/" + crosshairName + "Crosshair");
    }

    private static GameObject LoadEffect(string resourceName)
    {
        return Assets.LoadEffect(resourceName, "", parentToTransform: false);
    }

    private static GameObject LoadEffect(string resourceName, string soundName)
    {
        return Assets.LoadEffect(resourceName, soundName, parentToTransform: false);
    }

    private static GameObject LoadEffect(string resourceName, bool parentToTransform)
    {
        return Assets.LoadEffect(resourceName, "", parentToTransform);
    }

    private static GameObject LoadEffect(string resourceName, string soundName, bool parentToTransform)
    {
        GameObject gameObject = Assets.mainAssetBundle.LoadAsset<GameObject>(resourceName);
        if (!gameObject)
        {
            Log.Error("Failed to load effect: " + resourceName + " because it does not exist in the AssetBundle");
            return null;
        }
        gameObject.AddComponent<DestroyOnTimer>().duration = 12f;
        gameObject.AddComponent<NetworkIdentity>();
        gameObject.AddComponent<VFXAttributes>().vfxPriority = VFXAttributes.VFXPriority.Always;
        EffectComponent effectComponent = gameObject.AddComponent<EffectComponent>();
        effectComponent.applyScale = false;
        effectComponent.effectIndex = EffectIndex.Invalid;
        effectComponent.parentToReferencedTransform = parentToTransform;
        effectComponent.positionAtReferencedTransform = true;
        effectComponent.soundName = soundName;
        ContentAddition.AddEffect(gameObject);
        return gameObject;
    }
}
