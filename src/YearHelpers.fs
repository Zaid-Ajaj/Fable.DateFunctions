namespace Fable.DateFunctions

open System

[<AutoOpen>]
module YearHelpers =
    type DateTime with
        member inline date.AddYears(n: int) : DateTime = ExternalDateFns.addYears date n
        member inline date.DifferenceInCalendarYears(otherDate: DateTime) : int = ExternalDateFns.differenceInCalendarYears date otherDate
        member inline date.DifferenceInYears(otherDate: DateTime) : int = ExternalDateFns.differenceInYears date otherDate
        member inline date.EndOfYear() : DateTime = ExternalDateFns.endOfYear date
        /// Returns the number of days in the year of the current instance of DateTime
        member inline date.DaysInYear() : int = ExternalDateFns.daysInYear date
        /// Returns whether or not the current instance of DateTime is a leap year
        member inline date.IsLeapYear() : bool = ExternalDateFns.isLeapYear date
        /// Returns whether or not the given date is in the same year as the current instance of DateTime
        member inline date.IsInTheSameYearAs(otherDate: DateTime) = ExternalDateFns.isSameYear date otherDate
        /// Returns whether or not the current instance of DateTime is in this year or not
        member inline date.IsInThisYear() : bool = ExternalDateFns.isThisYear date
        /// Returns the DateTime of the last day in the year of the current instance of DateTime
        member inline date.LastDayOfYear() : DateTime = ExternalDateFns.lastDayOfYear date
        /// Returns the DateTime of the first day in the year of the current instance of DateTime
        member inline date.StartOfYear() : DateTime = ExternalDateFns.startOfYear date
        /// Returns the start of day of the previous year relative to the year of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddYears(-1).StartOfYear().StartOfDay()`
        member inline date.StartOfPreviousYear() : DateTime = date.AddYears(-1).StartOfYear().StartOfDay()
        /// Returns the end of day of the previous year relative to the year of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddYears(-1).EndOfYear().EndOfDay()`
        member inline date.EndOfPreviousYear() : DateTime = date.AddYears(-1).EndOfYear().EndOfDay()
        /// Returns the start of day of the next year relative to the year of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddYears(1).StartOfYear().StartOfDay()`
        member inline date.StartOfNextYear() : DateTime = date.AddYears(1).StartOfYear().StartOfDay()
        /// Returns the end of day of the next year relative to the year of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddYears(1).EndOfYear().EndOfDay()`
        member inline date.EndOfNextYear() : DateTime = date.AddYears(1).EndOfYear().EndOfDay()
        member inline date.SubtractYears(n : int) : DateTime = ExternalDateFns.subYears date n

[<AutoOpen>]
module YearHelpersDateTimeOffset =
    type DateTimeOffset with
        member inline date.AddYears(n: int) : DateTimeOffset = DateTimeOffset(ExternalDateFns.addYears date n)
        member inline date.DifferenceInCalendarYears(otherDate: DateTimeOffset) : int = ExternalDateFns.differenceInCalendarYears date otherDate
        member inline date.DifferenceInYears(otherDate: DateTimeOffset) : int = ExternalDateFns.differenceInYears date otherDate
        member inline date.EndOfYear() : DateTimeOffset = DateTimeOffset(ExternalDateFns.endOfYear date)
        /// Returns the number of days in the year of the current instance of DateTime
        member inline date.DaysInYear() : int = ExternalDateFns.daysInYear date
        /// Returns whether or not the current instance of DateTime is a leap year
        member inline date.IsLeapYear() : bool = ExternalDateFns.isLeapYear date
        /// Returns whether or not the given date is in the same year as the current instance of DateTime
        member inline date.IsInTheSameYearAs(otherDate: DateTimeOffset) = ExternalDateFns.isSameYear date otherDate
        /// Returns whether or not the current instance of DateTime is in this year or not
        member inline date.IsInThisYear() : bool = ExternalDateFns.isThisYear date
        /// Returns the DateTimeOffset of the last day in the year of the current instance of DateTime
        member inline date.LastDayOfYear() : DateTimeOffset = DateTimeOffset(ExternalDateFns.lastDayOfYear date)
        /// Returns the DateTime of the first day in the year of the current instance of DateTime
        member inline date.StartOfYear() : DateTimeOffset = DateTimeOffset(ExternalDateFns.startOfYear date)
        /// Returns the start of day of the previous year relative to the year of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddYears(-1).StartOfYear().StartOfDay()`
        member inline date.StartOfPreviousYear() : DateTimeOffset = date.AddYears(-1).StartOfYear().StartOfDay()
        /// Returns the end of day of the previous year relative to the year of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddYears(-1).EndOfYear().EndOfDay()`
        member inline date.EndOfPreviousYear() : DateTimeOffset = date.AddYears(-1).EndOfYear().EndOfDay()
        /// Returns the start of day of the next year relative to the year of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddYears(1).StartOfYear().StartOfDay()`
        member inline date.StartOfNextYear() : DateTimeOffset = date.AddYears(1).StartOfYear().StartOfDay()
        /// Returns the end of day of the next year relative to the year of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddYears(1).EndOfYear().EndOfDay()`
        member inline date.EndOfNextYear() : DateTimeOffset = date.AddYears(1).EndOfYear().EndOfDay()
        member inline date.SubtractYears(n : int) : DateTimeOffset = DateTimeOffset(ExternalDateFns.subYears date n)
