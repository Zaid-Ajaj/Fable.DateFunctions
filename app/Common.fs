module Common

open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop
open Fable.Core

let classes args  =
    args 
    |> List.filter snd 
    |> List.map fst
    |> String.concat " "
    |> ClassName

let highlight (codeBlock: string) = 
    pre [ ] [ code [ ] [ str codeBlock ] ]