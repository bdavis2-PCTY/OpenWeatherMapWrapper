using OpenWeatherMapWrapper.Attributes;

namespace OpenWeatherMapWrapper.Enums
{
    /// <summary>
    /// Languages supported by OpenWeatherMap
    /// https://openweathermap.org/current#multi
    /// </summary>
    public enum LanguageEnum
    {
        [QueryValue("af")]
        Afrikaans,

        [QueryValue("al")]
        Albanian,

        [QueryValue("ar")]
        Arabic,

        [QueryValue("az")]
        Azerbaijani,

        [QueryValue("bg")]
        Bulgarian,

        [QueryValue("ca")]
        Catalan,

        [QueryValue("cz")]
        Czech,

        [QueryValue("da")]
        Danish,

        [QueryValue("de")]
        German,

        [QueryValue("el")]
        Greek,

        [QueryValue("en")]
        English,

        [QueryValue("eu")]
        Basque,

        [QueryValue("fa")]
        Persian,

        [QueryValue("fi")]
        Finnish,

        [QueryValue("fr")]
        French,

        [QueryValue("gl")]
        Galician,

        [QueryValue("he")]
        Hebrew,

        [QueryValue("hi")]
        Hindi,

        [QueryValue("hr")]
        Croatian,

        [QueryValue("hu")]
        Hungarian,

        [QueryValue("id")]
        Indonesian,

        [QueryValue("it")]
        Italian,

        [QueryValue("fa")]
        Japanese,

        [QueryValue("kr")]
        Korean,

        [QueryValue("la")]
        Latvian,

        [QueryValue("lt")]
        Lithuanian,

        [QueryValue("mk")]
        Macedonian,

        [QueryValue("no")]
        Norwegian,

        [QueryValue("nl")]
        Dutch,

        [QueryValue("pl")]
        Polish,

        [QueryValue("pt")]
        Portuguese,

        [QueryValue("pt_br")]
        PortuguesBrasil,

        [QueryValue("ro")]
        Romanian,

        [QueryValue("ru")]
        Russian,

        [QueryValue("sv")]
        Swedish,

        [QueryValue("sk")]
        Slovak,

        [QueryValue("sl")]
        Slovenian,

        [QueryValue("es")]
        Spanish,

        [QueryValue("sr")]
        Serbian,

        [QueryValue("th")]
        Thai,

        [QueryValue("tr")]
        Turkish,

        [QueryValue("uk")]
        Ukrainian,

        [QueryValue("vi")]
        Vietnamese,

        [QueryValue("zh_cn")]
        ChineseSimplified,

        [QueryValue("zh_tw")]
        ChineseTraditional,

        [QueryValue("zu")]
        Zulu
    }
}