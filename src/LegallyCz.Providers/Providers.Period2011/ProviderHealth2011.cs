using HraveMzdy.LegallyCz.Attributes;
using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Providers.Period2011;

namespace HraveMzdy.LegallyCz.Providers;

[HistoryVersion(HistoryConstHealth2011.VERSION_CODE)]
public class ProviderHealth2011 : ProviderBase, IProviderHealth
{
    public ProviderHealth2011() : base(HistoryConstHealth2011.VERSION_CODE)
    {
    }

    public IPropsHealth GetProps(ILegallyPeriod period)
    {
        return new PropsHealth2010(Version,
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
        return HistoryConstHealth2011.MIN_MONTHLY_BASIS;
    }

    public Int32 MaxAnnualsBasis(ILegallyPeriod period)
    {
        return HistoryConstHealth2011.MAX_ANNUALS_BASIS;
    }

    public Int32 LimMonthlyState(ILegallyPeriod period)
    {
        return HistoryConstHealth2011.LIM_MONTHLY_STATE;
    }

    public Int32 LimMonthlyDis50(ILegallyPeriod period)
    {
        return HistoryConstHealth2011.LIM_MONTHLY_DIS50;
    }

    public decimal FactorCompound(ILegallyPeriod period)
    {
        return HistoryConstHealth2011.FACTOR_COMPOUND;
    }

    public decimal FactorEmployee(ILegallyPeriod period)
    {
        return HistoryConstHealth2011.FACTOR_EMPLOYEE;
    }

    public Int32 MarginIncomeEmp(ILegallyPeriod period)
    {
        return HistoryConstHealth2011.MARGIN_INCOME_EMP;
    }
    public Int32 MarginIncomeAgr(ILegallyPeriod period)
    {
        return HistoryConstHealth2011.MARGIN_INCOME_AGR;
    }
}
