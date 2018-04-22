namespace Fable.DateFunctions

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

[<AutoOpen>]
module MillisecondHelpers =
    type DateTime with
        /// Adds the given amount of milliseconds to the given time and returns a new DateTime instance.
        member inline date.AddMilliseconds(amount: int) : DateTime = ExternalDateFns.addMilliseconds date amount
        /// Get the number of milliseconds between the given dates.
        member inline date.DifferenceInMilliseconds(otherDate: DateTime) : int = ExternalDateFns.differenceInMilliseconds date otherDate
        /// Get the milliseconds of the given date.
        member inline date.GetMilliseconds() : int = ExternalDateFns.getMilliseconds date
        /// Set the milliseconds to the given date, returns a new date with the milliseconds setted.
        member inline date.SetMilliseconds(ms: int) : DateTime = ExternalDateFns.setMilliseconds date ms
        /// Subtract the specified number of milliseconds from the given date, returns a new DateTime instance.
        member inline date.SubtractMilliseconds(ms: int) : DateTime = ExternalDateFns.subMilliseconds date ms
