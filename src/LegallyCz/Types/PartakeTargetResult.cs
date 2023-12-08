using System.Runtime.CompilerServices;

namespace HraveMzdy.LegallyCz.Types;

public class PartakeHealthTarget
{
    public Int16 ContractCode { get; private set; }
    public WorkTaxingTerms TaxpayerTerm { get; private set; }
    public Int16 InterestCode { get; private set; }
    public WorkHealthTerms SubjectTerm { get; private set; }
    public Int16 PartakeCode { get; private set; }
    public Int32 TargetsBase { get; private set; }
    public PartakeHealthTarget(Int16 contractCode, WorkTaxingTerms taxpayerTerm, Int16 interestCode, WorkHealthTerms subjectTerm, Int16 partakeCode, Int32 targetsBase)
    {
        this.ContractCode = contractCode;
        this.TaxpayerTerm = taxpayerTerm;
        this.InterestCode = interestCode;
        this.SubjectTerm = subjectTerm;
        this.PartakeCode = partakeCode;
        this.TargetsBase = targetsBase;
    }
    public Int32 AddTargetsBase(Int32 targetsBase)
    {
        TargetsBase += targetsBase;
        return TargetsBase;
    }
    private class PartakeHealthTargetComparator : IComparer<PartakeHealthTarget>
    {
        public static Int32 IncomeScore(PartakeHealthTarget t)
        {
            Int32 resultType = 0;
            switch (t.TaxpayerTerm)
            {
                case WorkTaxingTerms.TAXING_TERM_EMPLOYMENTS:
                    resultType = 900;
                    break;
                case WorkTaxingTerms.TAXING_TERM_AGREEM_TASK:
                    resultType = 100;
                    break;
                case WorkTaxingTerms.TAXING_TERM_STATUT_PART:
                    resultType = 500;
                    break;
                case WorkTaxingTerms.TAXING_TERM_BY_CONTRACT:
                    resultType = 0;
                    break;
            }
            Int32 resultBase = 0;
            switch (t.SubjectTerm)
            {
                case WorkHealthTerms.HEALTH_TERM_EMPLOYMENTS:
                    resultBase = 9000;
                    break;
                case WorkHealthTerms.HEALTH_TERM_AGREEM_WORK:
                    resultBase = 5000;
                    break;
                case WorkHealthTerms.HEALTH_TERM_AGREEM_TASK:
                    resultBase = 4000;
                    break;
                case WorkHealthTerms.HEALTH_TERM_BY_CONTRACT:
                    resultBase = 0;
                    break;
            }
            Int32 interestRes = 0;
            if (t.InterestCode == 1)
            {
                interestRes = 10000;
            }
            Int32 partakeRes = 0;
            if (t.PartakeCode == 1)
            {
                partakeRes = 100000;
            }
            return resultType + resultBase + interestRes + partakeRes;
        }
        public PartakeHealthTargetComparator()
        {
        }

        public int Compare(PartakeHealthTarget? x, PartakeHealthTarget? y)
        {
            if (x is null && y is null)
            {
                return 0;
            }
            if (y is null)
            {
                return 1;
            }
            if (x is null)
            {
                return -1;
            }
            Int32 xIncomeScore = IncomeScore(x);
            Int32 yIncomeScore = IncomeScore(y);

            if (xIncomeScore.CompareTo(yIncomeScore) == 0)
            {
                return x.ContractCode.CompareTo(y.ContractCode);
            }
            return yIncomeScore.CompareTo(xIncomeScore);
        }
    }
    public static IComparer<PartakeHealthTarget> ResultComparator()
    {
        return new PartakeHealthTargetComparator();
    }
}
public record PartakeHealthResult(Int16 ContractCode, WorkTaxingTerms TaxingTerm, Int16 InterestCode, WorkHealthTerms SubjectTerm, Int16 PartakeCode, Int32 TargetsBase, Int32 ResultsBase);
public class PartakeSocialTarget
{
    public Int16 ContractCode { get; private set; }
    public WorkTaxingTerms TaxpayerTerm { get; private set; }
    public Int16 InterestCode { get; private set; }
    public WorkSocialTerms SubjectTerm { get; private set; }
    public Int16 PartakeCode { get; private set; }
    public Int32 TargetsBase { get; private set; }
    public PartakeSocialTarget(Int16 contractCode, WorkTaxingTerms taxpayerTerm, Int16 interestCode, WorkSocialTerms subjectTerm, Int16 partakeCode, Int32 targetsBase)
    {
        this.ContractCode = contractCode;
        this.TaxpayerTerm = taxpayerTerm;
        this.InterestCode = interestCode;
        this.SubjectTerm = subjectTerm;
        this.PartakeCode = partakeCode;
        this.TargetsBase = targetsBase;
    }
    public Int32 AddTargetsBase(Int32 targetsBase)
    {
        TargetsBase += targetsBase;
        return TargetsBase;
    }
    private class PartakeSocialTargetComparator : IComparer<PartakeSocialTarget>
    {
        private static Int32 IncomeScore(PartakeSocialTarget t)
        {
            Int32 resultType = 0;
            switch (t.TaxpayerTerm)
            {
                case WorkTaxingTerms.TAXING_TERM_EMPLOYMENTS:
                    resultType = 900;
                    break;
                case WorkTaxingTerms.TAXING_TERM_AGREEM_TASK:
                    resultType = 100;
                    break;
                case WorkTaxingTerms.TAXING_TERM_STATUT_PART:
                    resultType = 500;
                    break;
                case WorkTaxingTerms.TAXING_TERM_BY_CONTRACT:
                    resultType = 0;
                    break;
            }
            Int32 resultBase = 0;
            switch (t.SubjectTerm)
            {
                case WorkSocialTerms.SOCIAL_TERM_EMPLOYMENTS:
                    resultBase = 9000;
                    break;
                case WorkSocialTerms.SOCIAL_TERM_SMALLS_EMPL:
                    resultBase = 5000;
                    break;
                case WorkSocialTerms.SOCIAL_TERM_SHORTS_MEET:
                    resultBase = 4000;
                    break;
                case WorkSocialTerms.SOCIAL_TERM_SHORTS_DENY:
                    resultBase = 0;
                    break;
                case WorkSocialTerms.SOCIAL_TERM_BY_CONTRACT:
                    resultBase = 0;
                    break;
                case WorkSocialTerms.SOCIAL_TERM_AGREEM_TASK:
                    resultBase = 0;
                    break;
            }
            Int32 interestRes = 0;
            if (t.InterestCode == 1)
            {
                interestRes = 10000;
            }
            Int32 partakeRes = 0;
            if (t.PartakeCode == 1)
            {
                partakeRes = 100000;
            }
            return resultType + resultBase + interestRes + partakeRes;
        }
        public PartakeSocialTargetComparator()
        {
        }

        public int Compare(PartakeSocialTarget? x, PartakeSocialTarget? y)
        {
            if (x is null && y is null)
            {
                return 0;
            }
            if (y is null)
            {
                return 1;
            }
            if (x is null)
            {
                return -1;
            }
            Int32 xIncomeScore = IncomeScore(x);
            Int32 yIncomeScore = IncomeScore(y);

            if (xIncomeScore.CompareTo(yIncomeScore) == 0)
            {
                return x.ContractCode.CompareTo(y.ContractCode);
            }
            return yIncomeScore.CompareTo(xIncomeScore);
        }
    }
    public static IComparer<PartakeSocialTarget> ResultComparator()
    {
        return new PartakeSocialTargetComparator();
    }
}
public record PartakeSocialResult(Int16 ContractCode, WorkTaxingTerms TaxingTerm, Int16 InterestCode, WorkSocialTerms SubjectTerm, Int16 PartakeCode, Int32 TargetsBase, Int32 ResultsBase);
