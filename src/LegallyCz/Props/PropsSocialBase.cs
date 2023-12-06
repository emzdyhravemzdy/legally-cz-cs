using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.MathOperations;
using HraveMzdy.LegallyCz.Types;

namespace HraveMzdy.LegallyCz.Props;

public abstract class PropsSocialBase : PropsBase, IPropsSocial
{
    public PropsSocialBase(Int16 version) : base(version)
    {
        this.MaxAnnualsBasis = 0;
        this.FactorEmployer = 0m;
        this.FactorEmployerHigher = 0m;
        this.FactorEmployee = 0m;
        this.FactorEmployeeGarant = 0m;
        this.FactorEmployeeReduce = 0m;
        this.MarginIncomeEmp = 0;
        this.MarginIncomeAgr = 0;
    }
    public PropsSocialBase(IVersionId version,
        Int32 maxAnnualsBasis,
        decimal factorEmployer, decimal factorEmployerHigher,
        decimal factorEmployee, decimal factorEmployeeGarant, decimal factorEmployeeReduce,
        Int32 marginIncomeEmp, Int32 marginIncomeAgr) : base(version)
    {
        this.MaxAnnualsBasis = maxAnnualsBasis;
        this.FactorEmployer = factorEmployer;
        this.FactorEmployerHigher = factorEmployerHigher;
        this.FactorEmployee = factorEmployee;
        this.FactorEmployeeGarant = factorEmployeeGarant;
        this.FactorEmployeeReduce = factorEmployeeReduce;
        this.MarginIncomeEmp = marginIncomeEmp;
        this.MarginIncomeAgr = marginIncomeAgr;
    }
    public Int32 MaxAnnualsBasis { get; set; }
    public decimal FactorEmployer { get; set; }
    public decimal FactorEmployerHigher { get; set; }
    public decimal FactorEmployee { get; set; }
    public decimal FactorEmployeeGarant { get; set; }
    public decimal FactorEmployeeReduce { get; set; }
    public Int32 MarginIncomeEmp { get; set; }
    public Int32 MarginIncomeAgr { get; set; }
    public bool ValueEquals(IPropsSocial other)
    {
        if (other == null)
        {
            return false;
        }
        return (this.MaxAnnualsBasis == other.MaxAnnualsBasis &&
                this.FactorEmployer == other.FactorEmployer &&
                this.FactorEmployerHigher == other.FactorEmployerHigher &&
                this.FactorEmployee == other.FactorEmployee &&
                this.FactorEmployeeGarant == other.FactorEmployeeGarant &&
                this.FactorEmployeeReduce == other.FactorEmployeeReduce &&
                this.MarginIncomeEmp == other.MarginIncomeEmp &&
                this.MarginIncomeAgr == other.MarginIncomeAgr);
    }
    public bool IsParticipant(WorkSocialTerms term, Int32 incomeTerm, Int32 incomeSpec)
    {
        bool partakeSpec = true;
        if (HasTermExemptionPartake(term))
        {
            partakeSpec = false;
        }
        else if (HasIncomeBasedAgreementsPartake(term) && MarginIncomeAgr > 0)
        {
            partakeSpec = false;
            if (HasIncomeCumulatedPartake(term))
            {
                if (incomeTerm >= MarginIncomeAgr)
                {
                    partakeSpec = true;
                }
            }
            else
            {
                if (incomeSpec >= MarginIncomeAgr)
                {
                    partakeSpec = true;
                }
            }
        }
        else if (HasIncomeBasedEmploymentPartake(term) && MarginIncomeEmp > 0)
        {
            partakeSpec = false;
            if (HasIncomeCumulatedPartake(term))
            {
                if (incomeTerm >= MarginIncomeEmp)
                {
                    partakeSpec = true;
                }
            }
            else
            {
                if (incomeSpec >= MarginIncomeEmp)
                {
                    partakeSpec = true;
                }
            }
        }
        return partakeSpec;
    }
    protected abstract bool HasTermExemptionPartake(WorkSocialTerms term);
    protected abstract bool HasIncomeBasedEmploymentPartake(WorkSocialTerms term);
    protected abstract bool HasIncomeBasedAgreementsPartake(WorkSocialTerms term);
    protected abstract bool HasIncomeCumulatedPartake(WorkSocialTerms term);
    public decimal DecInsuranceRoundUp(decimal valueDec)
    {
        return OperationsRound.RoundUp(valueDec);
    }

    public Int32 IntInsuranceRoundUp(decimal valueDec)
    {
        return OperationsRound.RoundUp(valueDec);
    }

    public Int32 RoundedEmployeePayment(Int32 basisResult)
    {
        decimal factorEmployee = OperationsDec.Divide(FactorEmployee, 100);

        Int32 employeePayment = IntInsuranceRoundUp(OperationsDec.Multiply(basisResult, factorEmployee));
        return employeePayment;

    }
    public Int32 RoundedEmployerPayment(Int32 basisResult)
    {
        decimal factorEmployer = OperationsDec.Divide(FactorEmployer, 100);

        Int32 employerPayment = IntInsuranceRoundUp(OperationsDec.Multiply(basisResult, factorEmployer));
        return employerPayment;
    }
    public Tuple<Int32, Int32> ResultOverlaps(Int32 baseSuma, Int32 overCaps)
    {
        Int32 maxBaseEmployee = Math.Max(0, baseSuma - overCaps);
        Int32 empBaseOverlaps = Math.Max(0, (baseSuma - maxBaseEmployee));
        Int32 valBaseOverlaps = Math.Max(0, overCaps - empBaseOverlaps);

        return new Tuple<Int32, Int32>(maxBaseEmployee, valBaseOverlaps);
    }

    public Tuple<Int32, Int32, IEnumerable<PartakeSocialResult>> AnnualsBasisCut(IEnumerable<PartakeSocialTarget> incomeList, Int32 annuityBasis)
    {
        Int32 annualsMaxim = this.MaxAnnualsBasis;
        Int32 annualsBasis = Math.Max(0, annualsMaxim - annuityBasis);
        var resultInit = new Tuple<Int32, Int32, IEnumerable<PartakeSocialResult>>(
            annualsMaxim, annualsBasis, Array.Empty<PartakeSocialResult>());

        var resultList = incomeList.Aggregate(resultInit,
            (agr, x) => {
                Int32 cutAnnualsBasis = 0;
                Int32 rawAnnualsBasis = x.TargetsBase;
                Int32 remAnnualsBasis = agr.Item2;

                if (x.PartakeCode != 0)
                {
                    cutAnnualsBasis = rawAnnualsBasis;
                    if (agr.Item1 > 0)
                    {
                        var ovrAnnualsBasis = Math.Max(0, rawAnnualsBasis - agr.Item2);
                        cutAnnualsBasis = (rawAnnualsBasis - ovrAnnualsBasis);
                    }
                    remAnnualsBasis = Math.Max(0, (agr.Item2 - cutAnnualsBasis));
                }

                PartakeSocialResult r = new PartakeSocialResult(x.ContractCode, x.TaxingTerm, x.InterestCode, x.SubjectTerm, x.PartakeCode, x.TargetsBase, Math.Max(0, cutAnnualsBasis));
                return new Tuple<Int32, Int32, IEnumerable<PartakeSocialResult>>(
                    agr.Item1, remAnnualsBasis, agr.Item3.Concat(new PartakeSocialResult[] { r }).ToArray());
            });

        return resultList;
    }
}
