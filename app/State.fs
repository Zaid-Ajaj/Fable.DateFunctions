module App.State 

open App.Types
open Elmish

let init() = 
    0, Cmd.none

let update msg state = state, Cmd.none