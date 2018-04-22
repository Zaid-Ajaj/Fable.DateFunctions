namespace Fable.DateFunctions

open System 

[<AutoOpen>]
module YearHelpers = 
    type DateTime with 
        member date.AddYears(n: int) : DateTime = ExternalDateFns.addYears date n 
        member date.DifferenceInCalendarYears(otherDate: DateTime) : int = ExternalDateFns.differenceInCalendarYears date otherDate 
        member date.DifferenceInYears(otherDate: DateTime) : int = ExternalDateFns.differenceInYears date otherDate
        member date.EndOfYear() : DateTime = ExternalDateFns.endOfYear date 
        /// Returns the number of days in the year of the current instance of DateTime
        member date.DaysInYear() : int = ExternalDateFns.daysInYear date 
        /// Returns whether or not the current instance of DateTime is a leap year
        member date.IsLeapYear() : bool = ExternalDateFns.isLeapYear date
        /// Returns whether or not the given date is in the same year as the current instance of DateTime
        member date.IsInTheSameYearAs(otherDate: DateTime) = ExternalDateFns.isSameYear date otherDate
        /// Returns whether or not the current instance of DateTime is in this year or not
        member date.IsInThisYear() : bool = ExternalDateFns.isThisYear date
        /// Returns the DateTime of the last day in the year of the current instance of DateTime
        member date.LastDayOfYear() : DateTime = ExternalDateFns.lastDayOfYear date
        /// Returns the DateTime of the first day in the year of the current instance of DateTime
        member date.StartOfYear() : DateTime = ExternalDateFns.startOfYear date
        member date.SubtractYears(n : int) : DateTime = ExternalDateFns.subYears date n