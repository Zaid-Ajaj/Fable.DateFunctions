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

[<Erase>]
type Interval =
    {|start: obj; ``end``: obj|}

module ExternalDateFns =
    let closestIndexTo (d: obj) (other: obj) = importDefault "date-fns/closestIndexTo"
    let closestTo (date: obj) (other: obj) = importDefault "date-fns/closestTo"
    let compareAsc (date: obj) (other: obj) = importDefault "date-fns/compareAsc"
    let compareDesc (date: obj) (other: obj) = importDefault "date-fns/compareDesc"
    let formatDistance (date: obj) (other: obj) (options: obj) = importDefault "date-fns/formatDistance"
    let formatDistanceStrict (date: obj) (other: obj) (opts: obj) = importDefault "date-fns/formatDistanceStrict"
    let formatDistanceToNow (date: obj) (opts: obj) = importDefault "date-fns/formatDistanceToNow"
    let format (date: obj) = importDefault "date-fns/format"
    let formatWithStr (date: obj) (format: string) = importDefault "date-fns/format"
    let formatWithStrAndOptions (date: obj) (format: string) (opts: obj) = importDefault "date-fns/format"
    let isAfter (date: obj) (other: obj) = importDefault "date-fns/isAfter"
    let isBefore (date: obj) (other: obj) = importDefault "date-fns/isBefore"
    let isDate (object: obj) = importDefault "date-fns/isDate"
    let isEqual (date: obj) (other: obj) = importDefault "date-fns/isEqual"
    let isFuture (date: obj) = importDefault "date-fns/isFuture"
    let isPast (date: obj) = importDefault "date-fns/isPast"
    let isValid (date: obj) = importDefault "date-fns/isValid"
    let max (dates: obj) = importDefault "date-fns/max"
    let min (dates: obj) = importDefault "date-fns/min"
    let parse (input: obj) = importDefault "date-fns/parse"
    let parseWithOpts (input: obj) (opts: obj) = importDefault "date-fns/parse"
    let areIntervalsOverlapping (i1: Interval) (i2: Interval) = importDefault "date-fns/areIntervalsOverlapping"
    let getOverlappingDaysInIntervals (i1: Interval) (i2: Interval) =
        importDefault "date-fns/getOverlappingDaysInIntervals"
    let isWithinInterval (d1: obj) (d2: Interval) = importDefault "date-fns/isWithinInterval"
    let getTime (d: obj) = importDefault "date-fns/isWithinInterval"
    let addMilliseconds (d: obj) (a: obj) = importDefault "date-fns/addMilliseconds"
    let differenceInMilliseconds (a: obj) (b: obj) = importDefault "date-fns/differenceInMilliseconds"
    let getMilliseconds (a: obj) = importDefault "date-fns/getMilliseconds"
    let setMilliseconds (a: obj) (b: obj) = importDefault "date-fns/setMilliseconds"
    let subMilliseconds (a: obj) (b: obj) = importDefault "date-fns/subMilliseconds"
    let addSeconds a b = importDefault "date-fns/addSeconds"
    let differenceInSeconds a b = importDefault "date-fns/differenceInSeconds"
    let endOfSecond a = importDefault "date-fns/endOfSecond"
    let getSeconds a = importDefault "date-fns/getSeconds"
    let isSameSecond a b = importDefault "date-fns/isSameSecond"
    let isThisSecond a = importDefault "date-fns/isThisSecond"
    let setSeconds a b = importDefault "date-fns/setSeconds"
    let startOfSecond a = importDefault "date-fns/startOfSecond"
    let subSeconds a b = importDefault "date-fns/subSeconds"
    let addMinutes a b = importDefault "date-fns/addMinutes"
    let differenceInMinutes a b = importDefault "date-fns/differenceInMinutes"
    let endOfMinute a = importDefault "date-fns/endOfMinute"
    let getMinutes a = importDefault "date-fns/getMinutes"
    let isSameMinute a b = importDefault "date-fns/isSameMinute"
    let isThisMinute a = importDefault "date-fns/isThisMinute"
    let setMinutes a b = importDefault "date-fns/setMinutes"
    let startOfMinute a = importDefault "date-fns/startOfMinute"
    let subMinutes a b = importDefault "date-fns/subMinutes"
    let addHours a b = importDefault "date-fns/addHours"
    let differenceInHours a b = importDefault "date-fns/differenceInHours"
    let endOfHour a = importDefault "date-fns/endOfHour"
    let getHours a = importDefault "date-fns/getHours"
    let isSameHour a b = importDefault "date-fns/isSameHour"
    let isThisHour a = importDefault "date-fns/isThisHour"
    let setHours a b = importDefault "date-fns/setHours"
    let startOfHour a = importDefault "date-fns/startOfHour"
    let subHours a b = importDefault "date-fns/subHours"
    let addDays a b = importDefault "date-fns/addDays"
    let differenceInCalendarDays a b = importDefault "date-fns/differenceInCalendarDays"
    let differenceInDays a b = importDefault "date-fns/differenceInDays"
    let eachDayOfInterval (a: Interval) = importDefault "date-fns/eachDayOfInterval"
    let endOfDay a = importDefault "date-fns/endOfDay"
    let endOfToday(): System.DateTime = importDefault "date-fns/endOfToday"
    let endOfTomorrow(): System.DateTime = importDefault "date-fns/endOfTomorrow"
    let endOfYesterday(): System.DateTime = importDefault "date-fns/endOfYesterday"
    let getDate a = importDefault "date-fns/getDate"
    let getDayOfYear a = importDefault "date-fns/getDayOfYear"
    let isSameDay a b = importDefault "date-fns/isSameDay"
    let isToday a = importDefault "date-fns/isToday"
    let isTomorrow a = importDefault "date-fns/isTomorrow"
    let isYesterday a = importDefault "date-fns/isYesterday"
    let setDate a b = importDefault "date-fns/setDate"
    let setDayOfyear a b = importDefault "date-fns/setDayOfYear"
    let startOfDay a = importDefault "date-fns/startOfDay"
    let startOfToday(): System.DateTime = importDefault "date-fns/startOfToday"
    let startOfTomorrow(): System.DateTime = importDefault "date-fns/startOfTomorrow"
    let startOfYesterday(): System.DateTime = importDefault "date-fns/startOfYesterday"
    let subDays a b = importDefault "date-fns/subDays"
    let getDay a = importDefault "date-fns/getDay"
    let getISODay a = importDefault "date-fns/getIsoDay"
    let isFriday a = importDefault "date-fns/isFriday"
    let isMonday a = importDefault "date-fns/isMonday"
    let isSaturday a = importDefault "date-fns/isSaturday"
    let isSunday a = importDefault "date-fns/isSunday"
    let isThursday a = importDefault "date-fns/isThursday"
    let isTuesday a = importDefault "date-fns/isTuesday"
    let isWednesday a = importDefault "date-fns/isWednesday"
    let isWeekend a = importDefault "date-fns/isWeekend"
    let addWeeks x y = importDefault "date-fns/addWeeks"
    let differenceInCalendarWeeks x y = importDefault "date-fns/differenceInCalendarWeeks"
    let differenceInWeeks x y = importDefault "date-fns/differenceInWeeks"
    let endOfWeek x = importDefault "date-fns/endOfWeek"
    let isSameWeek x y = importDefault "date-fns/isSameWeek"
    let isThisWeek x = importDefault "date-fns/isThisWeek"
    let lastDayOfWeek x = importDefault "date-fns/lastDayOfWeek"
    let startOfWeek x = importDefault "date-fns/startOfWeek"
    let subWeeks x y = importDefault "date-fns/subWeeks"
    let differenceInCalendarISOWeeks x y = importDefault "date-fns/differenceInCalendarIsoWeeks"
    let endOfIsoWeek x = importDefault "date-fns/endOfIsoWeek"
    let isSameIsoWeek x y = importDefault "date-fns/isSameIsoWeek"
    let isThisIsoWeek x = importDefault "date-fns/isThisIsoWeek"
    let getISOWeek x = importDefault "date-fns/getIsoWeek"
    let lastDayOfIsoWeek x = importDefault "date-fns/lastDayOfIsoWeek"
    let startOfIsoWeek x = importDefault "date-fns/startOfIsoWeek"
    let setIsoWeek x y = importDefault "date-fns/setIsoWeek"
    let addMonths x y = importDefault "date-fns/addMonths"
    let differenceInCalendarMonths x y = importDefault "date-fns/differenceInCalendarMonths"
    let differenceInMonths x y = importDefault "date-fns/differenceInMonths"
    let endOfMonth x = importDefault "date-fns/endOfMonth"
    let getDaysInMonth x = importDefault "date-fns/getDaysInMonth"
    let getMonth x = importDefault "date-fns/getMonth"
    let isFirstDayOfMonth x = importDefault "date-fns/isFirstDayOfMonth"
    let isLastDayOfMonth x = importDefault "date-fns/isLastDayOfMonth"
    let isSameMonth x y = importDefault "date-fns/isSameMonth"
    let isThisMonth x = importDefault "date-fns/isThisMonth"
    let setMonth x y = importDefault "date-fns/setMonth"
    let startOfMonth x = importDefault "date-fns/startOfMonth"
    let subMonths x y = importDefault "date-fns/subMonths"
    let addQuarters x y = importDefault "date-fns/addQuarters"
    let differenceInCalendarQuarters x y = importDefault "date-fns/differenceInCalendarQuarters"
    let differenceInQuarters x y = importDefault "date-fns/differenceInQuarters"
    let endOfQuarter x = importDefault "date-fns/endOfQuarter"
    let getQuarter x = importDefault "date-fns/getQuarter"
    let isSameQuarter x y = importDefault "date-fns/isSameQuarter"
    let isThisQuarter x = importDefault "date-fns/isThisQuarter"
    let setQuarter x y = importDefault "date-fns/setQuarter"
    let lastDayOfQuarter x = importDefault "date-fns/lastDayOfQuarter"
    let startOfQuarter x = importDefault "date-fns/startOfQuarter"
    let subQuarters x y = importDefault "date-fns/subQuarters"
    let addYears x y = importDefault "date-fns/addYears"
    let subYears x y = importDefault "date-fns/subYears"
    let differenceInCalendarYears x y = importDefault "date-fns/differenceInCalendarYears"
    let differenceInYears x y = importDefault "date-fns/differenceInYears"
    let endOfYear x = importDefault "date-fns/endOfYear"
    let daysInYear x = importDefault "date-fns/getDaysInYear"
    let isLeapYear x = importDefault "date-fns/isLeapYear"
    let isSameYear x y = importDefault "date-fns/isSameYear"
    let isThisYear x = importDefault "date-fns/isThisYear"
    let lastDayOfYear x = importDefault "date-fns/lastDayOfYear"
    let startOfYear x = importDefault "date-fns/startOfYear"
