using HraveMzdy.LegallyCz.Extensions;

namespace HraveMzdy.LegallyCz.Types;

public enum WorkContractTerms : UInt16
{
    WORKTERM_EMPLOYMENT_1 = 0,
    WORKTERM_CONTRACTER_A = 1,
    WORKTERM_CONTRACTER_T = 2,
    WORKTERM_PARTNER_STAT = 3,
};

public static class WorkContractTermsEnum
{
    public static WorkContractTerms Get(this Int32 symbol)
    {
        return EnumConstExtension.GetEnum<WorkContractTerms>((UInt16)symbol, WorkContractTerms.WORKTERM_EMPLOYMENT_1);
    }
}

public enum WorkTaxingTerms : UInt16
{
    TAXING_TERM_BY_CONTRACT = 0,
    TAXING_TERM_EMPLOYMENTS = 1,
    TAXING_TERM_AGREEM_TASK = 2,
    TAXING_TERM_STATUT_PART = 3,
};
public static class WorkTaxingTermsEnum
{
    public static WorkTaxingTerms Get(this Int32 symbol)
    {
        return EnumConstExtension.GetEnum<WorkTaxingTerms>((UInt16)symbol, WorkTaxingTerms.TAXING_TERM_BY_CONTRACT);
    }
}

public enum WorkHealthTerms : UInt16
{
    HEALTH_TERM_BY_CONTRACT = 0,
    HEALTH_TERM_EMPLOYMENTS = 1,
    HEALTH_TERM_AGREEM_WORK = 2,
    HEALTH_TERM_AGREEM_TASK = 3,
};
public static class WorkHealthTermsEnum
{
    public static WorkHealthTerms Get(this Int32 symbol)
    {
        return EnumConstExtension.GetEnum<WorkHealthTerms>((UInt16)symbol, WorkHealthTerms.HEALTH_TERM_BY_CONTRACT);
    }
}

public enum WorkSocialTerms : UInt16
{
    SOCIAL_TERM_BY_CONTRACT = 0,
    SOCIAL_TERM_EMPLOYMENTS = 1,
    SOCIAL_TERM_SMALLS_EMPL = 3,
    SOCIAL_TERM_MEETSH_EMPL = 4,
    SOCIAL_TERM_DENYSH_EMPL = 5,
    SOCIAL_TERM_AGREEM_TASK = 9,
};
public static class WorkSocialTermsEnum
{
    public static WorkSocialTerms Get(this Int32 symbol)
    {
        return EnumConstExtension.GetEnum<WorkSocialTerms>((UInt16)symbol, WorkSocialTerms.SOCIAL_TERM_BY_CONTRACT);
    }
}

