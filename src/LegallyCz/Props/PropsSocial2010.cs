using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Types;

namespace HraveMzdy.LegallyCz.Props;

public class PropsSocial2010 : PropsSocialBase, IPropsSocial
{
    public static IPropsSocial Empty()
    {
        return new PropsSocial2010(VERSION_ZERO);
    }
    public PropsSocial2010(Int16 version) : base(version)
    {
    }
    public PropsSocial2010(IVersionId version,
        Int32 maxAnnualsBasis,
        decimal factorEmployer, decimal factorEmployerHigher,
        decimal factorEmployee, decimal factorEmployeeGarant, decimal factorEmployeeReduce,
        Int32 marginIncomeEmp, Int32 marginIncomeAgr) 
        : base(version,
            maxAnnualsBasis,
            factorEmployer, factorEmployerHigher,
            factorEmployee, factorEmployeeGarant, factorEmployeeReduce,
            marginIncomeEmp, marginIncomeAgr)
    {
    }
    protected override bool HasTermExemptionPartake(WorkSocialTerms term)
    {
        return false;
    }
    protected override bool HasIncomeBasedEmploymentPartake(WorkSocialTerms term)
    {
        return (term == WorkSocialTerms.SOCIAL_TERM_SMALLS_EMPL);
    }
    protected override bool HasIncomeBasedAgreementsPartake(WorkSocialTerms term)
    {
        return false;
    }
    protected override bool HasIncomeCumulatedPartake(WorkSocialTerms term)
    {
        switch (term)
        {
            case WorkSocialTerms.SOCIAL_TERM_EMPLOYMENTS:
                return false;
            case WorkSocialTerms.SOCIAL_TERM_AGREEM_TASK:
                return false;
            case WorkSocialTerms.SOCIAL_TERM_SMALLS_EMPL:
                return false;
            case WorkSocialTerms.SOCIAL_TERM_MEETSH_EMPL:
                return false;
            case WorkSocialTerms.SOCIAL_TERM_DENYSH_EMPL:
                return false;
            case WorkSocialTerms.SOCIAL_TERM_BY_CONTRACT:
                return false;
        }
        return false;
    }
}
