using HraveMzdy.LegallyCz.Providers.Period2023;

namespace HraveMzdy.LegallyCz.Providers.Period2024;

// WORKING_SHIFT_WEEK      Počet pracovních dnů v týdnu
//
// WORKING_SHIFT_TIME      Počet pracovních hodin denně
//
// MIN_MONTHLY_WAGE        Minimální mzda měsíční
//
// MIN_HOURLY_WAGE         Minimální mzda hodinová (100*Kč)
class HistoryConstSalary2024
{
    public const Int16 VERSION_CODE = 2024;

    public const Int32 WORKING_SHIFT_WEEK = HistoryConstSalary2023.WORKING_SHIFT_WEEK;
    public const Int32 WORKING_SHIFT_TIME = HistoryConstSalary2023.WORKING_SHIFT_TIME;
    public const Int32 MIN_MONTHLY_WAGE = 16200;
    public const Int32 MIN_HOURLY_WAGE = 9640;
}
