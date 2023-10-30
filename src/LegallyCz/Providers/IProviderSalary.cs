using HraveMzdy.LegallyCz.Interfaces;

namespace HraveMzdy.LegallyCz.Providers;

public interface IProviderSalary : IPropsProvider<IPropsSalary>
{
    Int32 WorkingShiftWeek(ILegallyPeriod period);
    Int32 WorkingShiftTime(ILegallyPeriod period);
    Int32 MinMonthlyWage(ILegallyPeriod period);
    Int32 MinHourlyWage(ILegallyPeriod period);
}
