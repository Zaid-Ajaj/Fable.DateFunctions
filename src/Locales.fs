namespace Fable.DateFunctions

open Fable.Core.JsInterop
open System 

type DateFnLocales() = 
    member this.Russian : ILocale = importDefault "date-fns/locale/ru"
    member this.French : ILocale = importDefault "date-fns/locale/fr"
    member this.Esperanto : ILocale = importDefault "date-fns/locale/eo"
    member this.ChineseSimplified : ILocale = importDefault "date-fns/locale/zh_cn"
    member this.German : ILocale = importDefault "date-fns/locale/de"
    member this.Spanish : ILocale = importDefault "date-fns/locale/es"
    member this.Japanese : ILocale = importDefault "date-fns/locale/ja"
    member this.Dutch : ILocale = importDefault "date-fns/locale/nl"
    member this.ChineseTraditional : ILocale = importDefault "date-fns/locale/zh_tw"
    member this.NorwegianBokmal : ILocale = importDefault "date-fns/locale/nb" 
    member this.Indonesian : ILocale = importDefault "date-fns/locale/nb"
    member this.Italian : ILocale = importDefault "date-fns/locale/it"
    member this.Polish : ILocale = importDefault "date-fns/locale/pl"
    member this.Portuguese : ILocale = importDefault "date-fns/locale/pt"
    member this.Swedish : ILocale = importDefault "date-fns/locale/sv"
    member this.Turkish : ILocale = importDefault "date-fns/locale/tr"
    member this.Korean : ILocale = importDefault "date-fns/locale/ko"
    member this.Greek : ILocale = importDefault "date-fns/locale/el"
    member this.Slovak : ILocale = importDefault "date-fns/locale/sk"
    member this.Filipino : ILocale = importDefault "date-fns/locale/fil"
    member this.Danish : ILocale = importDefault "date-fns/locale/da"
    member this.IceLandic : ILocale = importDefault "date-fns/locale/is"
    member this.Finnish : ILocale = importDefault "date-fns/locale/fi"
    member this.Thai : ILocale = importDefault "date-fns/locale/th"
    member this.Croatian : ILocale = importDefault "date-fns/locale/hr"
    member this.Arabic : ILocale = importDefault "date-fns/locale/ar"
    member this.Bulgarian : ILocale = importDefault "date-fns/locale/bg"
    member this.Czech : ILocale = importDefault "date-fns/locale/cs"
    member this.Macedonian : ILocale = importDefault "date-fns/locale/mk"
    member this.Romanian : ILocale = importDefault "date-fns/locale/ro"

[<AutoOpen>]
module LocalesHelper = 
    type DateTime with 
        static member Locales = DateFnLocales()
