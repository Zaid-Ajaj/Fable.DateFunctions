namespace Fable.DateFunctions

open Fable.Core.JsInterop
open Fable.Core

type ILocale = interface end

[<StringEnum>]
type PartialMethod = Floor | Ceiling | Round

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

type IDistanceInWordsOptions =
    /// distances less than a minute are more detailed
    abstract includeSeconds : bool with get, set
    /// result indicates if the second date is earlier or later than the first
    abstract addSuffix : bool with get, set
    /// the locale object
    abstract locale : ILocale with get, set

type IDistanceInWordsStrictOptions =
    /// Result indicates if the second date is earlier or later than the first
    abstract addSuffix : bool with get, set
    /// if specified, will force a unit
    abstract unit : TimeUnit with get, set
    /// which way to round partial units
    abstract partialMethod : PartialMethod with get, set
    /// the locale object
    abstract locale : ILocale with get, set

type IDateFormatOptions =
    /// the locale object
    abstract locale : ILocale with get, set

type ParseOpts =
    /// the additional number of digits in the extended year format.
    abstract additionalDigits : int with get, set

module ExternalDateFns =
    let inline closestIndexTo (d: obj) (other: obj) = importDefault "date-fns/closest_index_to"
    let inline closestTo (date: obj) (other : obj) = importDefault "date-fns/closest_to"
    let inline compareAsc (date: obj) (other: obj) = importDefault "date-fns/compare_asc"
    let inline compareDesc (date: obj) (other: obj) = importDefault "date-fns/compare_desc"
    let inline distanceInWords (date: obj) (other: obj) (options: obj) = importDefault "date-fns/distance_in_words"
    let inline dictanceInWordsStrict (date: obj) (other: obj) (opts: obj) = importDefault "date-fns/distance_in_words_strict"
    let inline distanceInWordsToNow (date: obj) (opts: obj) = importDefault "date-fns/distance_in_words_to_now"
    let inline format (date: obj) = importDefault "date-fns/format"
    let inline formatWithStr (date: obj) (format: string) = importDefault "date-fns/format"
    let inline formatWithStrAndOptions (date: obj) (format: string) (opts: obj) = importDefault "date-fns/format"
    let inline isAfter (date: obj) (other: obj) = importDefault "date-fns/is_after"
    let inline isBefore (date: obj) (other: obj) = importDefault "date-fns/is_before"
    let inline isDate (object: obj) = importDefault "date-fns/is_date"
    let inline isEqual (date: obj) (other: obj) = importDefault "date-fns/is_equal"
    let inline isFuture (date: obj) = importDefault "date-fns/is_future"
    let inline isPast (date: obj) = importDefault "date-fns/is_past"
    let inline isValid (date: obj) = importDefault "date-fns/is_valid"
    let inline max (dates: obj) = importDefault "date-fns/max"
    let inline min (dates: obj) = importDefault "date-fns/min"
    let inline parse (input: obj) = importDefault "date-fns/parse"
    let inline parseWithOpts (input: obj) (opts: obj) = importDefault "date-fns/parse"
    let inline areRangesOverlapping (d1: obj) (d2: obj) (d3: obj) (d4: obj) = importDefault "date-fns/are_ranges_overlapping"
    let inline getOverlappingDaysInRanges (d1: obj) (d2: obj) (d3: obj) (d4: obj) = importDefault "date-fns/get_overlapping_days_in_ranges"
    let inline isWithinRange (d1: obj) (d2: obj) (d3: obj) = importDefault "date-fns/is_within_range"
    let inline getTime (d: obj) = importDefault "date-fns/is_within_range"
    let inline addMilliseconds (d: obj) (a: obj) = importDefault "date-fns/add_milliseconds"
    let inline differenceInMilliseconds (a: obj) (b: obj) = importDefault "date-fns/difference_in_milliseconds"
    let inline getMilliseconds (a: obj) = importDefault "date-fns/get_milliseconds"
    let inline setMilliseconds (a: obj) (b: obj) = importDefault "date-fns/set_milliseconds"
    let inline subMilliseconds (a: obj) (b: obj) = importDefault "date-fns/sub_milliseconds"
    let inline addSeconds a b = importDefault "date-fns/add_seconds"
    let inline differenceInSeconds a b = importDefault "date-fns/difference_in_seconds"
    let inline endOfSecond a = importDefault "date-fns/end_of_second"
    let inline getSeconds a = importDefault "date-fns/get_seconds"
    let inline isSameSecond a b = importDefault "date-fns/is_same_second"
    let inline isThisSecond a = importDefault "date-fns/is_this_second"
    let inline setSeconds a b = importDefault "date-fns/set_seconds"
    let inline startOfSecond a = importDefault "date-fns/start_of_second"
    let inline subSeconds a b = importDefault "date-fns/sub_seconds"
    let inline addMinutes a b = importDefault "date-fns/add_minutes"
    let inline differenceInMinutes a b = importDefault "date-fns/difference_in_minutes"
    let inline endOfMinute a = importDefault "date-fns/end_of_minute"
    let inline getMinutes a = importDefault "date-fns/get_minutes"
    let inline isSameMinute a b = importDefault "date-fns/is_same_minute"
    let inline isThisMinute a = importDefault "date-fns/is_this_minute"
    let inline setMinutes a b = importDefault "date-fns/set_minutes"
    let inline startOfMinute a = importDefault "date-fns/start_of_minute"
    let inline subMinutes a b = importDefault "date-fns/sub_minutes"
    let inline addHours a b = importDefault "date-fns/add_hours"
    let inline differenceInHours a b = importDefault "date-fns/difference_in_hours"
    let inline endOfHour a = importDefault "date-fns/end_of_hour"
    let inline getHours a = importDefault "date-fns/get_hours"
    let inline isSameHour a b = importDefault "date-fns/is_same_hour"
    let inline isThisHour a = importDefault "date-fns/is_this_hour"
    let inline setHours a b = importDefault "date-fns/set_hours"
    let inline startOfHour a = importDefault "date-fns/start_of_hour"
    let inline subHours a b = importDefault "date-fns/sub_hours"
    let inline addDays a b = importDefault "date-fns/add_days"
    let inline differenceInCalendarDays a b = importDefault "date-fns/difference_in_calendar_days"
    let inline differenceInDays a b = importDefault "date-fns/difference_in_days"
    let inline eachDay a b = importDefault "date-fns/each_day"
    let inline endOfDay a = importDefault "date-fns/end_of_day"
    let inline endOfToday : unit -> System.DateTime = importDefault "date-fns/end_of_today"
    let inline endOfTomorrow : unit -> System.DateTime = importDefault "date-fns/end_of_tomorrow"
    let inline endOfYesterday : unit -> System.DateTime = importDefault "date-fns/end_of_yesterday"
    let inline getDate a = importDefault "date-fns/get_date"
    let inline getDayOfYear a = importDefault "date-fns/get_day_of_year"
    let inline isSameDay a b = importDefault "date-fns/is_same_day"
    let inline isToday a = importDefault "date-fns/is_today"
    let inline isTomorrow a = importDefault "date-fns/is_tomorrow"
    let inline isYesterday a = importDefault "date-fns/is_yesterday"
    let inline setDate a b = importDefault "date-fns/set_date"
    let inline setDayOfyear a b = importDefault "date-fns/set_day_of_year"
    let inline startOfDay a = importDefault "date-fns/start_of_day"
    let inline startOfToday : unit -> System.DateTime = importDefault "date-fns/start_of_today"
    let inline startOfTomorrow : unit -> System.DateTime = importDefault "date-fns/start_of_tomorrow"
    let inline startOfYesterday : unit -> System.DateTime = importDefault "date-fns/start_of_yesterday"
    let inline subDays a b = importDefault "date-fns/sub_days"
    let inline getDay a = importDefault "date-fns/get_day"
    let inline getISODay a = importDefault "date-fns/get_iso_day"
    let inline isFriday a = importDefault "date-fns/is_friday"
    let inline isMonday a = importDefault "date-fns/is_monday"
    let inline isSaturday a = importDefault "date-fns/is_saturday"
    let inline isSunday a = importDefault "date-fns/is_sunday"
    let inline isThursday a = importDefault "date-fns/is_thursday"
    let inline isTuesday a = importDefault "date-fns/is_tuesday"
    let inline isWednesday a = importDefault "date-fns/is_wednesday"
    let inline isWeekend a = importDefault "date-fns/is_weekend"
    let inline addWeeks x y = importDefault "date-fns/add_weeks"
    let inline differenceInCalendarWeeks x y = importDefault "date-fns/difference_in_calendar_weeks"
    let inline differenceInWeeks x y = importDefault "date-fns/difference_in_weeks"
    let inline endOfWeek x = importDefault "date-fns/end_of_week"
    let inline isSameWeek x y = importDefault "date-fns/is_same_week"
    let inline isThisWeek x = importDefault "date-fns/is_this_week"
    let inline lastDayOfWeek x = importDefault "date-fns/last_day_of_week"
    let inline startOfWeek x = importDefault "date-fns/start_of_week"
    let inline subWeeks x y = importDefault "date-fns/sub_weeks"
    let inline differenceInCalendarISOWeeks x y = importDefault "date-fns/difference_in_calendar_iso_weeks"
    let inline endOfIsoWeek x = importDefault "date-fns/end_of_iso_week"
    let inline isSameIsoWeek x y = importDefault "date-fns/is_same_iso_week"
    let inline isThisIsoWeek x = importDefault "date-fns/is_this_iso_week"
    let inline getISOWeek x = importDefault "date-fns/get_iso_week"
    let inline lastDayOfIsoWeek x = importDefault "date-fns/last_day_of_iso_week"
    let inline startOfIsoWeek x = importDefault "date-fns/start_of_iso_week"
    let inline setIsoWeek x y = importDefault "date-fns/set_iso_week"
    let inline addMonths x y = importDefault "date-fns/add_months"
    let inline differenceInCalendarMonths x y = importDefault "date-fns/difference_in_calendar_months"
    let inline differenceInMonths x y = importDefault "date-fns/difference_in_months"
    let inline endOfMonth x = importDefault "date-fns/end_of_month"
    let inline getDaysInMonth x = importDefault "date-fns/get_days_in_month"
    let inline getMonth x = importDefault "date-fns/get_month"
    let inline isFirstDayOfMonth x = importDefault "date-fns/is_first_day_of_month"
    let inline isLastDayOfMonth x = importDefault "date-fns/is_last_day_of_month"
    let inline isSameMonth x y = importDefault "date-fns/is_same_month"
    let inline isThisMonth x = importDefault "date-fns/is_this_month"
    let inline setMonth x y = importDefault "date-fns/set_month"
    let inline startOfMonth x = importDefault "date-fns/start_of_month"
    let inline subMonths x y = importDefault "date-fns/sub_months"
    let inline addYears x y = importDefault "date-fns/add_years"
    let inline subYears x y = importDefault "date-fns/sub_years"
    let inline differenceInCalendarYears x y = importDefault "date-fns/difference_in_calendar_years"
    let inline differenceInYears x y = importDefault "date-fns/difference_in_years"
    let inline endOfYear x = importDefault "date-fns/end_of_year"
    let inline daysInYear x = importDefault "date-fns/get_days_in_year"
    let inline isLeapYear x = importDefault "date-fns/is_leap_year"
    let inline isSameYear x y = importDefault "date-fns/is_same_year"
    let inline isThisYear x = importDefault "date-fns/is_this_year"
    let inline lastDayOfYear x = importDefault "date-fns/last_day_of_year"
    let inline startOfYear x = importDefault "date-fns/start_of_year"
