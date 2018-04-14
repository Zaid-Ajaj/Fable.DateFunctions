module Common

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Core.JsInterop
open Fable.Core

let classes args  =
    args 
    |> List.filter snd 
    |> List.map fst
    |> String.concat " "
    |> ClassName

let highlight (code: string) = 
    ofImport "default" "react-highlight" 
             (createObj [ "className" ==> "fsharp"]) 
             [ str code ]