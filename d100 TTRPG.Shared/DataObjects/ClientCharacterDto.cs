namespace d100_TTRPG.Shared.Data_Objects
{
    public class ClientCharacterDto
    {
        public string? Name { get; set; }

        public string? PowerLevel { get; set; }

        public string? Location { get; set; }

        public string? Race { get; set; }

        public string? Background { get; set; }

        public string? Trade { get; set; }

        public string? Motivation { get; set; }

        // -------------------------------------------------
        // Character selections
        // -------------------------------------------------

        public List<string> Features { get; set; } = new();
        public List<string> PurchasedFeatures { get; set; } = new();

        public string? AristocratSkill1 { get; set; }

        public string? AristocratSkill2 { get; set; }

        public string? ScholarSkill { get; set; }

        public string? ArtisanSkill { get; set; }

        public string? PleasureSkill { get; set; }

        // -------------------------------------------------
        // Derived character data
        // -------------------------------------------------

        public List<string> Talents { get; set; } = new();

        public List<string> Traits { get; set; } = new();

        public List<string> Skills { get; set; } = new();

        public List<string> BackgroundSkills { get; set; } = new();
        public List<string>? BackgroundSkillChoices { get; set; } = new();


        public List<string> TradeSkills { get; set; } = new();
        public List<string>? TradeSkillChoices { get; set; } = new();


        public List<string> MotivationSkills { get; set; } = new();
        public List<string>? MotivationSkillChoices { get; set; } = new();

        public Dictionary<string, int> CharacteristicImprovementSteps { get; set; } = new();

        public List<string> PurchasedTalents { get; set; } = new();


        // -------------------------------------------------
        // Spells
        // -------------------------------------------------

        public List<string> LearnedSpells { get; set; } = new();

        public List<string> PurchasedSpells { get; set; } = new();

        public int MP { get; set; }

        // -------------------------------------------------
        // XP
        // -------------------------------------------------

        public int XpPool { get; set; }

        public int XpSpent { get; set; }

        public int XpRemaining { get; set; }

        // -------------------------------------------------
        // Equipment
        // -------------------------------------------------

        public string? Armor { get; set; }

        public string? MainWeapon { get; set; }

        public string? OffWeapon { get; set; }

        // -------------------------------------------------
        // Characteristics
        // -------------------------------------------------

        public Dictionary<string, int> CurrentStats { get; set; } = new();

        public int AvailablePoints { get; set; }

        public int Damage { get; set; }

        public int LoF { get; set; }
    }
}
