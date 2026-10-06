using ConscriptMod.Modules;
using ConscriptMod.SkillStates.BaseStates;
using RoR2;
using UnityEngine;

namespace ConscriptMod.SkillStates;

public class BatonAttack : BaseMeleeAttack
{
    public override void OnEnter()
    {
        base.hitboxName = "Baton";
        base.damageType = DamageType.Shock5s;
        base.damageCoefficient = 5f;
        base.procCoefficient = 1f;
        base.pushForce = 300f;
        base.bonusForce = Vector3.zero;
        base.baseDuration = 1f;
        base.attackStartTime = 0.2f;
        base.attackEndTime = 0.4f;
        base.baseEarlyExitTime = 0.4f;
        base.hitStopDuration = 0.012f;
        base.attackRecoil = 0.5f;
        base.hitHopVelocity = 4f;
        Util.PlaySound("ConscriptBatonOn", base.gameObject);
        base.swingSoundString = "ConscriptBatonSwing";
        base.hitSoundString = "";
        base.muzzleString = "SwingCenter";
        base.swingEffectPrefab = ConscriptMod.Modules.Assets.batonSwingEffect;
        base.hitEffectPrefab = ConscriptMod.Modules.Assets.bulletImpact;
        base.OnEnter();
    }

    protected override void PlayAttackAnimation()
    {
        base.PlayCrossfade("Gesture, Override", "Slash1", "Slash.playbackRate", base.duration, 0.05f);
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
