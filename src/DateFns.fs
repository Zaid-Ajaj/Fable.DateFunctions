namespace Fable.DateFunctions

open Fable.Core.JsInterop
open Fable.Core

type ILocale =
    interface
    end

[<StringEnum>]
type PartialMethod =
    | Floor
    | Ceiling
    | Round

[<StringEnum>]
type TimeUnit =
    | [<CompiledName("s")>] Second
    | [<CompiledName("m")>] Minute
    | [<CompiledName("h")>] Hour
    | [<CompiledName("d")>] Day
    | [<CompiledName("M")>] Month
    | [<CompiledName("Q")>] Quarter
    | [<CompiledName("Y")>] Year

type Months =
    | January = 0
    | February = 1
    | March = 2
    | April = 3
    | May = 4
    | June = 5
    | July = 6
    | August = 7
    | September = 8
    | October = 9
    | November = 10
    | December = 11

type IFormatDistanceOptions =
    /// distances less than a minute are more detailed
    abstract includeSeconds: bool with get, set
    /// result indicates if the second date is earlier or later than the first
    abstract addSuffix: bool with get, set
    /// the locale object
    abstract locale: ILocale with get, set

type IDistanceInWordsStrictOptions =
    /// Result indicates if the second date is earlier or later than the first
    abstract addSuffix: bool with get, set
    /// if specified, will force a unit
    abstract unit: TimeUnit with get, set
    /// which way to round partial units
    abstract partialMethod: PartialMethod with get, set
    /// the locale object
    abstract locale: ILocale with get, set

type IDateFormatOptions =
    /// the locale object
    abstract locale: ILocale with get, set

type ParseOpts =
    /// the additional number of digits in the extended year format.
    abstract additionalDigits: int with get, set

type Interval = {| start: obj; ``end``: obj |}

module ExternalDateFns =
    [<Import("closestIndexTo", "date-fns")>]
    let inline closestIndexTo (d: obj) (other: obj) = jsNative
    [<Import("closestTo", "date-fns")>]
    let closestTo (date: obj) (other: obj) = jsNative
    [<Import("compareAsc", "date-fns")>]
    let compareAsc (date: obj) (other: obj) = jsNative
    [<Import("compareDesc", "date-fns")>]
    let compareDesc (date: obj) (other: obj) = jsNative
    [<Import("formatDistance", "date-fns")>]
    let formatDistance (date: obj) (other: obj) (options: obj) = jsNative
    [<Import("formatDistanceStrict", "date-fns")>]
    let formatDistanceStrict (date: obj) (other: obj) (opts: obj) = jsNative
    [<Import("formatDistanceToNow", "date-fns")>]
    let formatDistanceToNow (date: obj) (opts: obj) = jsNative
    [<Import("format", "date-fns")>]
    let format (date: obj) = jsNative
    [<Import("format", "date-fns")>]
    let formatWithStr (date: obj) (format: string) = jsNative
    [<Import("format", "date-fns")>]
    let formatWithStrAndOptions (date: obj) (format: string) (opts: obj) = jsNative
    [<Import("isAfter", "date-fns")>]
    let isAfter (date: obj) (other: obj) = jsNative
    [<Import("isBefore", "date-fns")>]
    let isBefore (date: obj) (other: obj) = jsNative
    [<Import("isDate", "date-fns")>]
    let isDate (object: obj) = jsNative
    [<Import("isEqual", "date-fns")>]
    let isEqual (date: obj) (other: obj) = jsNative
    [<Import("isFuture", "date-fns")>]
    let isFuture (date: obj) = jsNative
    [<Import("isPast", "date-fns")>]
    let isPast (date: obj) = jsNative
    [<Import("isValid", "date-fns")>]
    let isValid (date: obj) = jsNative
    [<Import("max", "date-fns")>]
    let max (dates: obj) = jsNative
    [<Import("min", "date-fns")>]
    let min (dates: obj) = jsNative
    [<Import("parse", "date-fns")>]
    let parse (input: obj) = jsNative
    [<Import("parse", "date-fns")>]
    let parseWithOpts (input: obj) (opts: obj) = jsNative
    [<Import("areIntervalsOverlapping", "date-fns")>]
    let areIntervalsOverlapping (i1: Interval) (i2: Interval) = jsNative
    [<Import("getOverlappingDaysInIntervals", "date-fns")>]
    let getOverlappingDaysInIntervals (i1: Interval) (i2: Interval) =
        jsNative
    [<Import("isWithinInterval", "date-fns")>]
    let isWithinInterval (d1: obj) (d2: Interval) = jsNative
    [<Import("isWithinInterval", "date-fns")>]
    let getTime (d: obj) = jsNative
    [<Import("addMilliseconds", "date-fns")>]
    let addMilliseconds (d: obj) (a: obj) = jsNative
    [<Import("differenceInMilliseconds", "date-fns")>]
    let differenceInMilliseconds (a: obj) (b: obj) = jsNative
    [<Import("getMilliseconds", "date-fns")>]
    let getMilliseconds (a: obj) = jsNative
    [<Import("setMilliseconds", "date-fns")>]
    let setMilliseconds (a: obj) (b: obj) = jsNative
    [<Import("subMilliseconds", "date-fns")>]
    let subMilliseconds (a: obj) (b: obj) = jsNative
    [<Import("addSeconds", "date-fns")>]
    let addSeconds a b = jsNative
    [<Import("differenceInSeconds", "date-fns")>]
    let differenceInSeconds a b = jsNative
    [<Import("endOfSecond", "date-fns")>]
    let endOfSecond a = jsNative
    [<Import("getSeconds", "date-fns")>]
    let getSeconds a = jsNative
    [<Import("isSameSecond", "date-fns")>]
    let isSameSecond a b = jsNative
    [<Import("isThisSecond", "date-fns")>]
    let isThisSecond a = jsNative
    [<Import("setSeconds", "date-fns")>]
    let setSeconds a b = jsNative
    [<Import("startOfSecond", "date-fns")>]
    let startOfSecond a = jsNative
    [<Import("closessubSecondstIndexTo", "date-fns")>]
    let subSeconds a b = jsNative
    [<Import("addMinutes", "date-fns")>]
    let addMinutes a b = jsNative
    [<Import("differenceInMinutes", "date-fns")>]
    let differenceInMinutes a b = jsNative
    [<Import("endOfMinute", "date-fns")>]
    let endOfMinute a = jsNative
    [<Import("getMinutes", "date-fns")>]
    let getMinutes a = jsNative
    [<Import("isSameMinute", "date-fns")>]
    let isSameMinute a b = jsNative
    [<Import("isThisMinute", "date-fns")>]
    let isThisMinute a = jsNative
    [<Import("setMinutes", "date-fns")>]
    let setMinutes a b = jsNative
    [<Import("startOfMinute", "date-fns")>]
    let startOfMinute a = jsNative
    [<Import("subMinutes", "date-fns")>]
    let subMinutes a b = jsNative
    [<Import("addHours", "date-fns")>]
    let addHours a b = jsNative
    [<Import("differenceInHours", "date-fns")>]
    let differenceInHours a b = jsNative
    [<Import("endOfHour", "date-fns")>]
    let endOfHour a = jsNative
    [<Import("getHours", "date-fns")>]
    let getHours a = jsNative
    [<Import("isSameHour", "date-fns")>]
    let isSameHour a b = jsNative
    [<Import("isThisHour", "date-fns")>]
    let isThisHour a = jsNative
    [<Import("setHours", "date-fns")>]
    let setHours a b = jsNative
    [<Import("startOfHour", "date-fns")>]
    let startOfHour a = jsNative
    [<Import("subHours", "date-fns")>]
    let subHours a b = jsNative
    [<Import("addDays", "date-fns")>]
    let addDays a b = jsNative
    [<Import("differenceInCalendarDays", "date-fns")>]
    let differenceInCalendarDays a b = jsNative
    [<Import("differenceInDays", "date-fns")>]
    let differenceInDays a b = jsNative
    [<Import("eachDayOfInterval", "date-fns")>]
    let eachDayOfInterval (a: Interval) = jsNative
    [<Import("endOfDay", "date-fns")>]
    let endOfDay a = jsNative
    [<Import("endOfToday", "date-fns")>]
    let endOfToday(): System.DateTime = jsNative
    [<Import("endOfTomorrow", "date-fns")>]
    let endOfTomorrow(): System.DateTime = jsNative
    [<Import("endOfYesterday", "date-fns")>]
    let endOfYesterday(): System.DateTime = jsNative
    [<Import("getDate", "date-fns")>]
    let getDate a = jsNative
    [<Import("getDayOfYear", "date-fns")>]
    let getDayOfYear a = jsNative
    [<Import("isSameDay", "date-fns")>]
    let isSameDay a b = jsNative
    [<Import("isToday", "date-fns")>]
    let isToday (a: obj) = jsNative
    [<Import("isTomorrow", "date-fns")>]
    let isTomorrow a = jsNative
    [<Import("isYesterday", "date-fns")>]
    let isYesterday a = jsNative
    [<Import("setDate", "date-fns")>]
    let setDate a b = jsNative
    [<Import("setDayOfYear", "date-fns")>]
    let setDayOfyear a b = jsNative
    [<Import("startOfDay", "date-fns")>]
    let startOfDay a = jsNative
    [<Import("startOfToday", "date-fns")>]
    let startOfToday(): System.DateTime = jsNative
    [<Import("startOfTomorrow", "date-fns")>]
    let startOfTomorrow(): System.DateTime = jsNative
    [<Import("startOfYesterday", "date-fns")>]
    let startOfYesterday(): System.DateTime = jsNative
    [<Import("subDays", "date-fns")>]
    let subDays a b = jsNative
    [<Import("getDay", "date-fns")>]
    let getDay a = jsNative
    [<Import("getISODay", "date-fns")>]
    let getISODay a = jsNative
    [<Import("isFriday", "date-fns")>]
    let isFriday a = jsNative
    [<Import("isMonday", "date-fns")>]
    let isMonday a = jsNative
    [<Import("isSaturday", "date-fns")>]
    let isSaturday a = jsNative
    [<Import("isSunday", "date-fns")>]
    let isSunday a = jsNative
    [<Import("isThursday", "date-fns")>]
    let isThursday a = jsNative
    [<Import("isTuesday", "date-fns")>]
    let isTuesday a = jsNative
    [<Import("isWednesday", "date-fns")>]
    let isWednesday a = jsNative
    [<Import("isWeekend", "date-fns")>]
    let isWeekend a = jsNative
    [<Import("addWeeks", "date-fns")>]
    let addWeeks x y = jsNative
    [<Import("differenceInCalendarWeeks", "date-fns")>]
    let differenceInCalendarWeeks x y = jsNative
    [<Import("differenceInWeeks", "date-fns")>]
    let differenceInWeeks x y = jsNative
    [<Import("endOfWeek", "date-fns")>]
    let endOfWeek x = jsNative
    [<Import("isSameWeek", "date-fns")>]
    let isSameWeek x y = jsNative
    [<Import("isThisWeek", "date-fns")>]
    let isThisWeek x = jsNative
    [<Import("lastDayOfWeek", "date-fns")>]
    let lastDayOfWeek x = jsNative
    [<Import("startOfWeek", "date-fns")>]
    let startOfWeek x = jsNative
    [<Import("startOfWeek", "date-fns")>]
    let startOfWeekWithOptions (x: obj) (y: obj) = jsNative
    [<Import("subWeeks", "date-fns")>]
    let subWeeks x y = jsNative
    [<Import("differenceInCalendarISOWeeks", "date-fns")>]
    let differenceInCalendarISOWeeks x y = jsNative
    [<Import("endOfISOWeek", "date-fns")>]
    let endOfIsoWeek x = jsNative
    [<Import("isSameISOWeek", "date-fns")>]
    let isSameIsoWeek x y = jsNative
    [<Import("isThisISOWeek", "date-fns")>]
    let isThisIsoWeek x = jsNative
    [<Import("getISOWeek", "date-fns")>]
    let getISOWeek x = jsNative
    [<Import("lastDayOfISOWeek", "date-fns")>]
    let lastDayOfIsoWeek x = jsNative
    [<Import("startOfISOWeek", "date-fns")>]
    let startOfIsoWeek x = jsNative
    [<Import("setISOWeek", "date-fns")>]
    let setIsoWeek x y = jsNative
    [<Import("addMonths", "date-fns")>]
    let addMonths x y = jsNative
    [<Import("differenceInCalendarMonths", "date-fns")>]
    let differenceInCalendarMonths x y = jsNative
    [<Import("differenceInMonths", "date-fns")>]
    let differenceInMonths x y = jsNative
    [<Import("endOfMonth", "date-fns")>]
    let endOfMonth x = jsNative
    [<Import("getDaysInMonth", "date-fns")>]
    let getDaysInMonth x = jsNative
    [<Import("closestIndexTo", "date-fns")>]
    let getMonth x = jsNative
    [<Import("isFirstDayOfMonth", "date-fns")>]
    let isFirstDayOfMonth x = jsNative
    [<Import("isLastDayOfMonth", "date-fns")>]
    let isLastDayOfMonth x = jsNative
    [<Import("isSameMonth", "date-fns")>]
    let isSameMonth x y = jsNative
    [<Import("isThisMonth", "date-fns")>]
    let isThisMonth x = jsNative
    [<Import("setMonth", "date-fns")>]
    let setMonth x y = jsNative
    [<Import("startOfMonth", "date-fns")>]
    let startOfMonth x = jsNative
    [<Import("subMonths", "date-fns")>]
    let subMonths x y = jsNative
    [<Import("addQuarters", "date-fns")>]
    let addQuarters x y = jsNative
    [<Import("differenceInCalendarQuarters", "date-fns")>]
    let differenceInCalendarQuarters x y = jsNative
    [<Import("differenceInQuarters", "date-fns")>]
    let differenceInQuarters x y = jsNative
    [<Import("endOfQuarter", "date-fns")>]
    let endOfQuarter x = jsNative
    [<Import("getQuarter", "date-fns")>]
    let getQuarter x = jsNative
    [<Import("isSameQuarter", "date-fns")>]
    let isSameQuarter x y = jsNative
    [<Import("isThisQuarter", "date-fns")>]
    let isThisQuarter x = jsNative
    [<Import("setQuarter", "date-fns")>]
    let setQuarter x y = jsNative
    [<Import("lastDayOfQuarter", "date-fns")>]
    let lastDayOfQuarter x = jsNative
    [<Import("startOfQuarter", "date-fns")>]
    let startOfQuarter x = jsNative
    [<Import("subQuarters", "date-fns")>]
    let subQuarters x y = jsNative
    [<Import("addYears", "date-fns")>]
    let addYears x y = jsNative
    [<Import("subYears", "date-fns")>]
    let subYears x y = jsNative
    [<Import("differenceInCalendarYears", "date-fns")>]
    let differenceInCalendarYears x y = jsNative
    [<Import("differenceInYears", "date-fns")>]
    let differenceInYears x y = jsNative
    [<Import("endOfYear", "date-fns")>]
    let endOfYear x = jsNative
    [<Import("getDaysInYear", "date-fns")>]
    let daysInYear x = jsNative
    [<Import("isLeapYear", "date-fns")>]
    let isLeapYear x = jsNative
    [<Import("isSameYear", "date-fns")>]
    let isSameYear x y = jsNative
    [<Import("isThisYear", "date-fns")>]
    let isThisYear x = jsNative
    [<Import("lastDayOfYear", "date-fns")>]
    let lastDayOfYear x = jsNative
    [<Import("startOfYear", "date-fns")>]
    let startOfYear x = jsNative
