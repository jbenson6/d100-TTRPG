using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Feature
{
    public class FeatureDefinition
    {
        public Features Feature { get; set; }
        public Dictionary<Characteristics, int>? PreReqChar { get; set; }
        public List<Characteristics>? CharBonus { get; set; }
        public int MP { get; set; }
        public int Wounds { get; set; }
        public List<Skill.Skill>? Skills { get; set; }
        public List<Talent.Talent>? Talents { get; set; }

        public List<Trait.Trait>? Traits { get; set; }
        public Enums.Armor ArmorProficiency { get; set; }
        public string? Description { get; set; }
        public bool isSpell {  get; set; }
        public bool deityReq { get; set; }

        public FeatureDefinition(
    Features feature,
    Dictionary<Characteristics, int>? preReqChar,
    List<Characteristics>? charBonus,
    int mP,
    int wounds,
    List<Skill.Skill>? skills,
    List<Talent.Talent>? talents,
    Enums.Armor armorProficiency,
    string? description,
    bool isSpell,
    bool deityReq,
    List<Trait.Trait>? traits = null)
        {
            Feature = feature;
            PreReqChar = preReqChar;
            CharBonus = charBonus;
            MP = mP;
            Wounds = wounds;
            Skills = skills;
            Talents = talents;
            Traits = traits;
            ArmorProficiency = armorProficiency;
            Description = description;
            this.isSpell = isSpell;
            this.deityReq = deityReq;
        }
    }
}
