using ConscriptMod.Modules;
using EntityStates;
using RoR2;
using UnityEngine;

namespace ConscriptMod.SkillStates;

public class ShootBurst : BaseSkillState
{
    public static float damageCoefficient = 1f;

    public static float procCoefficient = 0.5f;

    public static float baseDuration = 1f;

    public static float force = 800f;

    public static float recoil = 5f;

    public static float range = 128f;

    public static GameObject tracerEffectPrefab = LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/TracerBanditPistol");

    private float duration;

    private float fireTime;

    private bool hasFired;

    private string muzzleString;

    public override void OnEnter()
    {
        base.OnEnter();
        this.duration = ShootBurst.baseDuration / base.attackSpeedStat;
        this.fireTime = 0f;
        base.characterBody.SetAimTimer(2f);
        this.muzzleString = "Muzzle";
        ((EntityState)this).PlayAnimation("Gesture, Override", "ShootGun", "ShootGun.playbackRate", 1f);
    }

    public override void OnExit()
    {
        base.OnExit();
    }

    private void Fire()
    {
        if (!this.hasFired)
        {
            this.hasFired = true;
            base.characterBody.AddSpreadBloom(1.5f);
            EffectManager.SimpleMuzzleFlash(ConscriptMod.Modules.Assets.muzzleFlash, base.gameObject, this.muzzleString, transmit: false);
            Util.PlaySound("ConscriptBurstShot", base.gameObject);
            if (base.isAuthority)
            {
                Ray aimRay = base.GetAimRay();
                base.AddRecoil(-1f * Shoot.recoil, -2f * Shoot.recoil, -0.5f * Shoot.recoil, 0.5f * Shoot.recoil);
                BulletAttack bulletAttack = new BulletAttack();
                bulletAttack.bulletCount = 10u;
                bulletAttack.aimVector = aimRay.direction;
                bulletAttack.origin = aimRay.origin;
                bulletAttack.damage = ShootBurst.damageCoefficient * base.damageStat;
                bulletAttack.damageColorIndex = DamageColorIndex.Default;
                bulletAttack.damageType = DamageType.Generic;
                bulletAttack.falloffModel = BulletAttack.FalloffModel.Buckshot;
                bulletAttack.maxDistance = ShootBurst.range;
                bulletAttack.force = ShootBurst.force;
                bulletAttack.hitMask = LayerIndex.CommonMasks.bullet;
                bulletAttack.minSpread = 1f;
                bulletAttack.maxSpread = 8f;
                bulletAttack.isCrit = base.RollCrit();
                bulletAttack.owner = base.gameObject;
                bulletAttack.muzzleName = this.muzzleString;
                bulletAttack.smartCollision = false;
                bulletAttack.procChainMask = default(ProcChainMask);
                bulletAttack.procCoefficient = ShootBurst.procCoefficient;
                bulletAttack.radius = 0.75f;
                bulletAttack.sniper = false;
                bulletAttack.stopperMask = LayerIndex.CommonMasks.bullet;
                bulletAttack.weapon = null;
                bulletAttack.tracerEffectPrefab = ShootBurst.tracerEffectPrefab;
                bulletAttack.spreadPitchScale = 1f;
                bulletAttack.spreadYawScale = 1f;
                bulletAttack.queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
                bulletAttack.hitEffectPrefab = ConscriptMod.Modules.Assets.bulletImpact;
                bulletAttack.Fire();
            }
        }
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
        if (base.fixedAge >= this.fireTime)
        {
            this.Fire();
        }
        if (base.fixedAge >= this.duration && base.isAuthority)
        {
            base.outer.SetNextStateToMain();
        }
    }

    public override InterruptPriority GetMinimumInterruptPriority()
    {
        return InterruptPriority.PrioritySkill;
    }
}
