using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Providers.Period2012;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Attributes;

namespace HraveMzdy.LegallyCz.Providers;

[HistoryVersion(HistoryConstSocial2012.VERSION_CODE)]
public class ProviderSocial2012 : ProviderBase, IProviderSocial
{
    public ProviderSocial2012() : base(HistoryConstSocial2012.VERSION_CODE)
    {
    }

    public IPropsSocial GetProps(ILegallyPeriod period)
    {
        return new PropsSocial2012(Version,
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
        return HistoryConstSocial2012.MAX_ANNUALS_BASIS;
    }
    public decimal FactorEmployer(ILegallyPeriod period)
    {
        return HistoryConstSocial2012.FACTOR_EMPLOYER;
    }
    public decimal FactorEmployerHigher(ILegallyPeriod period)
    {
        return HistoryConstSocial2012.FACTOR_EMPLOYER_HIGHER;
    }
    public decimal FactorEmployee(ILegallyPeriod period)
    {
        return HistoryConstSocial2012.FACTOR_EMPLOYEE;
    }
    public decimal FactorEmployeeGarant(ILegallyPeriod period)
    {
        return HistoryConstSocial2012.FACTOR_EMPLOYEE_GARANT;
    }
    public decimal FactorEmployeeReduce(ILegallyPeriod period)
    {
        return HistoryConstSocial2012.FACTOR_EMPLOYEE_REDUCE;
    }
    public Int32 MarginIncomeEmp(ILegallyPeriod period)
    {
        return HistoryConstSocial2012.MARGIN_INCOME_EMP;
    }
    public Int32 MarginIncomeAgr(ILegallyPeriod period)
    {
        return HistoryConstSocial2012.MARGIN_INCOME_AGR;
    }
}
