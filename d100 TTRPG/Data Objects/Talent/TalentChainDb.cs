using System.Collections.Generic;
using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Talent
{
    public static class TalentChainDb
    {
        public static readonly TalentChainDefinition Minion =
            new TalentChainDefinition(
                TalentChains.Minion,
                "Minion",
                3,
                false,
                "You gain a companion, with 100 points to spend between their characteristics, and 500xp to spend on improvements. Each time you level up, they gain 500 xp to spend on improvements.",
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(
                        Characteristics.CHA,
                        30)
                }
            );

        public static readonly TalentChainDefinition PracticeDrills =
            new TalentChainDefinition(
                TalentChains.PracticeDrills,
                "Practice Drills",
                1,
                false,
                "Increase a chosen physical characteristic of each of your followers by 5. This talent may be taken up to twice per physical characteristic (Strength, Agility, Constitution). This increase applies proactively to any new followers you gain, but does not apply to unliving followers, such as ones gained from Reanimate or Golem Crafting.",
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Skill(
                        Skills.Command,
                        SkillRank.Trained)
                },
                true,
                6
            );

        public static readonly TalentChainDefinition DoubleTeam =
            new TalentChainDefinition(
                TalentChains.DoubleTeam,
                "Double Team",
                1,
                true,
                "You have experience fighting in paired teams that work together to take down their enemies. When Ganging Up on an opponent, the character gains an additional +10 bonus to MSK Tests. This bonus is in addition to the normal bonus gained from Ganging Up on an opponent.",
                new List<TalentPrerequisite>()
            );

        public static readonly TalentChainDefinition DoubleSlice =
            new TalentChainDefinition(
                TalentChains.DoubleSlice,
                "Double Slice",
                2,
                true,
                "You attack with two weapons.",
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(
                        Characteristics.MSK,
                        45)
                }
            );

        public static readonly TalentChainDefinition FollowUp =
            new TalentChainDefinition(
                TalentChains.FollowUp,
                "Follow Up",
                3,
                true,
                "",
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(
                        Characteristics.MSK,
                        50)
                }
            );

        public static readonly TalentChainDefinition Defense =
            new TalentChainDefinition(
                TalentChains.Defense,
                "Defense",
                1,
                true,
                "When you are wielding two (or more) one handed weapons you gain +10 on Parry tests.",
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(
                        Characteristics.MSK,
                        40)
                }
            );

        public static readonly TalentChainDefinition Bloodlust =
            new TalentChainDefinition(
                TalentChains.Bloodlust,
                "Bloodlust",
                1,
                false,
                "",
                new List<TalentPrerequisite>()
            );

        public static readonly TalentChainDefinition Power =
            new TalentChainDefinition(
                TalentChains.Power,
                "Power",
                2,
                true,
                "Add 1/2 MP (minimum +1) to damage you deal with melee and ranged weapons.",
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.MP(1)
                }
            );
    }
}