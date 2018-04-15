namespace Fable.DateFunctions 

open System 

[<AutoOpen>]
module IsoWeeksHelper = 
    type DateTime with 
        /// Get the number of calendar ISO weeks between the given dates.
        member date.DifferenceInCalendarISOWeeks(otherDate: DateTime) : int = ExternalDateFns.differenceInCalendarISOWeeks date otherDate
        /// Return the end of an ISO week for the given date. The result will be in the local timezone.
        member date.EndOfIsoWeek() : DateTime = ExternalDateFns.endOfIsoWeek date
        member date.IsInTheSameISOWeekAs(otherDate: DateTime) : bool = ExternalDateFns.isSameIsoWeek date otherDate
        member date.IsInThisISOWeek() : bool = ExternalDateFns.isThisIsoWeek date 
        member date.GetISOWeek() : int = ExternalDateFns.getISOWeek date
        member date.LastDayOfISOWeek() : DateTime = ExternalDateFns.lastDayOfIsoWeek date 
        member date.StartOfISOWeek() : DateTime = ExternalDateFns.startOfIsoWeek date
        /// Set the ISO week to the given date, saving the weekday number.
        member date.SetISOWeek(n : int) : DateTime = ExternalDateFns.setIsoWeek date n