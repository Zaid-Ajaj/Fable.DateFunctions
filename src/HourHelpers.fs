namespace Fable.DateFunctions

open System

[<AutoOpen>]
module HourHelpers =
    type DateTime with
        /// Adds the specified number of hours to the given date, returns a new date.
        member inline date.AddHours(amount : int) : DateTime = ExternalDateFns.addHours date amount
        /// Get the number of hours between the given dates.
        member inline date.DifferenceInHours(otherDate: DateTime) : int = ExternalDateFns.differenceInHours date otherDate
        /// Return the end of an hour for the given date. The result will be in the local timezone.
        member inline date.EndOfHour() : DateTime = ExternalDateFns.endOfHour date
        /// Are the given dates in the same hour?
        member inline date.IsTheSameHourAs(otherDate : DateTime) : bool = ExternalDateFns.isSameHour date otherDate
        /// Is the given date in the same hour as the current date?
        member inline date.IsInThisHour() : bool = ExternalDateFns.isThisHour date
        /// Set the hours to the given date.
        member inline date.SetHours(hours: int) : DateTime = ExternalDateFns.setHours date hours
        /// Return the start of an hour for the given date. The result will be in the local timezone.
        member inline date.StartOfHour() : DateTime = ExternalDateFns.startOfHour date
        /// Subtract the specified number of hours from the given date.
        member inline date.SubtractHours(hours: int) : DateTime = ExternalDateFns.subHours date hours

[<AutoOpen>]
module HourHelpersDateTimeOffset =
    type DateTimeOffset with
        /// Adds the specified number of hours to the given date, returns a new date.
        member inline date.AddHours(amount : int) : DateTimeOffset = DateTimeOffset(ExternalDateFns.addHours date amount)
        /// Get the number of hours between the given dates.
        member inline date.DifferenceInHours(otherDate: DateTimeOffset) : int = ExternalDateFns.differenceInHours date otherDate
        /// Return the end of an hour for the given date. The result will be in the local timezone.
        member inline date.EndOfHour() : DateTimeOffset = DateTimeOffset(ExternalDateFns.endOfHour date)
        /// Are the given dates in the same hour?
        member inline date.IsTheSameHourAs(otherDate : DateTimeOffset) : bool = ExternalDateFns.isSameHour date otherDate
        /// Is the given date in the same hour as the current date?
        member inline date.IsInThisHour() : bool = ExternalDateFns.isThisHour date
        /// Set the hours to the given date.
        member inline date.SetHours(hours: int) : DateTimeOffset = DateTimeOffset(ExternalDateFns.setHours date hours)
        /// Return the start of an hour for the given date. The result will be in the local timezone.
        member inline date.StartOfHour() : DateTimeOffset = DateTimeOffset(ExternalDateFns.startOfHour date)
        /// Subtract the specified number of hours from the given date.
        member inline date.SubtractHours(hours: int) : DateTimeOffset = DateTimeOffset(ExternalDateFns.subHours date hours)