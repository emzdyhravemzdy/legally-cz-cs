using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Providers.Period2012;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Attributes;

namespace HraveMzdy.LegallyCz.Providers;

[HistoryVersion(HistoryConstSalary2012.VERSION_CODE)]
public class ProviderSalary2012 : ProviderBase, IProviderSalary
{
    public ProviderSalary2012() : base(HistoryConstSalary2012.VERSION_CODE)
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
        return HistoryConstSalary2012.WORKING_SHIFT_WEEK;
    }
    public Int32 WorkingShiftTime(ILegallyPeriod period)
    {
        return HistoryConstSalary2012.WORKING_SHIFT_TIME;
    }
    public Int32 MinMonthlyWage(ILegallyPeriod period)
    {
        return HistoryConstSalary2012.MIN_MONTHLY_WAGE;
    }
    public Int32 MinHourlyWage(ILegallyPeriod period)
    {
        return HistoryConstSalary2012.MIN_HOURLY_WAGE;
    }
}
