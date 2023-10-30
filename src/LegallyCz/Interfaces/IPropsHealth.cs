using HraveMzdy.LegallyCz.Types;

namespace HraveMzdy.LegallyCz.Interfaces;

public interface IPropsHealth : IProps
{
    Int32 MinMonthlyBasis { get; }
    Int32 MaxAnnualsBasis { get; }
    Int32 LimMonthlyState { get; }
    Int32 LimMonthlyDis50 { get; }
    decimal FactorCompound { get; }
    decimal FactorEmployee { get; }
    Int32 MarginIncomeEmp { get; }
    Int32 MarginIncomeAgr { get; }
    bool ValueEquals(IPropsHealth other);
    bool IsParticipant(WorkHealthTerms term, Int32 incomeTerm, Int32 incomeSpec);
    Int32 RoundedCompoundPayment(Int32 basisResult);
    Int32 RoundedEmployeePayment(Int32 basisResult);
    Int32 RoundedAugmentEmployeePayment(Int32 basisGenerals, Int32 basisAugment);
    Int32 RoundedAugmentEmployerPayment(Int32 basisGenerals, Int32 baseEmployee, Int32 baseEmployer);
    Int32 RoundedEmployerPayment(Int32 basisResult);
    Tuple<Int32, Int32, IEnumerable<PartakeHealthResult>> AnnualsBasisCut(IEnumerable<PartakeHealthTarget> incomeList, Int32 annuityBasis);
}
