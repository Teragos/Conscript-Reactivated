using ConscriptMod.Modules;
using EntityStates;
using EntityStates.Commando;
using RoR2;
using UnityEngine;
using UnityEngine.Networking;

namespace ConscriptMod.SkillStates;

public class Roll : BaseSkillState
{
    public static float duration = 0.5f;

    public static float initialSpeedCoefficient = 5f;

    public static float finalSpeedCoefficient = 2.5f;

    public static string dodgeSoundString = "Roll";

    public static float dodgeFOV = DodgeState.dodgeFOV;

    private float rollSpeed;

    private Vector3 forwardDirection;

    private Animator animator;

    private Vector3 previousPosition;

    public override void OnEnter()
    {
        base.OnEnter();
        this.animator = base.GetModelAnimator();
        if (base.isAuthority && (bool)base.inputBank && (bool)base.characterDirection)
        {
            this.forwardDirection = ((base.inputBank.moveVector == Vector3.zero) ? base.characterDirection.forward : base.inputBank.moveVector).normalized;
        }
        Vector3 rhs = (base.characterDirection ? base.characterDirection.forward : this.forwardDirection);
        Vector3 rhs2 = Vector3.Cross(Vector3.up, rhs);
        float num = Vector3.Dot(this.forwardDirection, rhs);
        float num2 = Vector3.Dot(this.forwardDirection, rhs2);
        this.RecalculateRollSpeed();
        if ((bool)(Object)(object)base.characterMotor && (bool)base.characterDirection)
        {
            base.characterMotor.velocity.y = 0f;
            base.characterMotor.velocity = this.forwardDirection * this.rollSpeed;
        }
        Vector3 obj = (((Object)(object)base.characterMotor) ? base.characterMotor.velocity : Vector3.zero);
        this.previousPosition = base.transform.position - obj;
        ((EntityState)this).PlayAnimation("FullBody, Override", "Roll", "Roll.playbackRate", Roll.duration);
        Util.PlaySound(Roll.dodgeSoundString, base.gameObject);
        if (NetworkServer.active)
        {
            base.characterBody.AddTimedBuff(Buffs.armorBuff, 3f * Roll.duration);
            base.characterBody.AddTimedBuff(RoR2Content.Buffs.HiddenInvincibility, 0.5f * Roll.duration);
        }
    }

    private void RecalculateRollSpeed()
    {
        this.rollSpeed = base.moveSpeedStat * Mathf.Lerp(Roll.initialSpeedCoefficient, Roll.finalSpeedCoefficient, base.fixedAge / Roll.duration);
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
        this.RecalculateRollSpeed();
        if ((bool)base.characterDirection)
        {
            base.characterDirection.forward = this.forwardDirection;
        }
        if ((bool)base.cameraTargetParams)
        {
            base.cameraTargetParams.fovOverride = Mathf.Lerp(Roll.dodgeFOV, 60f, base.fixedAge / Roll.duration);
        }
        Vector3 normalized = (base.transform.position - this.previousPosition).normalized;
        if ((bool)(Object)(object)base.characterMotor && (bool)base.characterDirection && normalized != Vector3.zero)
        {
            float num = Mathf.Max(Vector3.Dot(normalized * this.rollSpeed, this.forwardDirection), 0f);
            Vector3 velocity = this.forwardDirection * num;
            velocity.y = 0f;
            base.characterMotor.velocity = velocity;
        }
        this.previousPosition = base.transform.position;
        if (base.isAuthority && base.fixedAge >= Roll.duration)
        {
            base.outer.SetNextStateToMain();
        }
    }

    public override void OnExit()
    {
        if ((bool)base.cameraTargetParams)
        {
            base.cameraTargetParams.fovOverride = -1f;
        }
        base.OnExit();
        base.characterMotor.disableAirControlUntilCollision = false;
    }

    public override void OnSerialize(NetworkWriter writer)
    {
        base.OnSerialize(writer);
        writer.Write(this.forwardDirection);
    }

    public override void OnDeserialize(NetworkReader reader)
    {
        base.OnDeserialize(reader);
        this.forwardDirection = reader.ReadVector3();
    }
}
