namespace Fable.DateFunctions

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import


[<AutoOpen>]
module RangeHelpers =
    type DateFns with
        /// Returns whether or not the given ranges overlap
        static member AreRangesOverlapping(initRangeStartDate: DateTime, initRangeEndDate: DateTime, comparedRangeStart: DateTime, comparedRangeEnd: DateTime) : bool = ExternalDateFns.areRangesOverlapping initRangeStartDate initRangeEndDate comparedRangeStart comparedRangeEnd
        /// Returns the number of days that overlap in two date ranges
        static member GetOverlappingDaysInRanges(initRangeStartDate: DateTime, initRangeEndDate: DateTime, comparedRangeStart: DateTime, comparedRangeEnd: DateTime) : int = ExternalDateFns.getOverlappingDaysInRanges initRangeStartDate initRangeEndDate comparedRangeStart comparedRangeEnd
        /// Returns whether the first argument is within the range of the second and third argument.
        static member IsWithinRange(date: DateTime, startDate: DateTime, endDate: DateTime) : bool = ExternalDateFns.isWithinRange date startDate endDate       