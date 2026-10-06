using System;
using System.Collections.Generic;
using On.RoR2;
using RoR2;
using UnityEngine;

namespace ConscriptMod.Modules;

internal static class Skins
{
    internal struct SkinDefInfo
    {
        internal RoR2.SkinDef[] BaseSkins;

        internal Sprite Icon;

        internal string NameToken;

        internal RoR2.UnlockableDef UnlockableDef;

        internal GameObject RootObject;

        internal RoR2.CharacterModel.RendererInfo[] RendererInfos;

        internal RoR2.SkinDef.MeshReplacement[] MeshReplacements;

        internal RoR2.SkinDef.GameObjectActivation[] GameObjectActivations;

        internal RoR2.SkinDef.ProjectileGhostReplacement[] ProjectileGhostReplacements;

        internal RoR2.SkinDef.MinionSkinReplacement[] MinionSkinReplacements;

        internal string Name;
    }

    internal static RoR2.SkinDef CreateSkinDef(string skinName, Sprite skinIcon, RoR2.CharacterModel.RendererInfo[] defaultRendererInfos, GameObject root, RoR2.UnlockableDef unlockableDef = null)
    {
        SkinDefInfo skinDefInfo = default(SkinDefInfo);
        skinDefInfo.BaseSkins = Array.Empty<RoR2.SkinDef>();
        skinDefInfo.GameObjectActivations = new RoR2.SkinDef.GameObjectActivation[0];
        skinDefInfo.Icon = skinIcon;
        skinDefInfo.MeshReplacements = new RoR2.SkinDef.MeshReplacement[0];
        skinDefInfo.MinionSkinReplacements = new RoR2.SkinDef.MinionSkinReplacement[0];
        skinDefInfo.Name = skinName;
        skinDefInfo.NameToken = skinName;
        skinDefInfo.ProjectileGhostReplacements = new RoR2.SkinDef.ProjectileGhostReplacement[0];
        skinDefInfo.RendererInfos = new RoR2.CharacterModel.RendererInfo[defaultRendererInfos.Length];
        skinDefInfo.RootObject = root;
        skinDefInfo.UnlockableDef = unlockableDef;
        SkinDefInfo skinDefInfo2 = skinDefInfo;
        On.RoR2.SkinDef.Awake += DoNothing;
        RoR2.SkinDef skinDef = ScriptableObject.CreateInstance<RoR2.SkinDef>();
        skinDef.baseSkins = skinDefInfo2.BaseSkins;
        skinDef.icon = skinDefInfo2.Icon;
        skinDef.unlockableDef = skinDefInfo2.UnlockableDef;
        skinDef.rootObject = skinDefInfo2.RootObject;
        defaultRendererInfos.CopyTo(skinDefInfo2.RendererInfos, 0);
        skinDef.rendererInfos = skinDefInfo2.RendererInfos;
        skinDef.gameObjectActivations = skinDefInfo2.GameObjectActivations;
        skinDef.meshReplacements = skinDefInfo2.MeshReplacements;
        skinDef.projectileGhostReplacements = skinDefInfo2.ProjectileGhostReplacements;
        skinDef.minionSkinReplacements = skinDefInfo2.MinionSkinReplacements;
        skinDef.nameToken = skinDefInfo2.NameToken;
        skinDef.name = skinDefInfo2.Name;
        On.RoR2.SkinDef.Awake -= DoNothing;
        return skinDef;
    }

    private static void DoNothing(On.RoR2.SkinDef.orig_Awake orig, RoR2.SkinDef self)
    {
    }

    private static RoR2.CharacterModel.RendererInfo[] getRendererMaterials(RoR2.CharacterModel.RendererInfo[] defaultRenderers, params Material[] materials)
    {
        RoR2.CharacterModel.RendererInfo[] array = new RoR2.CharacterModel.RendererInfo[defaultRenderers.Length];
        defaultRenderers.CopyTo(array, 0);
        for (int i = 0; i < array.Length; i++)
        {
            try
            {
                array[i].defaultMaterial = materials[i];
            }
            catch
            {
                Log.Error("error adding skin rendererinfo material. make sure you're not passing in too many");
            }
        }
        return array;
    }

    internal static RoR2.SkinDef.MeshReplacement[] getMeshReplacements(RoR2.CharacterModel.RendererInfo[] defaultRendererInfos, params string[] meshes)
    {
        List<RoR2.SkinDef.MeshReplacement> list = new List<RoR2.SkinDef.MeshReplacement>();
        for (int i = 0; i < defaultRendererInfos.Length; i++)
        {
            if (!string.IsNullOrEmpty(meshes[i]))
            {
                list.Add(new RoR2.SkinDef.MeshReplacement
                {
                    renderer = defaultRendererInfos[i].renderer,
                    mesh = Assets.mainAssetBundle.LoadAsset<Mesh>(meshes[i])
                });
            }
        }
        return list.ToArray();
    }
}
