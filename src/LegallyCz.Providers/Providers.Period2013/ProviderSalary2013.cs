using HraveMzdy.LegallyCz.Attributes;
using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Providers.Period2013;

namespace HraveMzdy.LegallyCz.Providers;

[HistoryVersion(HistoryConstSalary2013.VERSION_CODE)]
public class ProviderSalary2013 : ProviderBase, IProviderSalary
{
    public ProviderSalary2013() : base(HistoryConstSalary2013.VERSION_CODE)
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
        return HistoryConstSalary2013.WORKING_SHIFT_WEEK;
    }
    public Int32 WorkingShiftTime(ILegallyPeriod period)
    {
        return HistoryConstSalary2013.WORKING_SHIFT_TIME;
    }
    public Int32 MinMonthlyWage(ILegallyPeriod period)
    {
        if (IsPeriodGreaterOrEqualThan(period, 2013, 8))
        {
            return HistoryConstSalary2013var08.MIN_MONTHLY_WAGE;
        }
        return HistoryConstSalary2013.MIN_MONTHLY_WAGE;
    }
    public Int32 MinHourlyWage(ILegallyPeriod period)
    {
        if (IsPeriodGreaterOrEqualThan(period, 2013, 8))
        {
            return HistoryConstSalary2013var08.MIN_HOURLY_WAGE;
        }
        return HistoryConstSalary2013.MIN_HOURLY_WAGE;
    }
}
