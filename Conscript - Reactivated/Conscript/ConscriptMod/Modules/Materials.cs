using System.Collections.Generic;
using RoR2;
using UnityEngine;

namespace ConscriptMod.Modules;

internal static class Materials
{
    private static List<Material> cachedMaterials = new List<Material>();

    internal static Shader hotpoo = LegacyResourcesAPI.Load<Shader>("Shaders/Deferred/HGStandard");

    public static Material CreateHopooMaterial(string materialName)
    {
        Material material = Materials.cachedMaterials.Find(delegate(Material mat)
        {
            materialName.Replace(" (Instance)", "");
            return mat.name.Contains(materialName);
        });
        if ((bool)material)
        {
            return material;
        }
        material = Assets.mainAssetBundle.LoadAsset<Material>(materialName);
        if (!material)
        {
            Log.Error("Failed to load material: " + materialName + " - Check to see that the material in your Unity project matches this name");
            return new Material(Materials.hotpoo);
        }
        return material.SetHopooMaterial();
    }

    public static Material SetHopooMaterial(this Material tempMat)
    {
        if (Materials.cachedMaterials.Contains(tempMat))
        {
            return tempMat;
        }
        float? num = null;
        Color? color = null;
        if (tempMat.IsKeywordEnabled("_NORMALMAP"))
        {
            num = tempMat.GetFloat("_BumpScale");
        }
        if (tempMat.IsKeywordEnabled("_EMISSION"))
        {
            color = tempMat.GetColor("_EmissionColor");
        }
        tempMat.shader = Materials.hotpoo;
        tempMat.SetColor("_Color", tempMat.GetColor("_Color"));
        tempMat.SetTexture("_MainTex", tempMat.GetTexture("_MainTex"));
        tempMat.SetTexture("_EmTex", tempMat.GetTexture("_EmissionMap"));
        tempMat.EnableKeyword("DITHER");
        if (num.HasValue)
        {
            tempMat.SetFloat("_NormalStrength", num.Value);
        }
        if (color.HasValue)
        {
            tempMat.SetColor("_EmColor", color.Value);
            tempMat.SetFloat("_EmPower", 1f);
        }
        if (tempMat.IsKeywordEnabled("NOCULL"))
        {
            tempMat.SetInt("_Cull", 0);
        }
        if (tempMat.IsKeywordEnabled("LIMBREMOVAL"))
        {
            tempMat.SetInt("_LimbRemovalOn", 1);
        }
        Materials.cachedMaterials.Add(tempMat);
        return tempMat;
    }

    public static Material MakeUnique(this Material material)
    {
        if (Materials.cachedMaterials.Contains(material))
        {
            return new Material(material);
        }
        return material;
    }

    public static Material SetColor(this Material material, Color color)
    {
        material.SetColor("_Color", color);
        return material;
    }

    public static Material SetNormal(this Material material, float normalStrength = 1f)
    {
        material.SetFloat("_NormalStrength", normalStrength);
        return material;
    }

    public static Material SetEmission(this Material material)
    {
        return material.SetEmission(1f);
    }

    public static Material SetEmission(this Material material, float emission)
    {
        return material.SetEmission(emission, Color.white);
    }

    public static Material SetEmission(this Material material, float emission, Color emissionColor)
    {
        material.SetFloat("_EmPower", emission);
        material.SetColor("_EmColor", emissionColor);
        return material;
    }

    public static Material SetCull(this Material material, bool cull = false)
    {
        material.SetInt("_Cull", cull ? 1 : 0);
        return material;
    }
}
