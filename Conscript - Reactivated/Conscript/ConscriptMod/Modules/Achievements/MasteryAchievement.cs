using RoR2;

namespace ConscriptMod.Modules.Achievements
{
    [RegisterAchievement(identifier, unlockableIdentifier, null, 0)]
    public class MasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier =
            "MANTI_CONSCRIPT_BODY_MASTERY";

        public const string unlockableIdentifier =
            "MANTI_CONSCRIPT_BODY_UNLOCKABLE_REWARD_ID";

        public override string RequiredCharacterBody =>
            "ConscriptBody";

        public override float RequiredDifficultyCoefficient =>
            3f;
    }
}