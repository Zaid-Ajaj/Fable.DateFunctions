namespace Fable.DateFunctions

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

[<AutoOpen>]
module TimestampHelpers = 
    type DateFns with 
        /// Returns the milliseconds timestamp of the given date.
        static member GetTime(date: DateTime) : int = ExternalDateFns.getTime date