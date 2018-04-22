namespace Fable.DateFunctions

open Fable.Core.JsInterop
open System

type DateFnLocales() =
    member inline this.Russian : ILocale = importDefault "date-fns/locale/ru"
    member inline this.French : ILocale = importDefault "date-fns/locale/fr"
    member inline this.Esperanto : ILocale = importDefault "date-fns/locale/eo"
    member inline this.ChineseSimplified : ILocale = importDefault "date-fns/locale/zh_cn"
    member inline this.German : ILocale = importDefault "date-fns/locale/de"
    member inline this.Spanish : ILocale = importDefault "date-fns/locale/es"
    member inline this.Japanese : ILocale = importDefault "date-fns/locale/ja"
    member inline this.Dutch : ILocale = importDefault "date-fns/locale/nl"
    member inline this.ChineseTraditional : ILocale = importDefault "date-fns/locale/zh_tw"
    member inline this.NorwegianBokmal : ILocale = importDefault "date-fns/locale/nb"
    member inline this.Indonesian : ILocale = importDefault "date-fns/locale/nb"
    member inline this.Italian : ILocale = importDefault "date-fns/locale/it"
    member inline this.Polish : ILocale = importDefault "date-fns/locale/pl"
    member inline this.Portuguese : ILocale = importDefault "date-fns/locale/pt"
    member inline this.Swedish : ILocale = importDefault "date-fns/locale/sv"
    member inline this.Turkish : ILocale = importDefault "date-fns/locale/tr"
    member inline this.Korean : ILocale = importDefault "date-fns/locale/ko"
    member inline this.Greek : ILocale = importDefault "date-fns/locale/el"
    member inline this.Slovak : ILocale = importDefault "date-fns/locale/sk"
    member inline this.Filipino : ILocale = importDefault "date-fns/locale/fil"
    member inline this.Danish : ILocale = importDefault "date-fns/locale/da"
    member inline this.IceLandic : ILocale = importDefault "date-fns/locale/is"
    member inline this.Finnish : ILocale = importDefault "date-fns/locale/fi"
    member inline this.Thai : ILocale = importDefault "date-fns/locale/th"
    member inline this.Croatian : ILocale = importDefault "date-fns/locale/hr"
    member inline this.Arabic : ILocale = importDefault "date-fns/locale/ar"
    member inline this.Bulgarian : ILocale = importDefault "date-fns/locale/bg"
    member inline this.Czech : ILocale = importDefault "date-fns/locale/cs"
    member inline this.Macedonian : ILocale = importDefault "date-fns/locale/mk"
    member inline this.Romanian : ILocale = importDefault "date-fns/locale/ro"

[<AutoOpen>]
module LocalesHelper =
    type DateTime with
        static member inline Locales = DateFnLocales()
