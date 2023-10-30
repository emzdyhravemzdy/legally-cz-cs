using HraveMzdy.LegallyCz.Attributes;
using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Providers.Period2012;

namespace HraveMzdy.LegallyCz.Providers;

[HistoryVersion(HistoryConstHealth2012.VERSION_CODE)]
public class ProviderHealth2012 : ProviderBase, IProviderHealth
{
    public ProviderHealth2012() : base(HistoryConstHealth2012.VERSION_CODE)
    {
    }

    public IPropsHealth GetProps(ILegallyPeriod period)
    {
        return new PropsHealth2012(Version,
            MinMonthlyBasis(period),
            MaxAnnualsBasis(period),
            LimMonthlyState(period),
            LimMonthlyDis50(period),
            FactorCompound(period),
            FactorEmployee(period),
            MarginIncomeEmp(period),
            MarginIncomeAgr(period));
    }

    public Int32 MinMonthlyBasis(ILegallyPeriod period)
    {
        return HistoryConstHealth2012.MIN_MONTHLY_BASIS;
    }

    public Int32 MaxAnnualsBasis(ILegallyPeriod period)
    {
        return HistoryConstHealth2012.MAX_ANNUALS_BASIS;
    }

    public Int32 LimMonthlyState(ILegallyPeriod period)
    {
        return HistoryConstHealth2012.LIM_MONTHLY_STATE;
    }

    public Int32 LimMonthlyDis50(ILegallyPeriod period)
    {
        return HistoryConstHealth2012.LIM_MONTHLY_DIS50;
    }

    public decimal FactorCompound(ILegallyPeriod period)
    {
        return HistoryConstHealth2012.FACTOR_COMPOUND;
    }

    public decimal FactorEmployee(ILegallyPeriod period)
    {
        return HistoryConstHealth2012.FACTOR_EMPLOYEE;
    }

    public Int32 MarginIncomeEmp(ILegallyPeriod period)
    {
        return HistoryConstHealth2012.MARGIN_INCOME_EMP;
    }
    public Int32 MarginIncomeAgr(ILegallyPeriod period)
    {
        return HistoryConstHealth2012.MARGIN_INCOME_AGR;
    }
}
