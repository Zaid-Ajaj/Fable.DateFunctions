namespace Fable.DateFunctions

open System

[<AutoOpen>]
module TimestampHelpers = 
    type DateTime with 
        /// Returns the milliseconds timestamp of the given date.
        member date.GetMilliseconds() : int = ExternalDateFns.getTime date