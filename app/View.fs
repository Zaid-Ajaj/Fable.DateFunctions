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

let now = DateTime.Now 
let tomorrow = now.AddDays(1.0)
let yesterday = now.AddDays(-1.0)

let introduction = 
    div [ ]  
        [ h1 [ Style [ FontSize 30 ] ] [ a [ Href "https://github.com/Zaid-Ajaj/Fable.DateFunctions" ] [ str "Fable.DateFunctions"  ]  ]
          p  [ ] [ str "Fable binding for date-fns, a library with 80+ functions for working with dates, implemented with Fable as extension methods for DateTime." ] 
          hr [ ]
          h1 [ Style [ FontSize 30 ] ] [ str "Examples and configurations" ]
          Common.highlight """let now = DateTime.Now
let yesterday = now.AddDays(-1.0)
let tomorrow = now.AddDays(1.0)"""
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
          ]

let spacing = Props.Style [ Props.Padding 20 ]

let render (state: State) dispatch = 
    introduction