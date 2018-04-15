namespace Fable.DateFunctions

open System 

[<AutoOpen>]
module WeekHelpers = 
    type DateTime with 
        /// Add the specified number of week to the given date.
        member date.AddWeeks(numberOfWeeks: int) = ExternalDateFns.addWeeks date numberOfWeeks
        /// Gets the number of calendar weeks between the given dates.
        member date.DifferenceInCalendarWeeks(otherDate: DateTime) : int = ExternalDateFns.differenceInCalendarWeeks date otherDate
        /// Get the number of full weeks between the given dates.
        member date.DifferenceInWeeks(otherDate: DateTime) : int = ExternalDateFns.differenceInWeeks date otherDate
        /// Return the end of a week for the given date. The result will be in the local timezone.
        member date.EndOfWeek() : DateTime = ExternalDateFns.endOfWeek date
        member date.IsInTheSameWeekAs(otherDate: DateTime) : bool = ExternalDateFns.isSameWeek date otherDate
        member date.IsInThisWeek() : bool = ExternalDateFns.isThisWeek date 
        /// Returns the DateTime of the last day of the week of the current instance of DateTime
        member date.LastDayOfWeek() : DateTime = ExternalDateFns.lastDayOfWeek date 
        /// Returns the DateTime of the first day of the week of the current instance of DateTime
        member date.StartOfWeek() : DateTime = ExternalDateFns.startOfWeek date
        member date.SubtractWeeks(n : int) : DateTime = ExternalDateFns.subWeeks date n

