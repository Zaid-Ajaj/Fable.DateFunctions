namespace Fable.DateFunctions

open System

[<AutoOpen>]
module SecondHelpers = 
    type DateTime with
        /// Add the specified number of seconds to the given date and returns a new date.
        member date.AddSeconds(amount: int) : DateTime = ExternalDateFns.addSeconds date amount
        /// Returns the number of seconds between the given dates.
        member date.DifferenceInSeconds(other: DateTime) : int = ExternalDateFns.differenceInSeconds date other
        /// Returns the end of a second for the given date. The result will be in the local timezone.
        member date.EndOfSecond() : DateTime = ExternalDateFns.endOfSecond date
        /// Returns the seconds of the given date.
        member date.GetSeconds() : int = ExternalDateFns.getSeconds date
        /// Returns whether the given dates are in the same second.
        member date.IsInTheSameSecondAs(other: DateTime) : bool = ExternalDateFns.isSameSecond date other
        /// Returns whether the given date is in the same second as the current date
        member date.IsInThisSecond() : bool = ExternalDateFns.isThisSecond date
        /// Sets the seconds to the given date.
        member date.SetSeconds(amount: int) : DateTime = ExternalDateFns.setSeconds date amount
        /// Returns the start of a second for the given date. The result will be in the local timezone.
        member date.StartOfSecond() : DateTime = ExternalDateFns.startOfSecond date
        /// Subtracts the specified number of seconds from the given date and return a new DateTime.
        member date.SubtractSeconds(amount : int) : DateTime = ExternalDateFns.subSeconds date amount
