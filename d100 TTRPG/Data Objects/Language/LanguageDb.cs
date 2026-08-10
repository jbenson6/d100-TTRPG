using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Language
{
    public static class LanguageDb
    {
        public static readonly LanguageDefinition Abyssal = new LanguageDefinition(
        Languages.Abyssal,
        "The speech, hums, squirms, and wails of the things that dwell beneath the mountains and at the deepest parts of the seas.");

        public static readonly LanguageDefinition Celestial = new LanguageDefinition(
            Languages.Celestial,
            "Languages of the divine, their servants, and the aasimar. Alternate name: Divine Hymns.");

        public static readonly LanguageDefinition Djinni = new LanguageDefinition(
            Languages.Djinni,
            "The languages of the djinn, gargoyles, genies, ifrits, sylphs, and sphinx.");

        public static readonly LanguageDefinition Draconic = new LanguageDefinition(
            Languages.Draconic,
            "The tongue of ancient serpents, wyrms, and drakes. Alternate name: Arcane Texts.");

        public static readonly LanguageDefinition Elven = new LanguageDefinition(
            Languages.Elven,
            "The language of elves, often spoken by Thessian nobility as a status symbol.");

        public static readonly LanguageDefinition Enkidian = new LanguageDefinition(
            Languages.Enkidian,
            "The language of the merfolk and other aquatic beings.");

        public static readonly LanguageDefinition Infernal = new LanguageDefinition(
            Languages.Infernal,
            "The languages of demons, dhampir, oni, succubi, and varrucks.");

        public static readonly LanguageDefinition Ishi = new LanguageDefinition(
            Languages.Ishi,
            "The language of the Orientals. Alternate name: Western Trade Tongue.");

        public static readonly LanguageDefinition Kamanali = new LanguageDefinition(
            Languages.Kamanali,
            "The language of the Zymen.");

        public static readonly LanguageDefinition Lycan = new LanguageDefinition(
            Languages.Lycan,
            "The speech of anurans, beastmen, catfolk, gnolls, kitsune, Supernals, and taurus.");

        public static readonly LanguageDefinition Orcish = new LanguageDefinition(
            Languages.Orcish,
            "The crude tongue of the orcs.");

        public static readonly LanguageDefinition Saurian = new LanguageDefinition(
            Languages.Saurian,
            "The language of the kobolds, monitori, and lamia.");

        public static readonly LanguageDefinition Scytho = new LanguageDefinition(
            Languages.Scytho,
            "The language of the Mithranites. Alternate name: Southern Trade Tongue.");

        public static readonly LanguageDefinition Sylvan = new LanguageDefinition(
            Languages.Sylvan,
            "The language of ancient sylvan creatures, fey, giants, hornets, and nectarines. Alternate name: Old Elven.");

        public static readonly LanguageDefinition Thessian = new LanguageDefinition(
            Languages.Thessian,
            "The language spoken by humans in the Kingdoms of Man. Alternate name: Northern Trade Tongue.");

        public static readonly LanguageDefinition Taheeli = new LanguageDefinition(
            Languages.Taheeli,
            "The language of Nubians.");
    }
}
