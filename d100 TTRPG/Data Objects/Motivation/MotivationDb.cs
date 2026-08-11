using d100_TTRPG.Data_Objects.Skill;
using d100_TTRPG.Data_Objects.Talent;

namespace d100_TTRPG.Data_Objects.Motivation
{
    public static class MotivationDb
    {
        // ============================================================
        // DEVOTION
        // ============================================================

        public static readonly MotivationDefinition Devotion =
            new MotivationDefinition(
                Enums.Motivations.Devotion,
                "Your existence is to serve your lord, your country, or your god.",
                skills: new List<Enums.Skills>
                {
                    Enums.Skills.History,
                    Enums.Skills.Religion
                }
            );


        // ============================================================
        // DISCOVERY
        // ============================================================

        public static readonly MotivationDefinition Discovery =
            new MotivationDefinition(
                Enums.Motivations.Discovery,
                "Finding new things is your primary purpose in life. You seek out new locations, information, or techniques.",
                talent: Enums.Talents.Polyglot,
                skills: new List<Enums.Skills>
                {
                    Enums.Skills.Awareness,
                    Enums.Skills.Linguistics,
                }
            );


        // ============================================================
        // GLORY
        // ============================================================

        public static readonly MotivationDefinition Glory =
            new MotivationDefinition(
                Enums.Motivations.Glory,
                "You aim to make your mark in history. The more who know your name and your deeds the greater you are. Fame and infamy are but one to the likes of you.",
                skills: new List<Enums.Skills>
                {
                    Enums.Skills.Deceive,
                    Enums.Skills.Persuade,
                }
            );


        // ============================================================
        // JUSTICE
        // ============================================================

        public static readonly MotivationDefinition Justice =
            new MotivationDefinition(
                Enums.Motivations.Justice,
                "Every wrong must be righted, regardless of your ability. You impulsively seek to uphold the delicate balance of your ideal.",
                talent: Enums.Talents.Vigilance,
                skills: new List<Enums.Skills>
                {
                    Enums.Skills.Insight,
                }
            );


        // ============================================================
        // PEACE
        // ============================================================

        public static readonly MotivationDefinition Peace =
            new MotivationDefinition(
                Enums.Motivations.Peace,
                "You believe harmony is the ultimate goal and savor moments of tranquility. You prefer to end conflicts in a manner that prevents future ones as well.",
                talent: Enums.Talents.Meditation,
                skills: new List<Enums.Skills>
                {
                    Enums.Skills.HandleAnimal,
                }
            );


        // ============================================================
        // PLEASURE
        // ============================================================

        public static readonly MotivationDefinition Pleasure =
            new MotivationDefinition(
                Enums.Motivations.Pleasure,
                "You live to reward yourself, be it by accomplishment, good company, or hedonistic vice.",
                skills: new List<Enums.Skills>
                {
                    Enums.Skills.Escape
                }
            );


        // ============================================================
        // POWER
        // ============================================================

        public static readonly MotivationDefinition Power =
            new MotivationDefinition(
                Enums.Motivations.Power,
                "There is no greater joy than inflicting your will upon as many people as possible. Climbing the ranks of organizations, building greater physical might, and always being on top can be seen as your personal habits.",
                talent: Enums.Talents.Leadership
            );


        // ============================================================
        // VENGEANCE
        // ============================================================

        public static readonly MotivationDefinition Vengeance =
            new MotivationDefinition(
                Enums.Motivations.Vengeance,
                "You wish to punish the wrongdoings against you, your loved ones, your country or your people. This has become your life's purpose, and your actions revolve around accomplishing this.",
                talent: Enums.Talents.Haste,
                skills: new List<Enums.Skills>
                {
                    Enums.Skills.History
                },
                additionalNotes:
                   "You are an enemy to a person, group, or organization, and begin with a Hostile Disposition with them."
            );


        // ============================================================
        // VIOLENCE
        // ============================================================

        public static readonly MotivationDefinition Violence =
            new MotivationDefinition(
                Enums.Motivations.Violence,
                "Whether participating in the clash of great armies or one on one encounters between you and another combatant, you can never exert yourself enough to satisfy your desire to crush, slash, bludgeon, choke, and explode others. Combat and destruction are virtue and art to you, whether you can justify it to others or not.",
                talent: Enums.Talents.AllOutAttack
            );


        // ============================================================
        // WEALTH
        // ============================================================

        public static readonly MotivationDefinition Wealth =
            new MotivationDefinition(
                Enums.Motivations.Wealth,
                "All the treasures in the world is not enough to satisfy your desire to accrue more possessions. Some call you greedy, perhaps others ambitious, but in the end you want the world and beyond to belong to you.",
                skills: new List<Enums.Skills>
                {
                    Enums.Skills.Local
                },
                additionalNotes:
                    "You begin with an exceptional amount of wealth in the form of money, property, or unique items [GM Discretion]. " +
                    "You should have money to live in moderate luxury in your starting area."
            );
    }
}