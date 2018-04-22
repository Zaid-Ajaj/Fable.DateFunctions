namespace Fable.DateFunctions

open Fable.Core.JsInterop
open Fable.Core

type ILocale = interface end

[<StringEnum>]
type ParialMethod = Floor | Ceiling | Round

[<StringEnum>]
type TimeUnit = 
    | [<CompiledName("s")>] Second 
    | [<CompiledName("m")>] Minute 
    | [<CompiledName("h")>] Hour 
    | [<CompiledName("d")>] Day 
    | [<CompiledName("M")>] Month 
    | [<CompiledName("Y")>] Year

type Months = 
    | January = 0
    | Februari = 1
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

type DistanceInWordsOpts = 
    /// distances less than a minute are more detailed
    abstract includeSeconds : bool with get, set
    /// result indicates if the second date is earlier or later than the first
    abstract addSuffix : bool with get, set
    /// the locale object
    abstract locale : ILocale with get, set

type DistanceInWordsStrictOpts = 
    /// Result indicates if the second date is earlier or later than the first
    abstract addSuffix : bool with get, set
    /// if specified, will force a unit
    abstract unit : TimeUnit with get, set
    /// which way to round partial units
    abstract partialMethod : ParialMethod with get, set
    /// the locale object
    abstract locale : ILocale with get, set

type FormatOpts = 
    /// the locale object
    abstract locale : ILocale with get, set

type ParseOpts = 
    /// the additional number of digits in the extended year format.
    abstract additionalDigits : int with get, set

module internal ExternalDateFns = 
    let closestIndexTo (d: obj) (other: obj) = importDefault "date-fns/closest_index_to"
    let closestTo (date: obj) (other : obj) = importDefault "date-fns/closest_to"
    let compareAsc (date: obj) (other: obj) = importDefault "date-fns/compare_asc"
    let compareDesc (date: obj) (other: obj) = importDefault "date-fns/compare_desc"
    let distanceInWords (date: obj) (other: obj) (options: obj) = importDefault "date-fns/distance_in_words"
    let dictanceInWordsStrict (date: obj) (other: obj) (opts: obj) = importDefault "date-fns/distance_in_words_strict"
    let distanceInWordsToNow (date: obj) (opts: obj) = importDefault "date-fns/distance_in_words_to_now"
    let format (date: obj) = importDefault "date-fns/format"
    let formatWithStr (date: obj) (format: string) = importDefault "date-fns/format"
    let formatWithStrAndOptions (date: obj) (format: string) (opts: obj) = importDefault "date-fns/format"
    let isAfter (date: obj) (other: obj) = importDefault "date-fns/is_after"
    let isBefore (date: obj) (other: obj) = importDefault "date-fns/is_before"
    let isDate (object: obj) = importDefault "date-fns/is_date"
    let isEqual (date: obj) (other: obj) = importDefault "date-fns/is_equal"
    let isFuture (date: obj) = importDefault "date-fns/is_future"
    let isPast (date: obj) = importDefault "date-fns/is_past"
    let isValid (date: obj) = importDefault "date-fns/is_valid"
    let max (dates: obj) = importDefault "date-fns/max"
    let min (dates: obj) = importDefault "date-fns/min"
    let parse (input: obj) = importDefault "date-fns/parse"
    let parseWithOpts (input: obj) (opts: obj) = importDefault "date-fns/parse"
    let areRangesOverlapping (d1: obj) (d2: obj) (d3: obj) (d4: obj) = importDefault "date-fns/are_ranges_overlapping"
    let getOverlappingDaysInRanges (d1: obj) (d2: obj) (d3: obj) (d4: obj) = importDefault "date-fns/get_overlapping_days_in_ranges"
    let isWithinRange (d1: obj) (d2: obj) (d3: obj) = importDefault "date-fns/is_within_range"
    let getTime (d: obj) = importDefault "date-fns/is_within_range"
    let addMilliseconds (d: obj) (a: obj) = importDefault "date-fns/add_milliseconds"
    let differenceInMilliseconds (a: obj) (b: obj) = importDefault "date-fns/difference_in_milliseconds"
    let getMilliseconds (a: obj) = importDefault "date-fns/get_milliseconds"
    let setMilliseconds (a: obj) (b: obj) = importDefault "date-fns/set_milliseconds"
    let subMilliseconds (a: obj) (b: obj) = importDefault "date-fns/sub_milliseconds"
    let addSeconds a b = importDefault "date-fns/add_seconds"
    let differenceInSeconds a b = importDefault "date-fns/difference_in_seconds"
    let endOfSecond a = importDefault "date-fns/end_of_second"
    let getSeconds a = importDefault "date-fns/get_seconds"
    let isSameSecond a b = importDefault "date-fns/is_same_second"
    let isThisSecond a = importDefault "date-fns/is_this_second"
    let setSeconds a b = importDefault "date-fns/set_seconds"
    let startOfSecond a = importDefault "date-fns/start_of_second"
    let subSeconds a b = importDefault "date-fns/sub_seconds"
    let addMinutes a b = importDefault "date-fns/add_minutes"
    let differenceInMinutes a b = importDefault "date-fns/difference_in_minutes"
    let endOfMinute a = importDefault "date-fns/end_of_minute"
    let getMinutes a = importDefault "date-fns/get_minutes"
    let isSameMinute a b = importDefault "date-fns/is_same_minute"
    let isThisMinute a = importDefault "date-fns/is_this_minute"
    let setMinutes a b = importDefault "date-fns/set_minutes"
    let startOfMinute a = importDefault "date-fns/start_of_minute"
    let subMinutes a b = importDefault "date-fns/sub_minutes"
    let addHours a b = importDefault "date-fns/add_hours"
    let differenceInHours a b = importDefault "date-fns/difference_in_hours"
    let endOfHour a = importDefault "date-fns/end_of_hour"
    let getHours a = importDefault "date-fns/get_hours"
    let isSameHour a b = importDefault "date-fns/is_same_hour"
    let isThisHour a = importDefault "date-fns/is_this_hour"
    let setHours a b = importDefault "date-fns/set_hours"
    let startOfHour a = importDefault "date-fns/start_of_hour"
    let subHours a b = importDefault "date-fns/sub_hours"
    let addDays a b = importDefault "date-fns/add_days"
    let differenceInCalendarDays a b = importDefault "date-fns/difference_in_calendar_days"
    let differenceInDays a b = importDefault "date-fns/difference_in_days"
    let eachDay a b = importDefault "date-fns/each_day"
    let endOfDay a = importDefault "date-fns/end_of_day"
    let endOfToday : unit -> System.DateTime = importDefault "date-fns/end_of_today"
    let endOfTomorrow : unit -> System.DateTime = importDefault "date-fns/end_of_tomorrow"
    let endOfYesterday : unit -> System.DateTime = importDefault "date-fns/end_of_yesterday"
    let getDate a = importDefault "date-fns/get_date"
    let getDayOfYear a = importDefault "date-fns/get_day_of_year"
    let isSameDay a b = importDefault "date-fns/is_same_day"
    let isToday a = importDefault "date-fns/is_today"
    let isTomorrow a = importDefault "date-fns/is_tomorrow"
    let isYesterday a = importDefault "date-fns/is_yesterday"
    let setDate a b = importDefault "date-fns/set_date"
    let setDayOfyear a b = importDefault "date-fns/set_day_of_year"
    let startOfDay a = importDefault "date-fns/start_of_day"
    let startOfToday : unit -> System.DateTime = importDefault "date-fns/start_of_today"
    let startOfTomorrow : unit -> System.DateTime = importDefault "date-fns/start_of_tomorrow"
    let startOfYesterday : unit -> System.DateTime = importDefault "date-fns/start_of_yesterday"
    let subDays a b = importDefault "date-fns/sub_days"
    let getDay a = importDefault "date-fns/get_day"
    let getISODay a = importDefault "date-fns/get_iso_day"
    let isFriday a = importDefault "date-fns/is_friday"
    let isMonday a = importDefault "date-fns/is_monday"
    let isSaturday a = importDefault "date-fns/is_saturday"
    let isSunday a = importDefault "date-fns/is_sunday"
    let isThursday a = importDefault "date-fns/is_thursday"
    let isTuesday a = importDefault "date-fns/is_tuesday"
    let isWednesday a = importDefault "date-fns/is_wednesday"
    let isWeekend a = importDefault "date-fns/is_weekend"
    let addWeeks x y = importDefault "date-fns/add_weeks"
    let differenceInCalendarWeeks x y = importDefault "date-fns/difference_in_calendar_weeks"
    let differenceInWeeks x y = importDefault "date-fns/difference_in_weeks"
    let endOfWeek x = importDefault "date-fns/end_of_week"
    let isSameWeek x y = importDefault "date-fns/is_same_week"
    let isThisWeek x = importDefault "date-fns/is_this_week"
    let lastDayOfWeek x = importDefault "date-fns/last_day_of_week"
    let startOfWeek x = importDefault "date-fns/start_of_week"
    let subWeeks x y = importDefault "date-fns/sub_weeks"
    let differenceInCalendarISOWeeks x y = importDefault "date-fns/difference_in_calendar_iso_weeks"
    let endOfIsoWeek x = importDefault "date-fns/end_of_iso_week"
    let isSameIsoWeek x y = importDefault "date-fns/is_same_iso_week"
    let isThisIsoWeek x = importDefault "date-fns/is_this_iso_week"
    let getISOWeek x = importDefault "date-fns/get_iso_week"
    let lastDayOfIsoWeek x = importDefault "date-fns/last_day_of_iso_week"
    let startOfIsoWeek x = importDefault "date-fns/start_of_iso_week"
    let setIsoWeek x y = importDefault "date-fns/set_iso_week"
    let addMonths x y = importDefault "date-fns/add_months"
    let differenceInCalendarMonths x y = importDefault "date-fns/difference_in_calendar_months"
    let differenceInMonths x y = importDefault "date-fns/difference_in_months"
    let endOfMonth x = importDefault "date-fns/end_of_month"
    let getDaysInMonth x = importDefault "date-fns/get_days_in_month"
    let getMonth x = importDefault "date-fns/get_month"
    let isFirstDayOfMonth x = importDefault "date-fns/is_first_day_of_month"
    let isLastDayOfMonth x = importDefault "date-fns/is_last_day_of_month"
    let isSameMonth x y = importDefault "date-fns/is_same_month"
    let isThisMonth x = importDefault "date-fns/is_this_month"
    let setMonth x y = importDefault "date-fns/set_month"
    let startOfMonth x = importDefault "date-fns/start_of_month"
    let subMonths x y = importDefault "date-fns/sub_months"
    let addYears x y = importDefault "date-fns/add_years"
    let subYears x y = importDefault "date-fns/sub_years"
    let differenceInCalendarYears x y = importDefault "date-fns/difference_in_calendar_years"
    let differenceInYears x y = importDefault "date-fns/difference_in_years"
    let endOfYear x = importDefault "date-fns/end_of_year"
    let daysInYear x = importDefault "date-fns/get_days_in_year"
    let isLeapYear x = importDefault "date-fns/is_leap_year"
    let isSameYear x y = importDefault "date-fns/is_same_year"
    let isThisYear x = importDefault "date-fns/is_this_year"
    let lastDayOfYear x = importDefault "date-fns/last_day_of_year"
    let startOfYear x = importDefault "date-fns/start_of_year"