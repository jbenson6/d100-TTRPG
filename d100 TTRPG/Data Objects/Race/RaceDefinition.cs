namespace d100_TTRPG.Data_Objects.Race
{
    public class RaceDefinition
    {
        public Enums.Races Race { get; set; }
        public int MSK { get; set; }
        public int RSK { get; set; }
        public int STR { get; set; }
        public int AGI { get; set; }
        public int CON { get; set; }
        public int INT { get; set; }
        public int PER { get; set; }
        public int WPR { get; set; }
        public int CHA { get; set; }
        public int Wounds { get; set; }
        public List<Skill.Skill>? Skills { get; set; }
        public List<Talent.Talent>? Talents { get; set; }
        public List<Language.Language>? Languages { get; set; }
        public List<Trait.Trait>? Traits { get; set; }
        public List<Spell.Spell>? Spells { get; set; }

        public List<Feature.Feature>? Features { get; set; }

        public RaceDefinition(Enums.Races race, int wounds, int msk, int rsk, int str, int agi, int con, int intel, int per, int wpr, int cha, List<Skill.Skill>? skills, List<Talent.Talent>? talents, List<Language.Language>? languages, List<Trait.Trait>? traits, List<Spell.Spell>? spells, List<Feature.Feature>? features)
        {
            Race = race;
            MSK = msk;
            RSK = rsk;
            STR = str;
            AGI = agi;
            CON = con;
            INT = intel; 
            PER = per;
            WPR = wpr;
            CHA = cha;
            Wounds = wounds;
            Skills = skills;
            Talents = talents;
            Languages = languages;
            Traits = traits;
            Spells = spells;
            Features = features;
        }
    }
}
