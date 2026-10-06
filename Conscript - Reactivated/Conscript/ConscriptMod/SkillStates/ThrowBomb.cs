using ConscriptMod.Modules;
using EntityStates;

namespace ConscriptMod.SkillStates;

public class ThrowBomb : GenericProjectileBaseState
{
    public static float BaseDuration = 0.65f;

    public static float BaseDelayDuration = 0.35f * ThrowBomb.BaseDuration;

    public static float DamageCoefficient = 8f;

    public override void OnEnter()
    {
        base.projectilePrefab = Projectiles.bombPrefab;
        base.attackSoundString = "ConscriptGrenadeThrow";
        base.baseDuration = ThrowBomb.BaseDuration;
        base.baseDelayBeforeFiringProjectile = ThrowBomb.BaseDelayDuration;
        base.damageCoefficient = ThrowBomb.DamageCoefficient;
        base.force = 80f;
        base.recoilAmplitude = 0.1f;
        base.bloom = 10f;
        base.OnEnter();
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    public override InterruptPriority GetMinimumInterruptPriority()
    {
        return InterruptPriority.Skill;
    }

    public override void PlayAnimation(float duration)
    {
        if ((bool)base.GetModelAnimator())
        {
            ((EntityState)this).PlayAnimation("Gesture, Override", "ThrowBomb", "ThrowBomb.playbackRate", base.duration);
        }
    }
}
