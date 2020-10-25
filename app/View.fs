module App.View

open App.Types

open System
open Fable.React
open Fable.React.Props
open Fable.DateFunctions
open Fable.Core.JsInterop

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
    div []
        [ h1 [ Style [ FontSize 30 ] ]
              [ a [ Href "https://github.com/Zaid-Ajaj/Fable.DateFunctions" ] [ str "Fable.DateFunctions" ] ]
          p []
              [ span []
                    [ str "Fable binding for "
                      a [ Href "https://date-fns.org/" ] [ str "date-fns" ]
                      str
                          " with 120+ functions for working with dates, implemented as extension methods for DateTime and DateTimeOffset" ] ]
          hr []
          h1 [ Style [ FontSize 30 ] ] [ str "Examples and configurations" ]
          Common.highlight """let now = DateTime.Now
let yesterday = now.SubtractDays(1)
let tomorrow = now.AddDays(1)"""
          Common.highlight (sprintf "now.IsToday() // => %A" (now.IsToday()))
          Common.highlight (sprintf "now.FormatDistance(tomorrow) // => %A" (now.FormatDistance(tomorrow)))
          Common.highlight (sprintf "now.IsTomorrow() // => %A" (now.IsTomorrow()))
          Common.highlight (sprintf "now.IsInTheSameDayAs(tomorrow) // => %A" (now.IsInTheSameDayAs(tomorrow)))
          Common.highlight
              (sprintf "tomorrow.IsInTheSameDayAs(tomorrow) // => %A" (tomorrow.IsInTheSameDayAs(tomorrow)))
          Common.highlight (sprintf "tomorrow.IsInTheFuture() // => %A" (tomorrow.IsInTheFuture()))
          Common.highlight (sprintf "yesterday.IsInTheFuture() // => %A" (yesterday.IsInTheFuture()))
          Common.highlight (sprintf "yesterday.IsInThePast() // => %A" (yesterday.IsInThePast()))
          Common.highlight (sprintf "yesterday.EndOfDay() // => %A" (yesterday.EndOfDay()))
          Common.highlight (sprintf "now.StartOfDay() // => %A" (now.StartOfDay()))
          Common.highlight
              (sprintf "now.IsInSameMinuteAs(now.AddSeconds(5.0)) // => %A" (now.IsInSameMinuteAs(now.AddSeconds(5.0))))
          Common.highlight (sprintf "now.IsBetween(yesterday, tomorrow) ==> %A" (now.IsBetween(yesterday, tomorrow)))
          Common.highlight (sprintf "now.SubtractDays(1).IsInThePast()  ==> %A" (now.SubtractDays(1).IsInThePast()))
          Common.highlight (sprintf "now.AddQuarters(2)  ==> %A" (now.AddQuarters(2)))
          Common.highlight (sprintf "now.SubtractQuarters(1)  ==> %A" (now.SubtractQuarters(1)))
          Common.highlight (sprintf "now.StartOfQuarter()  ==> %A" (now.StartOfQuarter()))
          h1 [ Style [ FontSize 30 ] ] [ str "Locales Support (32 languages)" ]
          p []
              [ span []
                    [ str "See "
                      a [ Href "https://date-fns.org/v2.16.1/docs/format" ]
                          [ str "https://date-fns.org/v2.16.1/docs/format" ]
                      str " for the full documentation on formatting strings" ] ]
          Common.highlight (sprintf "now.Format(\"dd MMMM yyyy\") ==> %A" (now.Format("dd MMMM yyyy")))

          Common.highlight (sprintf "now.Format(\"dd MMMM yyyy\", DateTime.Locales.Czech) ==> %A" (now.Format("dd MMMM yyyy", DateTime.Locales.Czech)))

          Common.highlight (sprintf "now.Format(\"dd MMMM yyyy\", DateTime.Locales.Spanish) ==> %A" (now.Format("dd MMMM yyyy", DateTime.Locales.Spanish)))

          Common.highlight (sprintf "now.Format(\"dd MMMM yyyy\", DateTime.Locales.French) ==> %A" (now.Format("dd MMMM yyyy", DateTime.Locales.French)))

          Common.highlight (sprintf "now.Format(\"dd MMMM yyyy\", DateTime.Locales.Japanese) ==> %A" (now.Format("dd MMMM yyyy", DateTime.Locales.Japanese)))

          Common.highlight (sprintf "now.Format(\"dd MMMM yyyy\", DateTime.Locales.Russian) ==> %A" (now.Format("dd MMMM yyyy", DateTime.Locales.Russian)))

          p [] [ str "Distance in words" ]

          Common.highlight
              (sprintf """let formatOptions = createEmpty<IFormatDistanceOptions>
formatOptions.includeSeconds <- false
formatOptions.addSuffix <- true
formatOptions.locale <- DateTime.Locales.Dutch
DateTime.Now.SubtractMonths(1).FormatDistanceToNow(formatOptions) => // "%s" """

                   formatted) ]

let render (state: State) dispatch = introduction
