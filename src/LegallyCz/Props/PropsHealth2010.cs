using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Types;

namespace HraveMzdy.LegallyCz.Props;

public class PropsHealth2010 : PropsHealthBase, IPropsHealth
{
    public static IPropsHealth Empty()
    {
        return new PropsHealth2010(VERSION_ZERO);
    }
    public PropsHealth2010(Int16 version) : base(version)
    {
    }
    public PropsHealth2010(IVersionId version,
        Int32 minMonthlyBasis, Int32 maxAnnualsBasis,
        Int32 limMonthlyState, Int32 limMonthlyDis50,
        decimal factorCompound, decimal factorEmployee,
        Int32 marginIncomeEmp, Int32 marginIncomeAgr)
        : base(version,
            minMonthlyBasis, maxAnnualsBasis,
            limMonthlyState, limMonthlyDis50,
            factorCompound, factorEmployee,
            marginIncomeEmp, marginIncomeAgr)
    {
    }
    protected override bool HasTermExemptionPartake(WorkHealthTerms term)
    {
        return false;
    }
    protected override bool HasIncomeBasedEmploymentPartake(WorkHealthTerms term)
    {
        return (term == WorkHealthTerms.HEALTH_TERM_AGREEM_WORK);
    }
    protected override bool HasIncomeBasedAgreementsPartake(WorkHealthTerms term)
    {
        return false;
    }
    protected override bool HasIncomeCumulatedPartake(WorkHealthTerms term)
    {
        switch (term)
        {
            case WorkHealthTerms.HEALTH_TERM_EMPLOYMENTS:
                return false;
            case WorkHealthTerms.HEALTH_TERM_AGREEM_WORK:
                return false;
            case WorkHealthTerms.HEALTH_TERM_AGREEM_TASK:
                return false;
            case WorkHealthTerms.HEALTH_TERM_BY_CONTRACT:
                return false;
        }
        return false;
    }
}
