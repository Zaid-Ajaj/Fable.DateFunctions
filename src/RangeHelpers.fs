namespace Fable.DateFunctions

open System

[<AutoOpen>]
module RangeHelpers =
    type DateTime with
        /// Returns whether or not the given ranges overlap
        static member inline AreRangesOverlapping(initRangeStartDate: DateTime, initRangeEndDate: DateTime, comparedRangeStart: DateTime, comparedRangeEnd: DateTime) : bool = ExternalDateFns.areRangesOverlapping initRangeStartDate initRangeEndDate comparedRangeStart comparedRangeEnd
        /// Returns the number of days that overlap in two date ranges
        static member inline GetOverlappingDaysInRanges(initRangeStartDate: DateTime, initRangeEndDate: DateTime, comparedRangeStart: DateTime, comparedRangeEnd: DateTime) : int = ExternalDateFns.getOverlappingDaysInRanges initRangeStartDate initRangeEndDate comparedRangeStart comparedRangeEnd
        /// Returns whether the first argument is within the range of the second and third argument.
        member inline date.IsBetween(startDate: DateTime, endDate: DateTime) : bool = ExternalDateFns.isWithinRange date startDate endDate
