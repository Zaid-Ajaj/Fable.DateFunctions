namespace Fable.DateFunctions

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

[<AutoOpen>]
module MinuteHelpers = 
    type DateTime with
        /// Adds the specified number of minutes to the given date and returns a new Date.
        member date.AddMinutes(amount: int) : DateTime = ExternalDateFns.addMinutes date amount
        /// Get the number of minutes between the given dates.
        member date.DifferenceInMinutes(otherDate : DateTime) : int = ExternalDateFns.differenceInMinutes date otherDate
        /// Return the end of a minute for the given date. The result will be in the local timezone.
        member date.EndOfMinute() : DateTime = ExternalDateFns.endOfMinute date
        /// Returns the minutes of the given date.
        member date.GetMinutes() : int = ExternalDateFns.getMinutes date
        /// Returns whether or not the given dates are in the same minute
        member date.IsInSameMinuteAs(otherDate : DateTime) : bool = ExternalDateFns.isSameMinute date otherDate
        /// Returns whether or not the given date is in this minute of the current date.
        static member IsThisMinute(date: DateTime) : bool = ExternalDateFns.isThisMinute date
        /// Sets the minutes to the given date and returns a new DateTime
        static member SetMinutes(date: DateTime, minutes: int) : DateTime = ExternalDateFns.setMinutes date minutes
        /// Return the start of a minute for the given date. The result will be in the local timezone.
        static member StartOfMinute(date: DateTime) : DateTime = ExternalDateFns.startOfMinute date
        /// Subtracts the specified number of minutes from the given date and returns a new date.
        static member SubMinutes(date: DateTime, minutes : int) : DateTime = ExternalDateFns.subMinutes date minutes