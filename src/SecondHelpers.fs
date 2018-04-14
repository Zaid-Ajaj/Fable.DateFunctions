namespace Fable.DateFunctions

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

[<AutoOpen>]
module SecondHelpers = 
    type DateFns with
        /// Add the specified number of seconds to the given date and returns a new date.
        static member AddSeconds(date: DateTime, amount: int) : DateTime = ExternalDateFns.addSeconds date amount
        /// Returns the number of seconds between the given dates.
        static member DifferenceInSeconds(date: DateTime, other: DateTime) : int = ExternalDateFns.differenceInSeconds date other
        /// Returns the end of a second for the given date. The result will be in the local timezone.
        static member EndOfSecond(date: DateTime) : DateTime = ExternalDateFns.endOfSecond date
        /// Returns the seconds of the given date.
        static member GetSeconds(date: DateTime) : int = ExternalDateFns.getSeconds date
        /// Returns whether the given dates are in the same second.
        static member IsSameSecond(date: DateTime, other: DateTime) : bool = ExternalDateFns.isSameSecond date other
        /// Returns whether the given date is in the same second as the current date
        static member IsThisSecond(date: DateTime) : bool = ExternalDateFns.isThisSecond date
        /// Sets the seconds to the given date.
        static member SetSeconds(date: DateTime, amount: int) : DateTime = ExternalDateFns.setSeconds date amount
        /// Returns the start of a second for the given date. The result will be in the local timezone.
        static member StartOfSecond(date: DateTime) : DateTime = ExternalDateFns.startOfSecond date
        /// Subtracts the specified number of seconds from the given date and return a new DateTime.
        static member SubSeconds(date: DateTime, amount : int) : DateTime = ExternalDateFns.subSeconds date amount
