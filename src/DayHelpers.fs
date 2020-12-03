namespace Fable.DateFunctions

open System

[<AutoOpen>]
module DayHelpers =
    type DateTime with
        /// Add the specified number of days to the given date.
        member inline date.AddDays(days: int) : DateTime = ExternalDateFns.addDays date days
        /// Get the number of calendar days between the given dates.
        member inline dateLeft.DifferenceInCalenderDays(dateRight: DateTime) : int = ExternalDateFns.differenceInCalendarDays dateLeft dateRight
        /// Get the number of full days between the given dates.
        member inline dateLeft.DifferenceInDays(dateRight: DateTime) : int = ExternalDateFns.differenceInDays dateLeft dateRight
        /// Return the array of dates within the specified range.
        static member inline DatesBetween(startDate : DateTime, endDate: DateTime) : DateTime[] =
            ExternalDateFns.eachDayOfInterval {| start = startDate; ``end``= endDate |}
        /// Return the end of a day for the given date. The result will be in the local timezone.
        member inline date.EndOfDay() : DateTime = ExternalDateFns.endOfDay date
        static member inline EndOfToday() : DateTime = ExternalDateFns.endOfToday()
        static member inline EndOfTomorrow() : DateTime = ExternalDateFns.endOfTomorrow()
        static member inline EndOfYesterday() : DateTime = ExternalDateFns.endOfYesterday()
        member inline date.GetDayOfMonth() : int = ExternalDateFns.getDate date
        member inline date.GetDayOfYear() : int = ExternalDateFns.getDayOfYear date
        /// Returns whether or not the given dates are in the same day
        member inline date.IsInTheSameDayAs(otherDate: DateTime) : bool = ExternalDateFns.isSameDay date otherDate
        /// Returns whether or not the given date is today.
        member inline date.IsToday() : bool = ExternalDateFns.isToday date
        member inline date.IsTomorrow() : bool = ExternalDateFns.isTomorrow date
        member inline date.IsYesterday() : bool = ExternalDateFns.isYesterday date
        member inline date.SetDayOfMonth(dayOfMonth: int) : DateTime = ExternalDateFns.setDate date dayOfMonth
        member inline date.SetDayOfYear(day: int) : DateTime = ExternalDateFns.setDayOfyear date day
        /// Returns that start of the day of the given date
        member inline date.StartOfDay() : DateTime = ExternalDateFns.startOfDay date
        static member inline StartOfToday() : DateTime = ExternalDateFns.startOfToday()
        static member inline StartOfYesterday() : DateTime = ExternalDateFns.startOfYesterday()
        static member inline StartOfTomorrow() : DateTime = ExternalDateFns.startOfTomorrow()
        member inline date.SubtractDays(days: int) : DateTime = ExternalDateFns.subDays date days

[<AutoOpen>]
module DayHelpersDateTimeOffset =
    type DateTimeOffset with
        /// Add the specified number of days to the given date.
        member inline date.AddDays(days: int) : DateTimeOffset = DateTimeOffset(ExternalDateFns.addDays date days)
        /// Get the number of calendar days between the given dates.
        member inline dateLeft.DifferenceInCalenderDays(dateRight: DateTimeOffset) : int = ExternalDateFns.differenceInCalendarDays dateLeft dateRight
        /// Get the number of full days between the given dates.
        member inline dateLeft.DifferenceInDays(dateRight: DateTimeOffset) : int = ExternalDateFns.differenceInDays dateLeft dateRight
        /// Return the end of a day for the given date. The result will be in the local timezone.
        member inline date.EndOfDay() : DateTimeOffset = DateTimeOffset(ExternalDateFns.endOfDay date)
        static member inline EndOfToday() : DateTimeOffset = DateTimeOffset (ExternalDateFns.endOfToday())
        static member inline EndOfTomorrow() : DateTimeOffset = DateTimeOffset (ExternalDateFns.endOfTomorrow())
        static member inline EndOfYesterday() : DateTimeOffset = DateTimeOffset (ExternalDateFns.endOfYesterday())
        member inline date.GetDayOfMonth() : int = ExternalDateFns.getDate date
        member inline date.GetDayOfYear() : int = ExternalDateFns.getDayOfYear date
        /// Returns whether or not the given dates are in the same day
        member inline date.IsInTheSameDayAs(otherDate: DateTimeOffset) : bool = ExternalDateFns.isSameDay date otherDate
        /// Returns whether or not the given date is today.
        member inline date.IsToday() : bool = ExternalDateFns.isToday date
        member inline date.IsTomorrow() : bool = ExternalDateFns.isTomorrow date
        member inline date.IsYesterday() : bool = ExternalDateFns.isYesterday date
        member inline date.SetDayOfMonth(dayOfMonth: int) : DateTimeOffset = DateTimeOffset (ExternalDateFns.setDate date dayOfMonth)
        member inline date.SetDayOfYear(day: int) : DateTimeOffset = DateTimeOffset(ExternalDateFns.setDayOfyear date day)
        /// Returns that start of the day of the given date
        member inline date.StartOfDay() : DateTimeOffset = DateTimeOffset(ExternalDateFns.startOfDay date)
        static member inline StartOfToday() : DateTimeOffset = DateTimeOffset(ExternalDateFns.startOfToday())
        static member inline StartOfYesterday() : DateTimeOffset = DateTimeOffset(ExternalDateFns.startOfYesterday())
        static member inline StartOfTomorrow() : DateTimeOffset = DateTimeOffset(ExternalDateFns.startOfTomorrow())
        member inline date.SubtractDays(days: int) : DateTimeOffset = DateTimeOffset(ExternalDateFns.subDays date days)
