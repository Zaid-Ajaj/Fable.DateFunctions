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
    let inline closestIndexTo (d: obj) (other: obj) = importDefault "date-fns/closestIndexTo"
    let inline closestTo (date: obj) (other: obj) = importDefault "date-fns/closestTo"
    let inline compareAsc (date: obj) (other: obj) = importDefault "date-fns/compareAsc"
    let inline compareDesc (date: obj) (other: obj) = importDefault "date-fns/compareDesc"
    let inline formatDistance (date: obj) (other: obj) (options: obj) = importDefault "date-fns/formatDistance"
    let inline formatDistanceStrict (date: obj) (other: obj) (opts: obj) = importDefault "date-fns/formatDistanceStrict"
    let inline formatDistanceToNow (date: obj) (opts: obj) = importDefault "date-fns/formatDistanceToNow"
    let inline format (date: obj) = importDefault "date-fns/format"
    let inline formatWithStr (date: obj) (format: string) = importDefault "date-fns/format"
    let inline formatWithStrAndOptions (date: obj) (format: string) (opts: obj) = importDefault "date-fns/format"
    let inline isAfter (date: obj) (other: obj) = importDefault "date-fns/isAfter"
    let inline isBefore (date: obj) (other: obj) = importDefault "date-fns/isBefore"
    let inline isDate (object: obj) = importDefault "date-fns/isDate"
    let inline isEqual (date: obj) (other: obj) = importDefault "date-fns/isEqual"
    let inline isFuture (date: obj) = importDefault "date-fns/isFuture"
    let inline isPast (date: obj) = importDefault "date-fns/isPast"
    let inline isValid (date: obj) = importDefault "date-fns/isValid"
    let inline max (dates: obj) = importDefault "date-fns/max"
    let inline min (dates: obj) = importDefault "date-fns/min"
    let inline parse (input: obj) = importDefault "date-fns/parse"
    let inline parseWithOpts (input: obj) (opts: obj) = importDefault "date-fns/parse"
    let inline areIntervalsOverlapping (i1: Interval) (i2: Interval) = importDefault "date-fns/areIntervalsOverlapping"
    let inline getOverlappingDaysInIntervals (i1: Interval) (i2: Interval) =
        importDefault "date-fns/getOverlappingDaysInIntervals"
    let inline isWithinInterval (d1: obj) (d2: Interval) = importDefault "date-fns/isWithinInterval"
    let inline getTime (d: obj) = importDefault "date-fns/isWithinInterval"
    let inline addMilliseconds (d: obj) (a: obj) = importDefault "date-fns/addMilliseconds"
    let inline differenceInMilliseconds (a: obj) (b: obj) = importDefault "date-fns/differenceInMilliseconds"
    let inline getMilliseconds (a: obj) = importDefault "date-fns/getMilliseconds"
    let inline setMilliseconds (a: obj) (b: obj) = importDefault "date-fns/setMilliseconds"
    let inline subMilliseconds (a: obj) (b: obj) = importDefault "date-fns/subMilliseconds"
    let inline addSeconds a b = importDefault "date-fns/addSeconds"
    let inline differenceInSeconds a b = importDefault "date-fns/differenceInSeconds"
    let inline endOfSecond a = importDefault "date-fns/endOfSecond"
    let inline getSeconds a = importDefault "date-fns/getSeconds"
    let inline isSameSecond a b = importDefault "date-fns/isSameSecond"
    let inline isThisSecond a = importDefault "date-fns/isThisSecond"
    let inline setSeconds a b = importDefault "date-fns/setSeconds"
    let inline startOfSecond a = importDefault "date-fns/startOfSecond"
    let inline subSeconds a b = importDefault "date-fns/subSeconds"
    let inline addMinutes a b = importDefault "date-fns/addMinutes"
    let inline differenceInMinutes a b = importDefault "date-fns/differenceInMinutes"
    let inline endOfMinute a = importDefault "date-fns/endOfMinute"
    let inline getMinutes a = importDefault "date-fns/getMinutes"
    let inline isSameMinute a b = importDefault "date-fns/isSameMinute"
    let inline isThisMinute a = importDefault "date-fns/isThisMinute"
    let inline setMinutes a b = importDefault "date-fns/setMinutes"
    let inline startOfMinute a = importDefault "date-fns/startOfMinute"
    let inline subMinutes a b = importDefault "date-fns/subMinutes"
    let inline addHours a b = importDefault "date-fns/addHours"
    let inline differenceInHours a b = importDefault "date-fns/differenceInHours"
    let inline endOfHour a = importDefault "date-fns/endOfHour"
    let inline getHours a = importDefault "date-fns/getHours"
    let inline isSameHour a b = importDefault "date-fns/isSameHour"
    let inline isThisHour a = importDefault "date-fns/isThisHour"
    let inline setHours a b = importDefault "date-fns/setHours"
    let inline startOfHour a = importDefault "date-fns/startOfHour"
    let inline subHours a b = importDefault "date-fns/subHours"
    let inline addDays a b = importDefault "date-fns/addDays"
    let inline differenceInCalendarDays a b = importDefault "date-fns/differenceInCalendarDays"
    let inline differenceInDays a b = importDefault "date-fns/differenceInDays"
    let inline eachDayOfInterval (a: Interval) = importDefault "date-fns/eachDayOfInterval"
    let inline endOfDay a = importDefault "date-fns/endOfDay"
    let inline endOfToday(): System.DateTime = importDefault "date-fns/endOfToday"
    let inline endOfTomorrow(): System.DateTime = importDefault "date-fns/endOfTomorrow"
    let inline endOfYesterday(): System.DateTime = importDefault "date-fns/endOfYesterday"
    let inline getDate a = importDefault "date-fns/getDate"
    let inline getDayOfYear a = importDefault "date-fns/getDayOfYear"
    let inline isSameDay a b = importDefault "date-fns/isSameDay"
    let inline isToday a = importDefault "date-fns/isToday"
    let inline isTomorrow a = importDefault "date-fns/isTomorrow"
    let inline isYesterday a = importDefault "date-fns/isYesterday"
    let inline setDate a b = importDefault "date-fns/setDate"
    let inline setDayOfyear a b = importDefault "date-fns/setDayOfYear"
    let inline startOfDay a = importDefault "date-fns/startOfDay"
    let inline startOfToday(): System.DateTime = importDefault "date-fns/startOfToday"
    let inline startOfTomorrow(): System.DateTime = importDefault "date-fns/startOfTomorrow"
    let inline startOfYesterday(): System.DateTime = importDefault "date-fns/startOfYesterday"
    let inline subDays a b = importDefault "date-fns/subDays"
    let inline getDay a = importDefault "date-fns/getDay"
    let inline getISODay a = importDefault "date-fns/getIsoDay"
    let inline isFriday a = importDefault "date-fns/isFriday"
    let inline isMonday a = importDefault "date-fns/isMonday"
    let inline isSaturday a = importDefault "date-fns/isSaturday"
    let inline isSunday a = importDefault "date-fns/isSunday"
    let inline isThursday a = importDefault "date-fns/isThursday"
    let inline isTuesday a = importDefault "date-fns/isTuesday"
    let inline isWednesday a = importDefault "date-fns/isWednesday"
    let inline isWeekend a = importDefault "date-fns/isWeekend"
    let inline addWeeks x y = importDefault "date-fns/addWeeks"
    let inline differenceInCalendarWeeks x y = importDefault "date-fns/differenceInCalendarWeeks"
    let inline differenceInWeeks x y = importDefault "date-fns/differenceInWeeks"
    let inline endOfWeek x = importDefault "date-fns/endOfWeek"
    let inline isSameWeek x y = importDefault "date-fns/isSameWeek"
    let inline isThisWeek x = importDefault "date-fns/isThisWeek"
    let inline lastDayOfWeek x = importDefault "date-fns/lastDayOfWeek"
    let inline startOfWeek x = importDefault "date-fns/startOfWeek"
    let inline subWeeks x y = importDefault "date-fns/subWeeks"
    let inline differenceInCalendarISOWeeks x y = importDefault "date-fns/differenceInCalendarIsoWeeks"
    let inline endOfIsoWeek x = importDefault "date-fns/endOfIsoWeek"
    let inline isSameIsoWeek x y = importDefault "date-fns/isSameIsoWeek"
    let inline isThisIsoWeek x = importDefault "date-fns/isThisIsoWeek"
    let inline getISOWeek x = importDefault "date-fns/getIsoWeek"
    let inline lastDayOfIsoWeek x = importDefault "date-fns/lastDayOfIsoWeek"
    let inline startOfIsoWeek x = importDefault "date-fns/startOfIsoWeek"
    let inline setIsoWeek x y = importDefault "date-fns/setIsoWeek"
    let inline addMonths x y = importDefault "date-fns/addMonths"
    let inline differenceInCalendarMonths x y = importDefault "date-fns/differenceInCalendarMonths"
    let inline differenceInMonths x y = importDefault "date-fns/differenceInMonths"
    let inline endOfMonth x = importDefault "date-fns/endOfMonth"
    let inline getDaysInMonth x = importDefault "date-fns/getDaysInMonth"
    let inline getMonth x = importDefault "date-fns/getMonth"
    let inline isFirstDayOfMonth x = importDefault "date-fns/isFirstDayOfMonth"
    let inline isLastDayOfMonth x = importDefault "date-fns/isLastDayOfMonth"
    let inline isSameMonth x y = importDefault "date-fns/isSameMonth"
    let inline isThisMonth x = importDefault "date-fns/isThisMonth"
    let inline setMonth x y = importDefault "date-fns/setMonth"
    let inline startOfMonth x = importDefault "date-fns/startOfMonth"
    let inline subMonths x y = importDefault "date-fns/subMonths"
    let inline addQuarters x y = importDefault "date-fns/addQuarters"
    let inline differenceInCalendarQuarters x y = importDefault "date-fns/differenceInCalendarQuarters"
    let inline differenceInQuarters x y = importDefault "date-fns/differenceInQuarters"
    let inline endOfQuarter x = importDefault "date-fns/endOfQuarter"
    let inline getQuarter x = importDefault "date-fns/getQuarter"
    let inline isSameQuarter x y = importDefault "date-fns/isSameQuarter"
    let inline isThisQuarter x = importDefault "date-fns/isThisQuarter"
    let inline setQuarter x y = importDefault "date-fns/setQuarter"
    let inline lastDayOfQuarter x = importDefault "date-fns/lastDayOfQuarter"
    let inline startOfQuarter x = importDefault "date-fns/startOfQuarter"
    let inline subQuarters x y = importDefault "date-fns/subQuarters"
    let inline addYears x y = importDefault "date-fns/addYears"
    let inline subYears x y = importDefault "date-fns/subYears"
    let inline differenceInCalendarYears x y = importDefault "date-fns/differenceInCalendarYears"
    let inline differenceInYears x y = importDefault "date-fns/differenceInYears"
    let inline endOfYear x = importDefault "date-fns/endOfYear"
    let inline daysInYear x = importDefault "date-fns/getDaysInYear"
    let inline isLeapYear x = importDefault "date-fns/isLeapYear"
    let inline isSameYear x y = importDefault "date-fns/isSameYear"
    let inline isThisYear x = importDefault "date-fns/isThisYear"
    let inline lastDayOfYear x = importDefault "date-fns/lastDayOfYear"
    let inline startOfYear x = importDefault "date-fns/startOfYear"
