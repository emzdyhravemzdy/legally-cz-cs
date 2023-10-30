using HraveMzdy.LegallyCz.Attributes;
using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Providers.Period2019;

namespace HraveMzdy.LegallyCz.Providers;

[HistoryVersion(HistoryConstSocial2019.VERSION_CODE)]
public class ProviderSocial2019 : ProviderBase, IProviderSocial
{
    public ProviderSocial2019() : base(HistoryConstSocial2019.VERSION_CODE)
    {
    }

    public IPropsSocial GetProps(ILegallyPeriod period)
    {
        return new PropsSocial(Version,
            MaxAnnualsBasis(period),
            FactorEmployer(period),
            FactorEmployerHigher(period),
            FactorEmployee(period),
            FactorEmployeeGarant(period),
            FactorEmployeeReduce(period),
            MarginIncomeEmp(period),
            MarginIncomeAgr(period));
    }

    public Int32 MaxAnnualsBasis(ILegallyPeriod period)
    {
        return HistoryConstSocial2019.MAX_ANNUALS_BASIS;
    }
    public decimal FactorEmployer(ILegallyPeriod period)
    {
        if (IsPeriodGreaterOrEqualThan(period, 2019, 7))
        {
            return HistoryConstSocial2019var07.FACTOR_EMPLOYER;
        }
        return HistoryConstSocial2019.FACTOR_EMPLOYER;
    }
    public decimal FactorEmployerHigher(ILegallyPeriod period)
    {
        return HistoryConstSocial2019.FACTOR_EMPLOYER_HIGHER;
    }
    public decimal FactorEmployee(ILegallyPeriod period)
    {
        return HistoryConstSocial2019.FACTOR_EMPLOYEE;
    }
    public decimal FactorEmployeeGarant(ILegallyPeriod period)
    {
        return HistoryConstSocial2019.FACTOR_EMPLOYEE_GARANT;
    }
    public decimal FactorEmployeeReduce(ILegallyPeriod period)
    {
        return HistoryConstSocial2019.FACTOR_EMPLOYEE_REDUCE;
    }
    public Int32 MarginIncomeEmp(ILegallyPeriod period)
    {
        return HistoryConstSocial2019.MARGIN_INCOME_EMP;
    }
    public Int32 MarginIncomeAgr(ILegallyPeriod period)
    {
        return HistoryConstSocial2019.MARGIN_INCOME_AGR;
    }
}
