namespace Fable.DateFunctions

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import


[<AutoOpen>]
module CommonHelpers =

    type DateTime with
        /// Returns an index of the closest date from the array comparing to the given date.
        member inline date.ClosestIndexTo(otherDates: DateTime []) : int = ExternalDateFns.closestIndexTo date otherDates
        /// Returns a date from the array closest to the given date.
        member inline date.ClosestTo(otherDates: DateTime []) : DateTime = ExternalDateFns.closestTo date otherDates
        /// Compare the two dates and return 1 if the first date is after the second, -1 if the first date is before the second or 0 if dates are equal.
        member inline date.CompareAsc(other: DateTime) : int = ExternalDateFns.compareAsc date other
        /// Compare the two dates and return -1 if the first date is after the second, 1 if the first date is before the second or 0 if dates are equal.
        member inline date.CompareDesc(other: DateTime) : int = ExternalDateFns.compareDesc date other
        /// Return the distance between the given dates in words.
        member inline date.FormatDistance(other: DateTime) : string = ExternalDateFns.formatDistance date other (obj())
        /// Return the distance between the given dates in words with given options
        member inline date.FormatDistance(other : DateTime, opts: IFormatDistanceOptions) : string = ExternalDateFns.formatDistance date other opts
        /// Return the distance between the given dates in words, using strict units. This is like distanceInWords, but does not use helpers like 'almost', 'over', 'less than' and the like.
        member inline date.FormatDistanceStrict(other: DateTime, opts: IDistanceInWordsStrictOptions) : string = ExternalDateFns.formatDistanceStrict date other opts
        /// Returns the distance between the given date and now in words.
        member inline otherDate.FormatDistanceToNow(opts: IFormatDistanceOptions) : string = ExternalDateFns.formatDistanceToNow otherDate opts
        /// Returns the formatted date string in the given default format:
        /// YYYY-MM-DDTHH:mm:ss.SSSZ.
        member inline date.Format() : string = ExternalDateFns.format date
        /// Return the formatted date string in the given format. See https://date-fns.org/v1.29.0/docs/format for docs
        member inline date.Format(format: string) : string = ExternalDateFns.formatWithStr date format
        /// Return the formatted date string in the given format and locale. See https://date-fns.org/v1.29.0/docs/format for docs
        member inline date.Format(format: string, locale: ILocale) : string =
            let formatOptions = createEmpty<IDateFormatOptions>
            formatOptions.locale <- locale
            ExternalDateFns.formatWithStrAndOptions date format formatOptions

        /// Returns whether the first date is after the second one.
        member inline fstDate.IsAfter(sndDate: DateTime) : bool = ExternalDateFns.isAfter fstDate sndDate
        /// Returns whether the second date is before the first one.
        member inline fstDate.IsBefore(sndDate: DateTime) : bool = ExternalDateFns.isBefore fstDate sndDate
        /// Returns whether the given argument is an instance of DateTime.
        member inline date.IsDate() : bool = ExternalDateFns.isDate date
        /// Returns whether the given dates are equal.
        member inline date.AreEqual(otherDate: DateTime) : bool = ExternalDateFns.isEqual date otherDate
        /// Returns whether the given date is in the future.
        member inline date.IsInTheFuture() : bool = ExternalDateFns.isFuture date
         /// Returns whether the given date is in the past.
        member inline date.IsInThePast() : bool = ExternalDateFns.isPast date
        /// Returns false if argument is Invalid Date and true otherwise. Invalid Date is a Date, whose time value is NaN.
        member inline date.IsValid() : bool = ExternalDateFns.isValid date
        /// Return the latest of the given dates.
        static member inline Max([<ParamArray>] dates: DateTime[]) : DateTime = ExternalDateFns.max dates
        /// Return the earliest of the given dates.
        static member inline Min([<ParamArray>] dates: DateTime[]) : DateTime = ExternalDateFns.min dates
        /// Convert the given argument to an instance of Date.
        /// If the argument is an instance of Date, the function returns its clone.
        /// If the argument is a number, it is treated as a timestamp.
        /// If an argument is a string, the function tries to parse it. Function accepts complete ISO 8601 formats as well as partial implementations. ISO 8601: http://en.wikipedia.org/wiki/ISO_8601
        /// If all above fails, the function passes the given argument to Date constructor.
        static member inline Parse(date: string) : DateTime = ExternalDateFns.parse date
        /// Convert the given argument to an instance of Date.
        /// If the argument is an instance of Date, the function returns its clone.
        /// If the argument is a number, it is treated as a timestamp.
        /// If an argument is a string, the function tries to parse it. Function accepts complete ISO 8601 formats as well as partial implementations. ISO 8601: http://en.wikipedia.org/wiki/ISO_8601
        /// If all above fails, the function passes the given argument to Date constructor.
        static member inline Parse(date: int) : DateTime = ExternalDateFns.parse date
        /// Convert the given argument to an instance of Date.
        /// If the argument is an instance of Date, the function returns its clone.
        /// If the argument is a number, it is treated as a timestamp.
        /// If an argument is a string, the function tries to parse it. Function accepts complete ISO 8601 formats as well as partial implementations. ISO 8601: http://en.wikipedia.org/wiki/ISO_8601
        /// If all above fails, the function passes the given argument to Date constructor.
        static member inline Parse(date: DateTime) : DateTime = ExternalDateFns.parse date
        /// Convert the given argument to an instance of Date.
        /// If the argument is an instance of Date, the function returns its clone.
        /// If the argument is a number, it is treated as a timestamp.
        /// If an argument is a string, the function tries to parse it. Function accepts complete ISO 8601 formats as well as partial implementations. ISO 8601: http://en.wikipedia.org/wiki/ISO_8601
        /// If all above fails, the function passes the given argument to Date constructor.
        static member inline Parse(date: string, opts: ParseOpts) : DateTime = ExternalDateFns.parseWithOpts date opts
        /// Convert the given argument to an instance of Date.
        /// If the argument is an instance of Date, the function returns its clone.
        /// If the argument is a number, it is treated as a timestamp.
        /// If an argument is a string, the function tries to parse it. Function accepts complete ISO 8601 formats as well as partial implementations. ISO 8601: http://en.wikipedia.org/wiki/ISO_8601
        /// If all above fails, the function passes the given argument to Date constructor.
        static member inline Parse(date: DateTime, opts: ParseOpts) : DateTime = ExternalDateFns.parseWithOpts date opts
        /// Convert the given argument to an instance of Date.
        /// If the argument is an instance of Date, the function returns its clone.
        /// If the argument is a number, it is treated as a timestamp.
        /// If an argument is a string, the function tries to parse it. Function accepts complete ISO 8601 formats as well as partial implementations. ISO 8601: http://en.wikipedia.org/wiki/ISO_8601
        /// If all above fails, the function passes the given argument to Date constructor.
        static member inline Parse(date: int, opts: ParseOpts) : DateTime = ExternalDateFns.parseWithOpts date opts
        [<Emit "Intl.DateTimeFormat().resolvedOptions().timeZone">]
        /// Returns the current timezone of the application
        static member inline CurrentTimezone() : string = jsNative

[<AutoOpen>]
module CommonHelpersDateTimeOffset =

    type DateTimeOffset with
        /// Returns an index of the closest date from the array comparing to the given date.
        member inline date.ClosestIndexTo(otherDates: DateTimeOffset []) : int = ExternalDateFns.closestIndexTo date otherDates
        /// Returns a date from the array closest to the given date.
        member inline date.ClosestTo(otherDates: DateTimeOffset []) : DateTimeOffset = ExternalDateFns.closestTo date otherDates
        /// Compare the two dates and return 1 if the first date is after the second, -1 if the first date is before the second or 0 if dates are equal.
        member inline date.CompareAsc(other: DateTimeOffset) : int = ExternalDateFns.compareAsc date other
        /// Compare the two dates and return -1 if the first date is after the second, 1 if the first date is before the second or 0 if dates are equal.
        member inline date.CompareDesc(other: DateTimeOffset) : int = ExternalDateFns.compareDesc date other
        /// Return the distance between the given dates in words.
        member inline date.FormatDistance(other: DateTimeOffset) : string = ExternalDateFns.formatDistance date other (obj())
        /// Return the distance between the given dates in words with given options
        member inline date.FormatDistance(other : DateTimeOffset, opts: IFormatDistanceOptions) : string = ExternalDateFns.formatDistance date other opts
        /// Return the distance between the given dates in words, using strict units. This is like distanceInWords, but does not use helpers like 'almost', 'over', 'less than' and the like.
        member inline date.FormatDistanceStrict(other: DateTimeOffset, opts: IDistanceInWordsStrictOptions) : string = ExternalDateFns.formatDistanceStrict date other opts
        /// Returns the distance between the given date and now in words.
        member inline otherDate.FormatDistanceToNow(opts: IFormatDistanceOptions) : string = ExternalDateFns.formatDistanceToNow otherDate opts
        /// Returns the formatted date string in the given default format:
        /// YYYY-MM-DDTHH:mm:ss.SSSZ.
        member inline date.Format() : string = ExternalDateFns.format date
        /// Return the formatted date string in the given format. See https://date-fns.org/v1.29.0/docs/format for docs
        member inline date.Format(format: string) : string = ExternalDateFns.formatWithStr date format
        /// Return the formatted date string in the given format and locale. See https://date-fns.org/v1.29.0/docs/format for docs
        member inline date.Format(format: string, locale: ILocale) : string =
            let formatOptions = createEmpty<IDateFormatOptions>
            formatOptions.locale <- locale
            ExternalDateFns.formatWithStrAndOptions date format formatOptions

        /// Returns whether the first date is after the second one.
        member inline fstDate.IsAfter(sndDate: DateTimeOffset) : bool = ExternalDateFns.isAfter fstDate sndDate
        /// Returns whether the second date is before the first one.
        member inline fstDate.IsBefore(sndDate: DateTimeOffset) : bool = ExternalDateFns.isBefore fstDate sndDate
        /// Returns whether the given argument is an instance of DateTime.
        member inline date.IsDate() : bool = ExternalDateFns.isDate date
        /// Returns whether the given dates are equal.
        member inline date.AreEqual(otherDate: DateTimeOffset) : bool = ExternalDateFns.isEqual date otherDate
        /// Returns whether the given date is in the future.
        member inline date.IsInTheFuture() : bool = ExternalDateFns.isFuture date
         /// Returns whether the given date is in the past.
        member inline date.IsInThePast() : bool = ExternalDateFns.isPast date
        /// Returns false if argument is Invalid Date and true otherwise. Invalid Date is a Date, whose time value is NaN.
        member inline date.IsValid() : bool = ExternalDateFns.isValid date
        /// Return the latest of the given dates.
        static member inline Max([<ParamArray>] dates: DateTimeOffset[]) : DateTimeOffset = ExternalDateFns.max dates
        /// Return the earliest of the given dates.
        static member inline Min([<ParamArray>] dates: DateTimeOffset[]) : DateTimeOffset = ExternalDateFns.min dates
        /// Convert the given argument to an instance of Date.
        /// If the argument is an instance of Date, the function returns its clone.
        /// If the argument is a number, it is treated as a timestamp.
        /// If an argument is a string, the function tries to parse it. Function accepts complete ISO 8601 formats as well as partial implementations. ISO 8601: http://en.wikipedia.org/wiki/ISO_8601
        /// If all above fails, the function passes the given argument to Date constructor.
        static member inline Parse(date: string) : DateTimeOffset = ExternalDateFns.parse date
        /// Convert the given argument to an instance of Date.
        /// If the argument is an instance of Date, the function returns its clone.
        /// If the argument is a number, it is treated as a timestamp.
        /// If an argument is a string, the function tries to parse it. Function accepts complete ISO 8601 formats as well as partial implementations. ISO 8601: http://en.wikipedia.org/wiki/ISO_8601
        /// If all above fails, the function passes the given argument to Date constructor.
        static member inline Parse(date: int) : DateTimeOffset = ExternalDateFns.parse date
        /// Convert the given argument to an instance of Date.
        /// If the argument is an instance of Date, the function returns its clone.
        /// If the argument is a number, it is treated as a timestamp.
        /// If an argument is a string, the function tries to parse it. Function accepts complete ISO 8601 formats as well as partial implementations. ISO 8601: http://en.wikipedia.org/wiki/ISO_8601
        /// If all above fails, the function passes the given argument to Date constructor.
        static member inline Parse(date: DateTimeOffset) : DateTimeOffset = ExternalDateFns.parse date
        /// Convert the given argument to an instance of Date.
        /// If the argument is an instance of Date, the function returns its clone.
        /// If the argument is a number, it is treated as a timestamp.
        /// If an argument is a string, the function tries to parse it. Function accepts complete ISO 8601 formats as well as partial implementations. ISO 8601: http://en.wikipedia.org/wiki/ISO_8601
        /// If all above fails, the function passes the given argument to Date constructor.
        static member inline Parse(date: string, opts: ParseOpts) : DateTimeOffset = ExternalDateFns.parseWithOpts date opts
        /// Convert the given argument to an instance of Date.
        /// If the argument is an instance of Date, the function returns its clone.
        /// If the argument is a number, it is treated as a timestamp.
        /// If an argument is a string, the function tries to parse it. Function accepts complete ISO 8601 formats as well as partial implementations. ISO 8601: http://en.wikipedia.org/wiki/ISO_8601
        /// If all above fails, the function passes the given argument to Date constructor.
        static member inline Parse(date: DateTimeOffset, opts: ParseOpts) : DateTimeOffset = ExternalDateFns.parseWithOpts date opts
        /// Convert the given argument to an instance of Date.
        /// If the argument is an instance of Date, the function returns its clone.
        /// If the argument is a number, it is treated as a timestamp.
        /// If an argument is a string, the function tries to parse it. Function accepts complete ISO 8601 formats as well as partial implementations. ISO 8601: http://en.wikipedia.org/wiki/ISO_8601
        /// If all above fails, the function passes the given argument to Date constructor.
        static member inline Parse(date: int, opts: ParseOpts) : DateTimeOffset = ExternalDateFns.parseWithOpts date opts
        [<Emit "Intl.DateTimeFormat().resolvedOptions().timeZone">]
        /// Returns the current timezone of the application
        static member inline CurrentTimezone() : string = jsNative
