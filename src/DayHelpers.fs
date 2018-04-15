namespace Fable.DateFunctions

open System

[<AutoOpen>]
module DayHelpers =    
    type DateTime with
        /// Add the specified number of days to the given date.
        member date.AddDays(days: int) : DateTime = ExternalDateFns.addDays date days
        /// Get the number of calendar days between the given dates.
        member dateLeft.DifferenceInCalenderDays(dateRight: DateTime) : int = ExternalDateFns.differenceInCalendarDays dateLeft dateRight
        /// Get the number of full days between the given dates.
        member dateLeft.DifferenceInDays(dateRight: DateTime) : int = ExternalDateFns.differenceInDays dateLeft dateRight
        /// Return the array of dates within the specified range.
        static member DatesBetween(startDate : DateTime, endDate: DateTime) : DateTime[] = ExternalDateFns.eachDay startDate endDate
        /// Return the end of a day for the given date. The result will be in the local timezone.
        member date.EndOfDay() : DateTime = ExternalDateFns.endOfDay date
        static member EndOfToday() : DateTime = ExternalDateFns.endOfToday()
        static member EndOfTomorrow() : DateTime = ExternalDateFns.endOfTomorrow()
        static member EndOfYesterday() : DateTime = ExternalDateFns.endOfYesterday()
        member date.GetDayOfMonth() : int = ExternalDateFns.getDate date
        member date.GetDayOfYear() : int = ExternalDateFns.getDayOfYear date
        /// Returns whether or not the given dates are in the same day
        member date.IsInTheSameDayAs(otherDate: DateTime) : bool = ExternalDateFns.isSameDay date otherDate
        /// Returns whether or not the given date is today.
        member date.IsToday() : bool = ExternalDateFns.isToday date
        member date.IsTomorrow() : bool = ExternalDateFns.isTomorrow date
        member date.IsYesterday() : bool = ExternalDateFns.isYesterday date
        member date.SetDayOfMonth(dayOfMonth: int) : DateTime = ExternalDateFns.setDate date dayOfMonth
        member date.SetDayOfYear(day: int) : DateTime = ExternalDateFns.setDayOfyear date day
        /// Returns that start of the day of the given date
        member date.StartOfDay() : DateTime = ExternalDateFns.startOfDay date
        static member StartOfToday() : DateTime = ExternalDateFns.startOfToday()
        static member StartOfYesterday() : DateTime = ExternalDateFns.startOfYesterday()
        static member StartOfTomorrow() : DateTime = ExternalDateFns.startOfTomorrow()
        member date.SubtractDays(days: int) : DateTime = ExternalDateFns.subDays date days