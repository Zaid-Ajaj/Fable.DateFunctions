module Program

open Elmish
open Elmish.HMR
open Elmish.React
open Elmish.Debug
open Elmish.Browser.Navigation
open Fable.Core.JsInterop

open App.State
open App.View

importAll "highlight.js/styles/ocean.css"
           
Program.mkProgram init update render
|> Program.withConsoleTrace
|> Program.withDebugger
|> Program.withReactSynchronous "elmish-app"
|> Program.run