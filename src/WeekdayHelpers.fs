namespace Fable.DateFunctions

open System

[<AutoOpenAttribute>]
module WeekdayHelpers =
    type DateTime with
        /// Get the day of the week of the given date.
        member inline date.GetDayNumberOfWeek() : int = ExternalDateFns.getDay date
        /// Get the day of the ISO week of the given date, which is 7 for Sunday, 1 for Monday etc.
        /// ISO week-numbering year: http://en.wikipedia.org/wiki/ISO_week_date
        member inline date.GetISODayNumberOfWeek() : int = ExternalDateFns.getISODay date
        member inline date.IsFriday() : bool = ExternalDateFns.isFriday date
        member inline date.IsMonday() : bool = ExternalDateFns.isMonday date
        member inline date.IsSaturday() : bool = ExternalDateFns.isSaturday date
        member inline date.IsSunday() : bool = ExternalDateFns.isSunday date
        member inline date.IsThursday() : bool = ExternalDateFns.isThursday date
        member inline date.IsTuesday() : bool = ExternalDateFns.isTuesday date
        member inline date.IsWednesday() : bool = ExternalDateFns.isWednesday date
        member inline date.IsWeekend () : bool = ExternalDateFns.isWeekend date
