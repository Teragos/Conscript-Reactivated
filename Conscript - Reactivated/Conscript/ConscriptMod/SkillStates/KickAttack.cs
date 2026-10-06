using ConscriptMod.Modules;
using ConscriptMod.SkillStates.BaseStates;
using EntityStates;
using RoR2;
using UnityEngine;

namespace ConscriptMod.SkillStates;

public class KickAttack : BaseMeleeAttack
{
    public override void OnEnter()
    {
        base.hitboxName = "Baton";
        base.damageType = DamageType.Stun1s;
        base.damageCoefficient = 12f;
        base.procCoefficient = 1f;
        base.pushForce = 2500f;
        base.bonusForce = base.characterDirection.forward * 4000f + Vector3.up * 35f;
        base.baseDuration = 1f;
        base.attackStartTime = 0.45f;
        base.attackEndTime = 1f;
        base.baseEarlyExitTime = 0.5f;
        base.hitStopDuration = 0.012f;
        base.attackRecoil = 0.5f;
        base.hitHopVelocity = 4f;
        base.swingSoundString = "ConscriptKick";
        base.hitSoundString = "";
        base.muzzleString = "SwingCenter";
        base.swingEffectPrefab = ConscriptMod.Modules.Assets.kickEffect;
        base.hitEffectPrefab = ConscriptMod.Modules.Assets.bulletImpact;
        base.OnEnter();
    }

    protected override void PlayAttackAnimation()
    {
        ((EntityState)this).PlayAnimation("FullBody, Override", "Kick", "Kick.playbackRate", base.duration);
    }

    protected override void PlaySwingEffect()
    {
        base.PlaySwingEffect();
    }

    protected override void OnHitEnemyAuthority()
    {
        base.OnHitEnemyAuthority();
    }

    public override void OnExit()
    {
        base.OnExit();
    }
}
