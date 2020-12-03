namespace Fable.DateFunctions

open System

[<AutoOpen>]
module RangeHelpers =
    type DateTime with
        /// Returns whether or not the given ranges overlap
        static member inline AreRangesOverlapping(initRangeStartDate: DateTime, initRangeEndDate: DateTime, comparedRangeStart: DateTime, comparedRangeEnd: DateTime) : bool =
            ExternalDateFns.areIntervalsOverlapping {| start=initRangeStartDate;``end``= initRangeEndDate |} {| start= comparedRangeStart; ``end``= comparedRangeEnd |}
        /// Returns the number of days that overlap in two date ranges
        static member inline GetOverlappingDaysInRanges(initRangeStartDate: DateTime, initRangeEndDate: DateTime, comparedRangeStart: DateTime, comparedRangeEnd: DateTime) : int =
            ExternalDateFns.getOverlappingDaysInIntervals {| start=initRangeStartDate;``end``= initRangeEndDate |} {| start=comparedRangeStart; ``end``= comparedRangeEnd |}
        /// Returns whether the first argument is within the range of the second and third argument.
        member inline date.IsBetween(startDate: DateTime, endDate: DateTime) : bool =
            ExternalDateFns.isWithinInterval date {| start = startDate; ``end`` = endDate |}

[<AutoOpen>]
module RangeHelpersDateTimeOffset =
    type DateTimeOffset with
        /// Returns whether or not the given ranges overlap
        static member inline AreRangesOverlapping(initRangeStartDate: DateTimeOffset, initRangeEndDate: DateTimeOffset, comparedRangeStart: DateTimeOffset, comparedRangeEnd: DateTimeOffset) : bool =
            ExternalDateFns.areIntervalsOverlapping {| start=initRangeStartDate;``end``= initRangeEndDate |} {| start= comparedRangeStart; ``end``= comparedRangeEnd |}
        /// Returns the number of days that overlap in two date ranges
        static member inline GetOverlappingDaysInRanges(initRangeStartDate: DateTimeOffset, initRangeEndDate: DateTimeOffset, comparedRangeStart: DateTimeOffset, comparedRangeEnd: DateTimeOffset) : int =
            ExternalDateFns.getOverlappingDaysInIntervals {| start=initRangeStartDate;``end``= initRangeEndDate |} {| start=comparedRangeStart; ``end``= comparedRangeEnd  |}
        /// Returns whether the first argument is within the range of the second and third argument.
        member inline date.IsBetween(startDate: DateTimeOffset, endDate: DateTimeOffset) : bool =
            ExternalDateFns.isWithinInterval date {| start = startDate; ``end`` = endDate |}