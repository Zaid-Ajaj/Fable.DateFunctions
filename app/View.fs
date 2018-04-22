module App.View

open App.Types

open System
open Fulma
open Fulma.Elements
open Fulma.Components
open Fulma.Layouts
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.DateFunctions
open Fable.Core
open Fable.Core.JsInterop
let now = DateTime.Now 
let tomorrow = now.AddDays(1)
let yesterday = now.SubtractDays(1)

let formatOptions = createEmpty<IDistanceInWordsOptions>
formatOptions.includeSeconds <- false 
formatOptions.addSuffix <- true 
formatOptions.locale <- DateTime.Locales.Dutch

let sometimeAgo = now.SubtractMonths(1).SubtractDays(4)
let formatted = sometimeAgo.DistanceInWordsToNow(formatOptions)

let introduction = 
    div [ ]  
        [ h1 [ Style [ FontSize 30 ] ] [ a [ Href "https://github.com/Zaid-Ajaj/Fable.DateFunctions" ] [ str "Fable.DateFunctions"  ]  ]
          p  [ ] [ span [ ] [ str "Fable binding for ";  a [ Href "https://date-fns.org/" ] [ str "date-fns" ]; str " with 120+ functions for working with dates, implemented as extension methods for DateTime (some methods are static members for DateTime)" ] ]
          hr [ ]
          h1 [ Style [ FontSize 30 ] ] [ str "Examples and configurations" ]
          Common.highlight """let now = DateTime.Now
let yesterday = now.SubtractDays(1)
let tomorrow = now.AddDays(1)"""
          Common.highlight (sprintf "now.IsToday() // => %A" (now.IsToday())) 
          Common.highlight (sprintf "now.DistanceInWords(tomorrow) // => %A" (now.DistanceInWords(tomorrow))) 
          Common.highlight (sprintf "now.IsTomorrow() // => %A" (now.IsTomorrow()))
          Common.highlight (sprintf "now.IsInTheSameDayAs(tomorrow) // => %A" (now.IsInTheSameDayAs(tomorrow)))
          Common.highlight (sprintf "tomorrow.IsInTheSameDayAs(tomorrow) // => %A" (tomorrow.IsInTheSameDayAs(tomorrow)))
          Common.highlight (sprintf "tomorrow.IsInTheFuture() // => %A" (tomorrow.IsInTheFuture()))
          Common.highlight (sprintf "yesterday.IsInTheFuture() // => %A" (yesterday.IsInTheFuture()))
          Common.highlight (sprintf "yesterday.IsInThePast() // => %A" (yesterday.IsInThePast()))
          Common.highlight (sprintf "yesterday.EndOfDay() // => %A" (yesterday.EndOfDay()))
          Common.highlight (sprintf "now.StartOfDay() // => %A" (now.StartOfDay()))
          Common.highlight (sprintf "now.IsInSameMinuteAs(now.AddSeconds(5.0)) // => %A" (now.IsInSameMinuteAs(now.AddSeconds(5.0))))
          Common.highlight (sprintf "now.IsBetween(yesterday, tomorrow) ==> %A" (now.IsBetween(yesterday, tomorrow))) 
          Common.highlight (sprintf "now.SubtractDays(1).IsInThePast()  ==> %A" (now.SubtractDays(1).IsInThePast())) 
          h1 [ Style [ FontSize 30 ] ] [ str "Locales Support (32 languages)" ]
          p [ ] [ span [ ] [ str "See "; a [ Href "https://date-fns.org/v1.29.0/docs/format" ] [ str "https://date-fns.org/v1.29.0/docs/format" ]; str " for the full documentation on formatting strings" ]  ]
          Common.highlight (sprintf "now.Format(\"Do MMMM YYYY\", DateTime.Locales.Russian) ==> %A" (now.Format("Do MMMM YYYY", DateTime.Locales.Dutch))) 
          Common.highlight (sprintf "now.Format(\"Do MMMM YYYY\", DateTime.Locales.Spanish) ==> %A" (now.Format("Do MMMM YYYY", DateTime.Locales.Spanish))) 
          Common.highlight (sprintf "now.Format(\"Do MMMM YYYY\", DateTime.Locales.French) ==> %A" (now.Format("Do MMMM YYYY", DateTime.Locales.French))) 
          Common.highlight (sprintf "now.Format(\"Do MMMM YYYY\", DateTime.Locales.Japanese) ==> %A" (now.Format("Do MMMM YYYY", DateTime.Locales.Japanese))) 
          Common.highlight (sprintf "now.Format(\"Do MMMM YYYY\", DateTime.Locales.Russian) ==> %A" (now.Format("Do MMMM YYYY", DateTime.Locales.Russian))) 
          p [ ] [ str "Distance in words" ]
          Common.highlight (sprintf """let formatOptions = createEmpty<IDistanceInWordsOptions>
formatOptions.includeSeconds <- false 
formatOptions.addSuffix <- true 
formatOptions.locale <- DateTime.Locales.Dutch  

DateTime.Now.SubtractMonths(1).DistanceInWordsToNow(formatOptions) => // "%s" """ formatted)
          ]


let spacing = Props.Style [ Props.Padding 20 ]

let render (state: State) dispatch = 
    introduction