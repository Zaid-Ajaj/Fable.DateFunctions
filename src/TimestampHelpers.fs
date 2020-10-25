namespace Fable.DateFunctions

open System

[<AutoOpen>]
module TimestampHelpers =
    type DateTime with
        /// Returns the milliseconds timestamp of the given date.
        member inline date.GetMilliseconds() : int = ExternalDateFns.getTime date

[<AutoOpen>]
module TimestampHelpersDateTimeOffset =
    type DateTimeOffset with
        /// Returns the milliseconds timestamp of the given date.
        member inline date.GetMilliseconds() : int = ExternalDateFns.getTime date