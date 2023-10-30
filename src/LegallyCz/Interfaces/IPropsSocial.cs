using HraveMzdy.LegallyCz.Types;

namespace HraveMzdy.LegallyCz.Interfaces;

public interface IPropsSocial : IProps
{
    Int32 MaxAnnualsBasis { get; }
    decimal FactorEmployer { get; }
    decimal FactorEmployerHigher { get; }
    decimal FactorEmployee { get; }
    decimal FactorEmployeeGarant { get; }
    decimal FactorEmployeeReduce { get; }
    Int32 MarginIncomeEmp { get; }
    Int32 MarginIncomeAgr { get; }
    bool ValueEquals(IPropsSocial other);
    bool IsParticipant(WorkSocialTerms term, Int32 incomeTerm, Int32 incomeSpec);
    Int32 RoundedEmployeePayment(Int32 basisResult);
    Int32 RoundedEmployerPayment(Int32 basisResult);
    Tuple<Int32, Int32> ResultOverlaps(Int32 baseSuma, Int32 overCaps);
    Tuple<Int32, Int32, IEnumerable<PartakeSocialResult>> AnnualsBasisCut(IEnumerable<PartakeSocialTarget> incomeList, Int32 annuityBasis);
}
