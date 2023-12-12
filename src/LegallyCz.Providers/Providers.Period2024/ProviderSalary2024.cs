using HraveMzdy.LegallyCz.Attributes;
using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Providers.Period2024;

namespace HraveMzdy.LegallyCz.Providers;

[HistoryVersion(HistoryConstSalary2024.VERSION_CODE)]
public class ProviderSalary2024 : ProviderBase, IProviderSalary
{
    public ProviderSalary2024() : base(HistoryConstSalary2024.VERSION_CODE)
    {
    }

    public IPropsSalary GetProps(ILegallyPeriod period)
    {
        return new PropsSalary(Version,
            WorkingShiftWeek(period), WorkingShiftTime(period),
            MinMonthlyWage(period), MinHourlyWage(period));
    }

    public Int32 WorkingShiftWeek(ILegallyPeriod period)
    {
        return HistoryConstSalary2024.WORKING_SHIFT_WEEK;
    }
    public Int32 WorkingShiftTime(ILegallyPeriod period)
    {
        return HistoryConstSalary2024.WORKING_SHIFT_TIME;
    }
    public Int32 MinMonthlyWage(ILegallyPeriod period)
    {
        return HistoryConstSalary2024.MIN_MONTHLY_WAGE;
    }
    public Int32 MinHourlyWage(ILegallyPeriod period)
    {
        return HistoryConstSalary2024.MIN_HOURLY_WAGE;
    }
}
