namespace Fable.DateFunctions

open System

[<AutoOpenAttribute>]
module WeekdayHelpers = 
    type DateFns with
        /// Get the day of the week of the given date.
        static member GetDayNumberOfWeek(date: DateTime) : int = ExternalDateFns.getDay date
        /// Get the day of the ISO week of the given date, which is 7 for Sunday, 1 for Monday etc.
        /// ISO week-numbering year: http://en.wikipedia.org/wiki/ISO_week_date
        static member GetISODayNumberOfWeek(date: DateTime) : int = ExternalDateFns.getISODay date
        static member IsFriday(date: DateTime) : bool = ExternalDateFns.isFriday date
        static member IsMonday(date: DateTime) : bool = ExternalDateFns.isMonday date
        static member IsSaturday(date: DateTime) : bool = ExternalDateFns.isSaturday date
        static member IsSunday(date: DateTime) : bool = ExternalDateFns.isSunday date
        static member IsThursday(date: DateTime) : bool = ExternalDateFns.isThursday date
        static member IsTuesday(date: DateTime) : bool = ExternalDateFns.isTuesday date
        static member IsWednesday(date: DateTime) : bool = ExternalDateFns.isWednesday date
        static member IsWeekend (date: DateTime) : bool = ExternalDateFns.isWeekend date
