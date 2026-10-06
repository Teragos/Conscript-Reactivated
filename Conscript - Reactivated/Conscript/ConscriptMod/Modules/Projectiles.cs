using R2API;
using RoR2;
using RoR2.Projectile;
using UnityEngine;
using UnityEngine.Networking;

namespace ConscriptMod.Modules;

internal static class Projectiles
{
    internal static GameObject bombPrefab;

    internal static void RegisterProjectiles()
    {
        Projectiles.CreateBomb();
        Projectiles.AddProjectile(Projectiles.bombPrefab);
    }

    internal static void AddProjectile(GameObject projectileToAdd)
    {
        Content.AddProjectilePrefab(projectileToAdd);
    }

    private static void CreateBomb()
    {
        Projectiles.bombPrefab = Projectiles.CloneProjectilePrefab("CommandoGrenadeProjectile", "ConscriptGrenadeProjectile");
        ProjectileImpactExplosion component = Projectiles.bombPrefab.GetComponent<ProjectileImpactExplosion>();
        Projectiles.InitializeImpactExplosion(component);
        component.blastRadius = 22f;
        component.destroyOnEnemy = false;
        component.lifetime = 14f;
        component.impactEffect = Assets.greandeExplosionEffect;
        component.lifetimeExpiredSound = Assets.CreateNetworkSoundEventDef("ConscriptGrenadeExplode");
        component.timerAfterImpact = true;
        component.lifetimeAfterImpact = 0.5f;
        component.blastDamageCoefficient = 1.5f;
        component.GetComponent<ProjectileDamage>().damageType = DamageType.Shock5s;
        ProjectileController component2 = Projectiles.bombPrefab.GetComponent<ProjectileController>();
        if (Assets.mainAssetBundle.LoadAsset<GameObject>("ConscriptGrenadeGhost") != null)
        {
            component2.ghostPrefab = Projectiles.CreateGhostPrefab("ConscriptGrenadeGhost");
        }
        component2.startSound = "";
    }

    private static void InitializeImpactExplosion(ProjectileImpactExplosion projectileImpactExplosion)
    {
        projectileImpactExplosion.blastDamageCoefficient = 1f;
        projectileImpactExplosion.blastProcCoefficient = 1f;
        projectileImpactExplosion.blastRadius = 1f;
        projectileImpactExplosion.bonusBlastForce = Vector3.zero;
        projectileImpactExplosion.childrenCount = 0;
        projectileImpactExplosion.childrenDamageCoefficient = 0f;
        projectileImpactExplosion.childrenProjectilePrefab = null;
        projectileImpactExplosion.destroyOnEnemy = false;
        projectileImpactExplosion.destroyOnWorld = false;
        projectileImpactExplosion.falloffModel = BlastAttack.FalloffModel.None;
        projectileImpactExplosion.fireChildren = false;
        projectileImpactExplosion.impactEffect = null;
        projectileImpactExplosion.lifetime = 0f;
        projectileImpactExplosion.lifetimeAfterImpact = 0f;
        projectileImpactExplosion.lifetimeRandomOffset = 0f;
        projectileImpactExplosion.offsetForLifetimeExpiredSound = 0f;
        projectileImpactExplosion.timerAfterImpact = false;
        projectileImpactExplosion.GetComponent<ProjectileDamage>().damageType = DamageType.Generic;
    }

    private static GameObject CreateGhostPrefab(string ghostName)
    {
        GameObject gameObject = Assets.mainAssetBundle.LoadAsset<GameObject>(ghostName);
        if (!gameObject.GetComponent<NetworkIdentity>())
        {
            gameObject.AddComponent<NetworkIdentity>();
        }
        if (!gameObject.GetComponent<ProjectileGhostController>())
        {
            gameObject.AddComponent<ProjectileGhostController>();
        }
        Assets.ConvertAllRenderersToHopooShader(gameObject);
        return gameObject;
    }

    private static GameObject CloneProjectilePrefab(string prefabName, string newPrefabName)
    {
        return PrefabAPI.InstantiateClone(LegacyResourcesAPI.Load<GameObject>("Prefabs/Projectiles/" + prefabName), newPrefabName);
    }
}
