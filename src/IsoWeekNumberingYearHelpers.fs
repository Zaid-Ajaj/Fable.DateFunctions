namespace Fable.DateFunctions

open System

[<AutoOpen>]
module IsoWeekNumberingYearHelpers =
    type DateTime with
        /// Add the specified number of ISO week-numbering years to the given date.
        member inline date.AddISOWeekYears(amount: int) : DateTime = ExternalDateFns.addISOWeekYears date amount
        /// Get the number of calendar ISO week-numbering years between the given dates.
        member inline date.DifferenceInCalendarISOWeekYears(otherDate: DateTime) : int = ExternalDateFns.differenceInCalendarISOWeeks date otherDate
        /// Get the number of full ISO week-numbering years between the given dates.
        member inline date.DifferenceInISOWeekYears(otherDate: DateTime) : int = ExternalDateFns.differenceInISOWeekYears date otherDate
        /// Return the end of an ISO week-numbering year, which always starts 3 days before the year's first Thursday. The result will be in the local timezone.
        member inline date.EndOfISOWeekYear() : DateTime = ExternalDateFns.endOfISOWeekYear date
        /// Get the ISO week-numbering year of the given date, which always starts 3 days before the year's first Thursday.
        member inline date.GetISOWeekYear() : int = ExternalDateFns.getISOWeekYear date
        /// Are the given dates in the same ISO week-numbering year?
        member inline date.IsSameISOWeekYear(otherDate: DateTime) : bool = ExternalDateFns.isSameISOWeekYear date otherDate
        /// Return the last day of an ISO week-numbering year, which always starts 3 days before the year's first Thursday. The result will be in the local timezone.
        member inline date.LastDayOfISOWeekYear() : DateTime = ExternalDateFns.lastDayOfISOWeekYear date
        /// Set the ISO week-numbering year to the given date, saving the week number and the weekday number.
        member inline date.SetISOWeekYear(isoWeekYear : int) : DateTime = ExternalDateFns.setISOWeekYear date isoWeekYear
        /// Return the start of an ISO week-numbering year, which always starts 3 days before the year's first Thursday. The result will be in the local timezone.
        member inline date.StartOfISOWeekYear() : DateTime = ExternalDateFns.startOfISOWeekYear date
        /// Subtract the specified number of ISO week-numbering years from the given date.
        member inline date.SubISOWeekYears(amount : int) : DateTime = ExternalDateFns.subISOWeekYears date amount