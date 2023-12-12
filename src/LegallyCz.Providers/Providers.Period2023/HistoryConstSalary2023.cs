using HraveMzdy.LegallyCz.Providers.Period2022;

namespace HraveMzdy.LegallyCz.Providers.Period2023;

// WORKING_SHIFT_WEEK      Počet pracovních dnů v týdnu
//
// WORKING_SHIFT_TIME      Počet pracovních hodin denně
//
// MIN_MONTHLY_WAGE        Minimální mzda měsíční
//
// MIN_HOURLY_WAGE         Minimální mzda hodinová (100*Kč)
class HistoryConstSalary2023
{
    public const Int16 VERSION_CODE = 2023;

    public const Int32 WORKING_SHIFT_WEEK = HistoryConstSalary2022.WORKING_SHIFT_WEEK;
    public const Int32 WORKING_SHIFT_TIME = HistoryConstSalary2022.WORKING_SHIFT_TIME;
    public const Int32 MIN_MONTHLY_WAGE = 17300;
    public const Int32 MIN_HOURLY_WAGE = 10380;
}
