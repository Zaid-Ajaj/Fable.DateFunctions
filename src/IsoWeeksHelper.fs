namespace Fable.DateFunctions

open System

[<AutoOpen>]
module IsoWeeksHelper =
    type DateTime with
        /// Get the number of calendar ISO weeks between the given dates.
        member inline date.DifferenceInCalendarISOWeeks(otherDate: DateTime) : int = ExternalDateFns.differenceInCalendarISOWeeks date otherDate
        /// Return the end of an ISO week for the given date. The result will be in the local timezone.
        member inline date.EndOfIsoWeek() : DateTime = ExternalDateFns.endOfIsoWeek date
        member inline date.IsInTheSameISOWeekAs(otherDate: DateTime) : bool = ExternalDateFns.isSameIsoWeek date otherDate
        member inline date.IsInThisISOWeek() : bool = ExternalDateFns.isThisIsoWeek date
        member inline date.GetISOWeek() : int = ExternalDateFns.getISOWeek date
        member inline date.LastDayOfISOWeek() : DateTime = ExternalDateFns.lastDayOfIsoWeek date
        member inline date.StartOfISOWeek() : DateTime = ExternalDateFns.startOfIsoWeek date
        /// Set the ISO week to the given date, saving the weekday number.
        member inline date.SetISOWeek(n : int) : DateTime = ExternalDateFns.setIsoWeek date n
