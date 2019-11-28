namespace Fable.DateFunctions

open System

[<AutoOpen>]
module QuarterHelpers =
    type DateTime with
        /// Add the specified number of year quarter to the given date.
        member inline date.AddQuarters(numberOfQuarters: int) : DateTime = ExternalDateFns.addQuarters date numberOfQuarters
        /// Gets the number of calendar year quarters between the given dates.
        member inline date.DifferenceInCalendarQuarters(otherDate: DateTime): int =
            ExternalDateFns.differenceInCalendarQuarters date otherDate
        /// Get the number of full year quarters between the given dates.
        member inline date.DifferenceInQuarters(otherDate: DateTime): int =
            ExternalDateFns.differenceInQuarters date otherDate
        /// Return the end of a year quarter for the given date. The result will be in the local timezone.
        member inline date.EndOfQuarter(): DateTime = ExternalDateFns.endOfQuarter date
        /// Get the year quarter of the given date
        member inline date.GetQuarter(): int = ExternalDateFns.getQuarter date
        /// Are the given dates in the same year quarter?
        member inline date.IsInTheSameQuarterAs(otherDate: DateTime): bool =
            ExternalDateFns.isSameQuarter date otherDate
        /// Set the year quarter to the given date
        member inline date.SetQuarter(quarters: int): DateTime = ExternalDateFns.setQuarter date quarters
        /// Is this given date in the same year quarter as the current date?
        member inline date.IsInThisQuarter(): bool = ExternalDateFns.isThisQuarter date
        /// Returns the DateTime of the last day of the year quarter of the current instance of `DateTime`
        member inline date.LastDayOfQuarter(): DateTime = ExternalDateFns.lastDayOfQuarter date
        /// Returns the DateTime of the first day of the year quarter of the current instance of `DateTime`
        member inline date.StartOfQuarter(): DateTime = ExternalDateFns.startOfQuarter date
        /// Subtract the specified number of year quarters from the given date.
        member inline date.SubtractQuarters(n: int): DateTime = ExternalDateFns.subQuarters date n
        /// Returns the start of day of the previous quarter relative to the quarter of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddQuarters(-1).StartOfQuarter().StartOfDay()`
        member inline date.StartOfPreviousQuarter() : DateTime = date.AddQuarters(-1).StartOfQuarter().StartOfDay()
        /// Returns the end of day of the previous quarter relative to the quarter of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddQuarters(-1).EndOfQuarter().EndOfDay()`
        member inline date.EndOfPreviousQuarter() : DateTime = date.AddQuarters(-1).EndOfQuarter().EndOfDay()
        /// Returns the start of day of the next quarter relative to the quarter of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddQuarters(-1).EndOfQuarter().EndOfDay()`
        member inline date.StartOfNextQuarter() : DateTime = date.AddQuarters(1).StartOfQuarter().StartOfDay()
        /// Returns the end of day of the next quarter relative to the quarter of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddQuarters(1).EndOfQuarter().EndOfDay()`
        member inline date.EndOfNextQuarter() : DateTime = date.AddQuarters(1).EndOfQuarter().EndOfDay()