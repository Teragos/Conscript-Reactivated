using ConscriptMod.SkillStates;
using ConscriptMod.SkillStates.BaseStates;

namespace ConscriptMod.Modules;

public static class States
{
    internal static void RegisterStates()
    {
        Content.AddEntityState(typeof(BaseMeleeAttack));
        Content.AddEntityState(typeof(BatonAttack));
        Content.AddEntityState(typeof(Shoot));
        Content.AddEntityState(typeof(Roll));
        Content.AddEntityState(typeof(ThrowBomb));
        Content.AddEntityState(typeof(KickAttack));
        Content.AddEntityState(typeof(ShootBurst));
    }
}
