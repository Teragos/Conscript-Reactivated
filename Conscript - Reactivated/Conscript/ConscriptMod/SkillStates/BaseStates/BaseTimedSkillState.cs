using EntityStates;

namespace ConscriptMod.SkillStates.BaseStates;

public class BaseTimedSkillState : BaseSkillState
{
    public static float TimedBaseDuration;

    public static float TimedBaseCastStartTime;

    public static float TimedBaseCastEndTime;

    protected float duration;

    protected float castStartTime;

    protected float castEndTime;

    protected bool hasFired;

    protected bool isFiring;

    protected bool hasExited;

    protected virtual void InitDurationValues(float baseDuration, float baseCastStartTime, float baseCastEndTime = 1f)
    {
        BaseTimedSkillState.TimedBaseDuration = baseDuration;
        BaseTimedSkillState.TimedBaseCastStartTime = baseCastStartTime;
        BaseTimedSkillState.TimedBaseCastEndTime = baseCastEndTime;
        this.duration = BaseTimedSkillState.TimedBaseDuration / base.attackSpeedStat;
        this.castStartTime = baseCastStartTime * this.duration;
        this.castEndTime = baseCastEndTime * this.duration;
    }

    protected virtual void OnCastEnter()
    {
    }

    protected virtual void OnCastFixedUpdate()
    {
    }

    protected virtual void OnCastUpdate()
    {
    }

    protected virtual void OnCastExit()
    {
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
        if (!this.hasFired && base.fixedAge > this.castStartTime)
        {
            this.hasFired = true;
            this.OnCastEnter();
        }
        bool flag = base.fixedAge >= this.castStartTime;
        bool flag2 = base.fixedAge >= this.castEndTime;
        this.isFiring = false;
        if ((flag && !flag2) || (flag && flag2 && !this.hasFired))
        {
            this.isFiring = true;
            this.OnCastFixedUpdate();
        }
        if (flag2 && !this.hasExited)
        {
            this.hasExited = true;
            this.OnCastExit();
        }
        if (base.fixedAge > this.duration)
        {
            base.outer.SetNextStateToMain();
        }
    }

    public override void Update()
    {
        base.Update();
        if (this.isFiring)
        {
            this.OnCastUpdate();
        }
    }
}
