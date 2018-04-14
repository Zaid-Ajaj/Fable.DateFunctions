namespace Fable.DateFunctions

open System

[<AutoOpen>]
module HourHelpers = 
    type DateTime with 
        /// Adds the specified number of hours to the given date, returns a new date.
        member date.AddHours(amount : int) : DateTime = ExternalDateFns.addHours date amount
        /// Get the number of hours between the given dates.
        member date.DifferenceInHours(otherDate: DateTime) : int = ExternalDateFns.differenceInHours date otherDate
        /// Return the end of an hour for the given date. The result will be in the local timezone.
        member date.EndOfHour() : DateTime = ExternalDateFns.endOfHour date
        /// Are the given dates in the same hour?
        member date.IsTheSameHourAs(otherDate : DateTime) : bool = ExternalDateFns.isSameHour date otherDate
        /// Is the given date in the same hour as the current date?
        static member IsThisHour(date: DateTime) : bool = ExternalDateFns.isThisHour date
        /// Set the hours to the given date.
        member date.SetHours(hours: int) : DateTime = ExternalDateFns.setHours date hours
        /// Return the start of an hour for the given date. The result will be in the local timezone.
        member date.StartOfHour() : DateTime = ExternalDateFns.startOfHour date
        /// Subtract the specified number of hours from the given date.
        member date.SubtractHours(hours: int) : DateTime = ExternalDateFns.subHours date hours