module Program

open Elmish
open Elmish.React
open Elmish.Debug

open App.State
open App.View
           
Program.mkProgram init update render
|> Program.withConsoleTrace
|> Program.withReactSynchronous "elmish-app"
|> Program.run