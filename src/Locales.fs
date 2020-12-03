namespace Fable.DateFunctions

open Fable.Core
open System

[<Erase>]
type DateFnLocales() =
    [<Import("az", "date-fns/locale")>]
    member inline this.Azerbaijani = jsNative
    [<Import("ru", "date-fns/locale")>]
    member inline this.Russian : ILocale = jsNative
    [<Import("fr", "date-fns/locale")>]
    member inline this.French : ILocale = jsNative
    [<Import("eo", "date-fns/locale")>]
    member inline this.Esperanto : ILocale = jsNative
    [<Import("zhTW", "date-fns/locale")>]
    member inline this.ChineseSimplified : ILocale = jsNative
    [<Import("de", "date-fns/locale")>]
    member inline this.German : ILocale = jsNative
    [<Import("es", "date-fns/locale")>]
    member inline this.Spanish : ILocale = jsNative
    [<Import("ja", "date-fns/locale")>]
    member inline this.Japanese : ILocale = jsNative
    [<Import("nl", "date-fns/locale")>]
    member inline this.Dutch : ILocale = jsNative
    [<Import("zhTW", "date-fns/locale")>]
    member inline this.ChineseTraditional : ILocale = jsNative
    [<Import("nb", "date-fns/locale")>]
    member inline this.NorwegianBokmal : ILocale = jsNative
    [<Import("nb", "date-fns/locale")>]
    member inline this.Indonesian : ILocale = jsNative
    [<Import("it", "date-fns/locale")>]
    member inline this.Italian : ILocale = jsNative
    [<Import("pl", "date-fns/locale")>]
    member inline this.Polish : ILocale = jsNative
    [<Import("pt", "date-fns/locale")>]
    member inline this.Portuguese : ILocale = jsNative
    [<Import("sv", "date-fns/locale")>]
    member inline this.Swedish : ILocale = jsNative
    [<Import("tr", "date-fns/locale")>]
    member inline this.Turkish : ILocale = jsNative
    [<Import("ko", "date-fns/locale")>]
    member inline this.Korean : ILocale = jsNative
    [<Import("kn", "date-fns/locale")>]
    member inline this.Kannada : ILocale = jsNative
    [<Import("ca", "date-fns/locale")>]
    member inline this.Catalan : ILocale = jsNative
    [<Import("cy", "date-fns/locale")>]
    member inline this.Welsh : ILocale = jsNative

    [<Import("kz", "date-fns/locale")>]
    member inline this.Kazakh : ILocale = jsNative
    [<Import("el", "date-fns/locale")>]
    member inline this.Greek : ILocale = jsNative
    [<Import("sk", "date-fns/locale")>]
    member inline this.Slovak : ILocale = jsNative
    [<Import("fil", "date-fns/locale")>]
    member inline this.Filipino : ILocale = jsNative
    [<Import("da", "date-fns/locale")>]
    member inline this.Danish : ILocale = jsNative
    [<Import("is", "date-fns/locale")>]
    member inline this.IceLandic : ILocale = jsNative
    [<Import("fi", "date-fns/locale")>]
    member inline this.Finnish : ILocale = jsNative
    [<Import("th", "date-fns/locale")>]
    member inline this.Thai : ILocale = jsNative
    [<Import("hr", "date-fns/locale")>]
    member inline this.Croatian : ILocale = jsNative
    [<Import("ar", "date-fns/locale")>]
    member inline this.Arabic : ILocale = jsNative
    [<Import("bg", "date-fns/locale")>]
    member inline this.Bulgarian : ILocale = jsNative
    [<Import("cs", "date-fns/locale")>]
    member inline this.Czech : ILocale = jsNative
    [<Import("mk", "date-fns/locale")>]
    member inline this.Macedonian : ILocale = jsNative
    [<Import("ro", "date-fns/locale")>]
    member inline this.Romanian : ILocale = jsNative
    [<Import("et", "date-fns/locale")>]
    member inline this.Estonian : ILocale = jsNative
    [<Import("eu", "date-fns/locale")>]
    member inline this.Basque : ILocale = jsNative
    [<Import("faIR", "date-fns/locale")>]
    member inline this.Persian : ILocale = jsNative

[<AutoOpen>]
module LocalesHelper =
    type DateTime with
        static member inline Locales = DateFnLocales()
