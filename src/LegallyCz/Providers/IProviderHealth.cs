using HraveMzdy.LegallyCz.Interfaces;

namespace HraveMzdy.LegallyCz.Providers;

public interface IProviderHealth : IPropsProvider<IPropsHealth>
{
    Int32 MinMonthlyBasis(ILegallyPeriod period);
    Int32 MaxAnnualsBasis(ILegallyPeriod period);
    Int32 LimMonthlyState(ILegallyPeriod period);
    Int32 LimMonthlyDis50(ILegallyPeriod period);
    decimal FactorCompound(ILegallyPeriod period);
    decimal FactorEmployee(ILegallyPeriod period);
    Int32 MarginIncomeEmp(ILegallyPeriod period);
    Int32 MarginIncomeAgr(ILegallyPeriod period);
}
