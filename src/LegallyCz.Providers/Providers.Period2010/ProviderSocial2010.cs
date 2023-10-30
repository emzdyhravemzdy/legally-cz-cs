using HraveMzdy.LegallyCz.Attributes;
using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Providers.Period2010;

namespace HraveMzdy.LegallyCz.Providers;

[HistoryVersion(HistoryConstSocial2010.VERSION_CODE)]
public class ProviderSocial2010 : ProviderBase, IProviderSocial
{
    public ProviderSocial2010() : base(HistoryConstSocial2010.VERSION_CODE)
    {
    }

    public IPropsSocial GetProps(ILegallyPeriod period)
    {
        return new PropsSocial2010(Version,
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
        return HistoryConstSocial2010.MAX_ANNUALS_BASIS;
    }
    public decimal FactorEmployer(ILegallyPeriod period)
    {
        return HistoryConstSocial2010.FACTOR_EMPLOYER;
    }
    public decimal FactorEmployerHigher(ILegallyPeriod period)
    {
        return HistoryConstSocial2010.FACTOR_EMPLOYER_HIGHER;
    }
    public decimal FactorEmployee(ILegallyPeriod period)
    {
        return HistoryConstSocial2010.FACTOR_EMPLOYEE;
    }
    public decimal FactorEmployeeGarant(ILegallyPeriod period)
    {
        return HistoryConstSocial2010.FACTOR_EMPLOYEE_GARANT;
    }
    public decimal FactorEmployeeReduce(ILegallyPeriod period)
    {
        return HistoryConstSocial2010.FACTOR_EMPLOYEE_REDUCE;
    }
    public Int32 MarginIncomeEmp(ILegallyPeriod period)
    {
        return HistoryConstSocial2010.MARGIN_INCOME_EMP;
    }
    public Int32 MarginIncomeAgr(ILegallyPeriod period)
    {
        return HistoryConstSocial2010.MARGIN_INCOME_AGR;
    }
}
