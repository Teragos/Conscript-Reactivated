using ConscriptMod.Modules;
using EntityStates;
using RoR2;
using UnityEngine;

namespace ConscriptMod.SkillStates;

public class Shoot : BaseSkillState
{
    public static float damageCoefficient = 3f;

    public static float procCoefficient = 1f;

    public static float baseDuration = 0.75f;

    public static float force = 800f;

    public static float recoil = 3f;

    public static float range = 256f;

    public static GameObject tracerEffectPrefab = LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/TracerBanditPistol");

    private float duration;

    private float fireTime;

    private bool hasFired;

    private string muzzleString;

    public override void OnEnter()
    {
        base.OnEnter();
        this.duration = Shoot.baseDuration / base.attackSpeedStat;
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
            Util.PlaySound("ConscriptPiercingShot", base.gameObject);
            if (base.isAuthority)
            {
                Ray aimRay = base.GetAimRay();
                base.AddRecoil(-1f * Shoot.recoil, -2f * Shoot.recoil, -0.5f * Shoot.recoil, 0.5f * Shoot.recoil);
                BulletAttack bulletAttack = new BulletAttack();
                bulletAttack.bulletCount = 1u;
                bulletAttack.aimVector = aimRay.direction;
                bulletAttack.origin = aimRay.origin;
                bulletAttack.damage = Shoot.damageCoefficient * base.damageStat;
                bulletAttack.damageColorIndex = DamageColorIndex.Default;
                bulletAttack.damageType = DamageType.Generic;
                bulletAttack.falloffModel = BulletAttack.FalloffModel.DefaultBullet;
                bulletAttack.maxDistance = Shoot.range;
                bulletAttack.force = Shoot.force;
                bulletAttack.hitMask = LayerIndex.CommonMasks.bullet;
                bulletAttack.minSpread = 0f;
                bulletAttack.maxSpread = 0f;
                bulletAttack.isCrit = base.RollCrit();
                bulletAttack.owner = base.gameObject;
                bulletAttack.muzzleName = this.muzzleString;
                bulletAttack.smartCollision = false;
                bulletAttack.procChainMask = default(ProcChainMask);
                bulletAttack.procCoefficient = Shoot.procCoefficient;
                bulletAttack.radius = 0.75f;
                bulletAttack.sniper = false;
                bulletAttack.stopperMask = LayerIndex.CommonMasks.interactable;
                bulletAttack.weapon = null;
                bulletAttack.tracerEffectPrefab = Shoot.tracerEffectPrefab;
                bulletAttack.spreadPitchScale = 0f;
                bulletAttack.spreadYawScale = 0f;
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
