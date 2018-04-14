namespace Fable.DateFunctions

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

[<AutoOpen>]
module MillisecondHelpers = 
    type DateFns with
        /// Adds the given amount of milliseconds to the given time and returns a new DateTime instance.
        static member AddMilliseconds(date: DateTime, amount: int) : DateTime = ExternalDateFns.addMilliseconds date amount
        /// Get the number of milliseconds between the given dates.
        static member DifferenceInMilliseconds(date: DateTime, otherDate: DateTime) : int = ExternalDateFns.differenceInMilliseconds date otherDate
        /// Get the milliseconds of the given date.
        static member GetMilliseconds(date: DateTime) : int = ExternalDateFns.getMilliseconds date
        /// Set the milliseconds to the given date, returns a new date with the milliseconds setted.
        static member SetMilliseconds(date: DateTime, ms: int) : DateTime = ExternalDateFns.setMilliseconds date ms
        /// Subtract the specified number of milliseconds from the given date, returns a new DateTime instance.
        static member SubMilliseconds(date: DateTime, ms: int) : DateTime = ExternalDateFns.subMilliseconds date ms