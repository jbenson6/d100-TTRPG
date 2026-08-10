namespace d100_TTRPG.Data_Objects.Trade
{
    public static class TradeDb
    {
        // ============================================================
        // ACOLYTE
        // ============================================================

        public static readonly TradeDefinition Acolyte =
            new TradeDefinition(
                Enums.Trades.Acolyte,
                "You have spent much time working at a shrine, temple, with monks, or in a cult.",
                knowledge: new List<Enums.Knowledge>
                {
                    Enums.Knowledge.Religion
                }
            );


        // ============================================================
        // ARTISAN
        // ============================================================

        public static readonly TradeDefinition Artisan =
            new TradeDefinition(
                Enums.Trades.Artisan,
                "You are skilled with creating things with your hands, from smithing, carpentry, painting, sculpting, or another craft.",
                skills: new List<Enums.Skills>
                {
                    Enums.Skills.Craft
                },
                specializations: new List<string>
                {
                    "Any One"
                }
            );


        // ============================================================
        // BUREAUCRAT
        // ============================================================

        public static readonly TradeDefinition Bureaucrat =
            new TradeDefinition(
                Enums.Trades.Bureaucrat,
                "You have spent your life working within an organization, whether that be a noble hierarchy as an attendant, a merchant company, or in a government agency.",
                skills: new List<Enums.Skills>
                {
                    Enums.Skills.Linguistics
                },
                knowledge: new List<Enums.Knowledge>
                {
                    Enums.Knowledge.History
                },
                additionalNotes:
                    "You have a positive connection with a given noble family, company, or government agency."
            );


        // ============================================================
        // HUNTSMAN
        // ============================================================

        public static readonly TradeDefinition Huntsman =
            new TradeDefinition(
                Enums.Trades.Huntsman,
                "You are familiar with hunting and catching wildlife in order to feed yourself and others.",
                skills: new List<Enums.Skills>
                {
                    Enums.Skills.Survival
                },
                crafts: new List<Enums.Craft>
                { Enums.Craft.Traps},
                specializations: new List<string>
                {
                    "Craft [Traps]"
                }
            );


        // ============================================================
        // SAILOR
        // ============================================================

        public static readonly TradeDefinition Sailor =
            new TradeDefinition(
                Enums.Trades.Sailor,
                "You live on the open sea, fishing, trading, in the Navy or as a pirate. You are never seasick and enjoy the untamable nature of the mighty waters.",
                skills: new List<Enums.Skills>
                {
                    Enums.Skills.Navigate
                },
                specializations: new List<string>
                {
                    "Sea"
                }
            );


        // ============================================================
        // SCHOLAR
        // ============================================================

        public static readonly TradeDefinition Scholar =
            new TradeDefinition(
                Enums.Trades.Scholar,
                "You have dedicated yourself to acquiring a greater understanding of the world you live in.",
                knowledge: new List<Enums.Knowledge>
                {
                    // Any one Knowledge skill.
                },
                specializations: new List<string>
                {
                    "Knowledge [Any One] [P]"
                }
            );


        // ============================================================
        // SERVANT
        // ============================================================

        public static readonly TradeDefinition Servant =
            new TradeDefinition(
                Enums.Trades.Servant,
                "You have humbly cared for a noble family, a wealthy house, or worked in the service industry.",
                knowledge: new List<Enums.Knowledge>
                {
                    Enums.Knowledge.Local
                },
                additionalNotes:
                    "You have experience working at a particular location [GM Discretion], and are associated with the other members of the house or business."
            );


        // ============================================================
        // WARRIOR
        // ============================================================

        public static readonly TradeDefinition Warrior =
            new TradeDefinition(
                Enums.Trades.Warrior,
                "You have dedicated yourself to a martial lifestyle, maintaining a personal training regimen and are prepared for violence.",
                skills: new List<Enums.Skills>
                {
                    Enums.Skills.QuickDraw
                }
            );
    }
}