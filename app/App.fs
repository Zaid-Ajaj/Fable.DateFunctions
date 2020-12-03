module App

open Feliz
open System
open Fable.React
open Fable.React.Props
open Fable.DateFunctions
open Fable.Core.JsInterop

let highlight (codeBlock: string) =
    pre [ ] [ code [ ] [ str codeBlock ] ]

let now = DateTime.Now
let tomorrow = now.AddDays(1)
let yesterday = now.SubtractDays(1)

let formatOptions = createEmpty<IFormatDistanceOptions>

formatOptions.includeSeconds <- false
formatOptions.addSuffix <- true
formatOptions.locale <- DateTime.Locales.Dutch

let sometimeAgo = now.SubtractMonths(1).SubtractDays(4)
let formatted = sometimeAgo.FormatDistanceToNow(formatOptions)

let introduction =
    Html.div [
        Html.h1 [
            prop.style [ Feliz.style.fontSize 30 ]
            prop.children [
                Html.a [
                    prop.href "https://github.com/Zaid-Ajaj/Fable.DateFunctions"
                    prop.text "Fable.DateFunctions"
                ]
            ]
        ]

        p []
            [ span []
                  [ str "Fable binding for "
                    a [ Href "https://date-fns.org/" ] [ str "date-fns" ]
                    str
                        " with 120+ functions for working with dates, implemented as extension methods for DateTime and DateTimeOffset" ] ]
        hr []
        h1 [ Style [ FontSize 30 ] ] [ str "Examples and configurations" ]
        highlight """let now = DateTime.Now
let yesterday = now.SubtractDays(1)
let tomorrow = now.AddDays(1)"""
        highlight (sprintf "now.IsToday() // => %A" (now.IsToday()))
        highlight (sprintf "now.FormatDistance(tomorrow) // => %A" (now.FormatDistance(tomorrow)))
        highlight (sprintf "now.IsTomorrow() // => %A" (now.IsTomorrow()))
        highlight (sprintf "now.IsInTheSameDayAs(tomorrow) // => %A" (now.IsInTheSameDayAs(tomorrow)))
        highlight (sprintf "tomorrow.IsInTheSameDayAs(tomorrow) // => %A" (tomorrow.IsInTheSameDayAs(tomorrow)))
        highlight (sprintf "tomorrow.IsInTheFuture() // => %A" (tomorrow.IsInTheFuture()))
        highlight (sprintf "yesterday.IsInTheFuture() // => %A" (yesterday.IsInTheFuture()))
        highlight (sprintf "yesterday.IsInThePast() // => %A" (yesterday.IsInThePast()))
        highlight (sprintf "yesterday.EndOfDay() // => %A" (yesterday.EndOfDay()))
        highlight (sprintf "now.StartOfDay() // => %A" (now.StartOfDay()))
        highlight (sprintf "now.StartOfWeek() // => %A" (now.StartOfWeek()))
        highlight (sprintf "now.StartOfWeek(weekStartsOn=Day.Monday) // => %A" (now.StartOfWeek(weekStartsOn=Day.Monday)))
        highlight (sprintf "now.StartOfWeek(locale=DateTime.Locales.Dutch) // => %A" (now.StartOfWeek(locale=DateTime.Locales.Dutch)))
        highlight (sprintf "now.IsInSameMinuteAs(now.AddSeconds(5.0)) // => %A" (now.IsInSameMinuteAs(now.AddSeconds(5.0))))
        highlight (sprintf "now.IsBetween(yesterday, tomorrow) ==> %A" (now.IsBetween(yesterday, tomorrow)))
        highlight (sprintf "now.SubtractDays(1).IsInThePast()  ==> %A" (now.SubtractDays(1).IsInThePast()))
        highlight (sprintf "now.AddQuarters(2)  ==> %A" (now.AddQuarters(2)))
        highlight (sprintf "now.SubtractQuarters(1)  ==> %A" (now.SubtractQuarters(1)))
        highlight (sprintf "now.StartOfQuarter()  ==> %A" (now.StartOfQuarter()))
        h1 [ Style [ FontSize 30 ] ] [ str "Locales Support (32 languages)" ]
        p []
            [ span []
                  [ str "See "
                    a [ Href "https://date-fns.org/v2.16.1/docs/format" ]
                        [ str "https://date-fns.org/v2.16.1/docs/format" ]
                    str " for the full documentation on formatting strings" ] ]
        highlight (sprintf "now.Format(\"dd MMMM yyyy\") ==> %A" (now.Format("dd MMMM yyyy")))

        highlight (sprintf "now.Format(\"dd MMMM yyyy\", DateTime.Locales.Czech) ==> %A" (now.Format("dd MMMM yyyy", DateTime.Locales.Czech)))

        highlight (sprintf "now.Format(\"dd MMMM yyyy\", DateTime.Locales.Spanish) ==> %A" (now.Format("dd MMMM yyyy", DateTime.Locales.Spanish)))

        highlight (sprintf "now.Format(\"dd MMMM yyyy\", DateTime.Locales.French) ==> %A" (now.Format("dd MMMM yyyy", DateTime.Locales.French)))

        highlight (sprintf "now.Format(\"dd MMMM yyyy\", DateTime.Locales.Japanese) ==> %A" (now.Format("dd MMMM yyyy", DateTime.Locales.Japanese)))

        highlight (sprintf "now.Format(\"dd MMMM yyyy\", DateTime.Locales.Russian) ==> %A" (now.Format("dd MMMM yyyy", DateTime.Locales.Russian)))

        p [] [ str "Distance in words" ]

        highlight
            (sprintf """let formatOptions = createEmpty<IFormatDistanceOptions>
formatOptions.includeSeconds <- false
formatOptions.addSuffix <- true
formatOptions.locale <- DateTime.Locales.Dutch
DateTime.Now.SubtractMonths(1).FormatDistanceToNow(formatOptions) => // "%s" """

                   formatted) ]

[<ReactComponent>]
let Render() = introduction
