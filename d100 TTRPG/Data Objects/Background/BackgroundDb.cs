using d100_TTRPG.Data_Objects.Skill;
using d100_TTRPG.Data_Objects.Talent;

namespace d100_TTRPG.Data_Objects.Background
{
    public static class BackgroundDb
    {
        public static readonly BackgroundDefinition Aristocrat =
            new BackgroundDefinition(
                Enums.Backgrounds.Aristocrat,

                "You hail from a noble house or a royal line and were raised amongst " +
                "the upper echelons of society. You were trained to have good manners " +
                "and recognize the statuses of others, along with formal instruction " +
                "from tutors.",

                null,

                new List<Skill.SkillDefinition>
                {
                SkillDb.Command
                },

                "You have a strong connection to your noble house, beginning with a " +
                "Friendly disposition from any other member of the house or staff."
            );


        public static readonly BackgroundDefinition Criminal =
            new BackgroundDefinition(
                Enums.Backgrounds.Criminal,

                "You have spent your life parasitically taking from others outside " +
                "of lawful means. You were probably imprisoned at some point, enslaved, " +
                "or forced to pay penance in one form or another. You distrust others " +
                "and never completely relax.",

                TalentDb.Paranoia,

                new List<Skill.SkillDefinition>
                {
                SkillDb.Deceive,
                SkillDb.Stealth
                },

                ""
            );


        public static readonly BackgroundDefinition Outlander =
            new BackgroundDefinition(
                Enums.Backgrounds.Outlander,

                "You were raised outside the comforting walls of civilization, living " +
                "amongst your fellow druids, barbarians, shepherds, or so on. You are " +
                "accustomed to the harsh dangers and realities of your mortality, and " +
                "take precaution to ensure your life and welfare.",

                TalentDb.LightSleeper,

                new List<Skill.SkillDefinition>
                {
                    SkillDb.Survival,
                    SkillDb.Nature,
                    SkillDb.History
                },

                ""
            );


        public static readonly BackgroundDefinition Plebian =
            new BackgroundDefinition(
                Enums.Backgrounds.Plebian,

                "You have spent your life living under the authority of others as a " +
                "merchant, artisan, laborer, scholar, or some other profession. You are " +
                "conditioned to a life without luxury or influence.",

                TalentDb.SkillFocus,

                new List<Skill.SkillDefinition>
                {
                    SkillDb.Local
                },

                ""
            );
    }
}
