using HraveMzdy.LegallyCz.Attributes;
using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Providers.Period2020;

namespace HraveMzdy.LegallyCz.Providers;

[HistoryVersion(HistoryConstSalary2020.VERSION_CODE)]
public class ProviderSalary2020 : ProviderBase, IProviderSalary
{
    public ProviderSalary2020() : base(HistoryConstSalary2020.VERSION_CODE)
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
        return HistoryConstSalary2020.WORKING_SHIFT_WEEK;
    }
    public Int32 WorkingShiftTime(ILegallyPeriod period)
    {
        return HistoryConstSalary2020.WORKING_SHIFT_TIME;
    }
    public Int32 MinMonthlyWage(ILegallyPeriod period)
    {
        return HistoryConstSalary2020.MIN_MONTHLY_WAGE;
    }
    public Int32 MinHourlyWage(ILegallyPeriod period)
    {
        return HistoryConstSalary2020.MIN_HOURLY_WAGE;
    }
}
