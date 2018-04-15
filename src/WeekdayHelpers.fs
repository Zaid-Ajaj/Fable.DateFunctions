namespace Fable.DateFunctions

open System

[<AutoOpenAttribute>]
module WeekdayHelpers = 
    type DateTime with
        /// Get the day of the week of the given date.
        member date.GetDayNumberOfWeek() : int = ExternalDateFns.getDay date
        /// Get the day of the ISO week of the given date, which is 7 for Sunday, 1 for Monday etc.
        /// ISO week-numbering year: http://en.wikipedia.org/wiki/ISO_week_date
        member date.GetISODayNumberOfWeek() : int = ExternalDateFns.getISODay date
        member date.IsFriday() : bool = ExternalDateFns.isFriday date
        member date.IsMonday() : bool = ExternalDateFns.isMonday date
        member date.IsSaturday() : bool = ExternalDateFns.isSaturday date
        member date.IsSunday() : bool = ExternalDateFns.isSunday date
        member date.IsThursday() : bool = ExternalDateFns.isThursday date
        member date.IsTuesday() : bool = ExternalDateFns.isTuesday date
        member date.IsWednesday() : bool = ExternalDateFns.isWednesday date
        member date.IsWeekend () : bool = ExternalDateFns.isWeekend date
