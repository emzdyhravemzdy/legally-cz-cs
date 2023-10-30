using HraveMzdy.LegallyCz.Interfaces;

namespace HraveMzdy.LegallyCz.Providers;

public interface IProviderSocial : IPropsProvider<IPropsSocial>
{
    Int32 MaxAnnualsBasis(ILegallyPeriod period);
    decimal FactorEmployer(ILegallyPeriod period);
    decimal FactorEmployerHigher(ILegallyPeriod period);
    decimal FactorEmployee(ILegallyPeriod period);
    decimal FactorEmployeeGarant(ILegallyPeriod period);
    decimal FactorEmployeeReduce(ILegallyPeriod period);
    Int32 MarginIncomeEmp(ILegallyPeriod period);
    Int32 MarginIncomeAgr(ILegallyPeriod period);
}
