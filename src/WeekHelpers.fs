namespace Fable.DateFunctions

open System
open Fable.Core.JsInterop

[<AutoOpen>]
module WeekHelpers =
    type DateTime with
        /// Add the specified number of week to the given date.
        member inline date.AddWeeks(numberOfWeeks: int): DateTime = ExternalDateFns.addWeeks date numberOfWeeks
        /// Gets the number of calendar weeks between the given dates.
        member inline date.DifferenceInCalendarWeeks(otherDate: DateTime): int =
            ExternalDateFns.differenceInCalendarWeeks date otherDate
        /// Get the number of full weeks between the given dates.
        member inline date.DifferenceInWeeks(otherDate: DateTime): int =
            ExternalDateFns.differenceInWeeks date otherDate
        /// Return the end of a week for the given date. The result will be in the local timezone.
        member inline date.EndOfWeek(): DateTime = ExternalDateFns.endOfWeek date
        member inline date.IsInTheSameWeekAs(otherDate: DateTime): bool = ExternalDateFns.isSameWeek date otherDate
        member inline date.IsInThisWeek(): bool = ExternalDateFns.isThisWeek date
        /// Returns the DateTime of the last day of the week of the current instance of DateTime
        member inline date.LastDayOfWeek(): DateTime = ExternalDateFns.lastDayOfWeek date
        /// Returns the DateTime of the first day of the week of the current instance of DateTime
        member inline date.StartOfWeek(): DateTime = ExternalDateFns.startOfWeek date
        /// Returns the DateTime of the first day of the week of the current instance of DateTime
        member inline date.StartOfWeek(locale: ILocale): DateTime =
            ExternalDateFns.startOfWeekWithOptions date (createObj [
                "options" ==> createObj [
                    "locale" ==> locale
                ]
            ])

        /// Same as `{DateTime}.AddWeeks(-1).StartOfWeek().StartOfDay()`
        member inline date.StartOfPreviousWeek() : DateTime = date.AddWeeks(-1).StartOfWeek().StartOfDay()
        /// Same as `{DateTime}.AddWeeks(-1).StartOfWeek().StartOfDay()`
        member inline date.StartOfPreviousWeek(locale: ILocale) : DateTime = date.AddWeeks(-1).StartOfWeek(locale).StartOfDay()
        /// Same as `{DateTime}.AddWeeks(-1).EndOfWeek().EndOfDay()`
        member inline date.EndOfPreviousWeek() : DateTime = date.AddWeeks(-1).EndOfWeek().EndOfDay()
        /// Same as `{DateTime}.AddWeeks(1).StartOfWeek().StartOfDay()`
        member inline date.StartOfNextWeek() : DateTime = date.AddWeeks(1).StartOfWeek().StartOfDay()
        /// Same as `{DateTime}.AddWeeks(1).StartOfWeek().StartOfDay()`
        member inline date.StartOfNextWeek(locale: ILocale) : DateTime = date.AddWeeks(1).StartOfWeek(locale).StartOfDay()
        /// Same as `{DateTime}.AddWeeks(1).EndOfWeek().EndOfDay()`
        member inline date.EndOfNextWeek() : DateTime = date.AddWeeks(1).EndOfWeek().EndOfDay()
        member inline date.SubtractWeeks(n: int): DateTime = ExternalDateFns.subWeeks date n

[<AutoOpen>]
module WeekHelpersDateTimeOffset =
    type DateTimeOffset with
        /// Add the specified number of week to the given date.
        member inline date.AddWeeks(numberOfWeeks: int): DateTimeOffset = DateTimeOffset(ExternalDateFns.addWeeks date numberOfWeeks)
        /// Gets the number of calendar weeks between the given dates.
        member inline date.DifferenceInCalendarWeeks(otherDate: DateTimeOffset): int = ExternalDateFns.differenceInCalendarWeeks date otherDate
        /// Get the number of full weeks between the given dates.
        member inline date.DifferenceInWeeks(otherDate: DateTimeOffset): int = ExternalDateFns.differenceInWeeks date otherDate
        /// Return the end of a week for the given date. The result will be in the local timezone.
        member inline date.EndOfWeek(): DateTimeOffset = DateTimeOffset(ExternalDateFns.endOfWeek date)
        member inline date.IsInTheSameWeekAs(otherDate: DateTimeOffset): bool = ExternalDateFns.isSameWeek date otherDate
        member inline date.IsInThisWeek(): bool = ExternalDateFns.isThisWeek date
        /// Returns the DateTime of the last day of the week of the current instance of DateTime
        member inline date.LastDayOfWeek(): DateTimeOffset = DateTimeOffset(ExternalDateFns.lastDayOfWeek date)
        /// Returns the DateTime of the first day of the week of the current instance of DateTime
        member inline date.StartOfWeek(): DateTimeOffset = DateTimeOffset(ExternalDateFns.startOfWeek date)
        /// Returns the DateTime of the first day of the week of the current instance of DateTime
        member inline date.StartOfWeek(locale: ILocale): DateTimeOffset =
            DateTimeOffset(ExternalDateFns.startOfWeekWithOptions date (createObj [
                "options" ==> createObj [
                    "locale" ==> locale
                ]
            ]))
        /// Same as `{DateTime}.AddWeeks(-1).StartOfWeek().StartOfDay()`
        member inline date.StartOfPreviousWeek() : DateTimeOffset = date.AddWeeks(-1).StartOfWeek().StartOfDay()
        /// Same as `{DateTime}.AddWeeks(-1).StartOfWeek().StartOfDay()`
        member inline date.StartOfPreviousWeek(locale: ILocale) : DateTimeOffset = date.AddWeeks(-1).StartOfWeek(locale).StartOfDay()
        /// Same as `{DateTime}.AddWeeks(-1).EndOfWeek().EndOfDay()`
        member inline date.EndOfPreviousWeek() : DateTimeOffset = date.AddWeeks(-1).EndOfWeek().EndOfDay()
        /// Same as `{DateTime}.AddWeeks(1).StartOfWeek().StartOfDay()`
        member inline date.StartOfNextWeek() : DateTimeOffset = date.AddWeeks(1).StartOfWeek().StartOfDay()
        /// Same as `{DateTime}.AddWeeks(1).StartOfWeek().StartOfDay()`
        member inline date.StartOfNextWeek(locale: ILocale) : DateTimeOffset = date.AddWeeks(1).StartOfWeek(locale).StartOfDay()
        /// Same as `{DateTime}.AddWeeks(1).EndOfWeek().EndOfDay()`
        member inline date.EndOfNextWeek() : DateTimeOffset = date.AddWeeks(1).EndOfWeek().EndOfDay()
        member inline date.SubtractWeeks(n: int): DateTimeOffset = DateTimeOffset(ExternalDateFns.subWeeks date n)