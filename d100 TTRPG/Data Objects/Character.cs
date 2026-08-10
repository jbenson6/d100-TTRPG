using d100_TTRPG.Enums;


namespace d100_TTRPG.Data_Objects
{
    public class Character
    {
        public string? Name { get; set; }
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
        public int MP { get; set; }
        public int LoF { get; set; }
        public int Damage { get; set; }
        public Armor.Armor? Armor { get; set; }
        public int Size { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
        public int XpSpent { get; set; }
        public List<Language.Language>? Languages { get; set; }
        public Dieties? Diety { get; set; }
        public Location.Location? Location { get; set; }
        public Race.Race? Race { get; set; }
        public Background.Background? Background { get; set; }
        public Trade.Trade? Trade { get; set; }
        public Motivation.Motivation? Motivation {  get; set; }
        public List<Weapon.Weapon>? Weapons { get ; set; }
        public List<Feature.Feature>? Features {  get; set; }
        public List<Trait.Trait>? Traits { get; set; }
        public List<Talent.Talent>? Talents { get; set; }
        public List<Skill.Skill>? Skills { get; set; }
        public List<Spell.Spell>? Spells { get; set; }

        public Character() { }
    }
}
