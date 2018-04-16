namespace Fable.DateFunctions

open System 

[<AutoOpen>]
module MonthHelpers = 
    type DateTime with 
        member date.AddMonths(months: int) : DateTime = ExternalDateFns.addMonths date months
        member date.DifferenceInCalendarMonths(otherDate : DateTime) : int = ExternalDateFns.differenceInCalendarMonths date otherDate 
        member date.DifferenceInMonths(otherDate : DateTime) : int = ExternalDateFns.differenceInMonths date otherDate 
        member date.EndOfMonth() : DateTime = ExternalDateFns.endOfMonth date
        member date.GetDaysInMonth() : int = ExternalDateFns.getDaysInMonth date
        member date.IsFirstDayOfMonth() : bool = ExternalDateFns.isFirstDayOfMonth date 
        member date.IsLastDayOfMonth() : bool = ExternalDateFns.isLastDayOfMonth date
        member date.IsInTheSameMonthAs(otherDate: DateTime) : bool = ExternalDateFns.isSameMonth date otherDate
        member date.IsInThisMonth() : bool = ExternalDateFns.isThisMonth date
        member date.SetMonth(month : Months) : DateTime = ExternalDateFns.setMonth date month
        member date.StartOfMonth() : DateTime = ExternalDateFns.startOfMonth date 
        member date.SubtractMonths(months: int) : DateTime = ExternalDateFns.subMonths date months