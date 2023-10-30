using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Providers.Period2013;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Attributes;

namespace HraveMzdy.LegallyCz.Providers;

[HistoryVersion(HistoryConstHealth2013.VERSION_CODE)]
public class ProviderHealth2013 : ProviderBase, IProviderHealth
{
    public ProviderHealth2013() : base(HistoryConstHealth2013.VERSION_CODE)
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
        if (IsPeriodGreaterOrEqualThan(period, 2013, 8))
        {
            return HistoryConstHealth2013var08.MIN_MONTHLY_BASIS;
        }
        return HistoryConstHealth2013.MIN_MONTHLY_BASIS;
    }

    public Int32 MaxAnnualsBasis(ILegallyPeriod period)
    {
        return HistoryConstHealth2013.MAX_ANNUALS_BASIS;
    }

    public Int32 LimMonthlyState(ILegallyPeriod period)
    {
        return HistoryConstHealth2013.LIM_MONTHLY_STATE;
    }

    public Int32 LimMonthlyDis50(ILegallyPeriod period)
    {
        if (IsPeriodGreaterOrEqualThan(period, 2013, 11))
        {
            return HistoryConstHealth2013var11.LIM_MONTHLY_DIS50;
        }
        return HistoryConstHealth2013.LIM_MONTHLY_DIS50;
    }

    public decimal FactorCompound(ILegallyPeriod period)
    {
        return HistoryConstHealth2013.FACTOR_COMPOUND;
    }

    public decimal FactorEmployee(ILegallyPeriod period)
    {
        return HistoryConstHealth2013.FACTOR_EMPLOYEE;
    }

    public Int32 MarginIncomeEmp(ILegallyPeriod period)
    {
        return HistoryConstHealth2013.MARGIN_INCOME_EMP;
    }
    public Int32 MarginIncomeAgr(ILegallyPeriod period)
    {
        return HistoryConstHealth2013.MARGIN_INCOME_AGR;
    }
}
