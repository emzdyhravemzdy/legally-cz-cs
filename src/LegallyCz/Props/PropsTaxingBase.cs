using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.MathOperations;
using HraveMzdy.LegallyCz.Types;

namespace HraveMzdy.LegallyCz.Props
{
    public abstract class PropsTaxingBase : PropsBase, IPropsTaxing
    {
        public PropsTaxingBase(Int16 version) : base(version)
        {
            this.AllowancePayer = 0;
            this.AllowanceDisability1st = 0;
            this.AllowanceDisability2nd = 0;
            this.AllowanceDisability3rd = 0;
            this.AllowanceStudy = 0;
            this.AllowanceChild1st = 0;
            this.AllowanceChild2nd = 0;
            this.AllowanceChild3rd = 0;
            this.FactorAdvances = 0m;
            this.FactorWithhold = 0m;
            this.FactorSolidary = 0m;
            this.FactorTaxRate2 = 0m;
            this.MinAmountOfTaxBonus = 0;
            this.MaxAmountOfTaxBonus = 0;
            this.MarginIncomeOfTaxBonus = 0;
            this.MarginIncomeOfRounding = 0;
            this.MarginIncomeOfWithhold = 0;
            this.MarginIncomeOfSolidary = 0;
            this.MarginIncomeOfTaxRate2 = 0;
            this.MarginIncomeOfWthEmp = 0;
            this.MarginIncomeOfWthAgr = 0;
        }
        public PropsTaxingBase(IVersionId version,
            Int32 allowancePayer,
            Int32 allowanceDisability1st, Int32 allowanceDisability2nd, Int32 allowanceDisability3rd,
            Int32 allowanceStudy,
            Int32 allowanceChild1st, Int32 allowanceChild2nd, Int32 allowanceChild3rd,
            decimal factorAdvances, decimal factorWithhold, 
            decimal factorSolidary, decimal factorTaxRate2,
            Int32 minAmountOfTaxBonus, Int32 maxAmountOfTaxBonus, Int32 marginIncomeOfTaxBonus,
            Int32 marginIncomeOfRounding, Int32 marginIncomeOfWithhold, 
            Int32 marginIncomeOfSolidary, Int32 marginIncomeOfTaxRate2,
            Int32 marginIncomeOfWthEmp, Int32 marginIncomeOfWthAgr) : base(version)
        {
            this.AllowancePayer = allowancePayer;
            this.AllowanceDisability1st = allowanceDisability1st;
            this.AllowanceDisability2nd = allowanceDisability2nd;
            this.AllowanceDisability3rd = allowanceDisability3rd;
            this.AllowanceStudy = allowanceStudy;
            this.AllowanceChild1st = allowanceChild1st;
            this.AllowanceChild2nd = allowanceChild2nd;
            this.AllowanceChild3rd = allowanceChild3rd;
            this.FactorAdvances = factorAdvances;
            this.FactorWithhold = factorWithhold;
            this.FactorSolidary = factorSolidary;
            this.FactorTaxRate2 = factorTaxRate2;
            this.MinAmountOfTaxBonus = minAmountOfTaxBonus;
            this.MaxAmountOfTaxBonus = maxAmountOfTaxBonus;
            this.MarginIncomeOfTaxBonus = marginIncomeOfTaxBonus;
            this.MarginIncomeOfRounding = marginIncomeOfRounding;
            this.MarginIncomeOfWithhold = marginIncomeOfWithhold;
            this.MarginIncomeOfSolidary = marginIncomeOfSolidary;
            this.MarginIncomeOfTaxRate2 = marginIncomeOfTaxRate2;
            this.MarginIncomeOfWthEmp = marginIncomeOfWthEmp;
            this.MarginIncomeOfWthAgr = marginIncomeOfWthAgr;
        }

        public Int32 AllowancePayer { get; set; }
        public Int32 AllowanceDisability1st { get; set; }
        public Int32 AllowanceDisability2nd { get; set; }
        public Int32 AllowanceDisability3rd { get; set; }
        public Int32 AllowanceStudy { get; set; }
        public Int32 AllowanceChild1st { get; set; }
        public Int32 AllowanceChild2nd { get; set; }
        public Int32 AllowanceChild3rd { get; set; }
        public decimal FactorAdvances { get; set; }
        public decimal FactorWithhold { get; set; }
        public decimal FactorSolidary { get; set; }
        public decimal FactorTaxRate2 { get; set; }
        public Int32 MinAmountOfTaxBonus { get; set; }
        public Int32 MaxAmountOfTaxBonus { get; set; }
        public Int32 MarginIncomeOfTaxBonus { get; set; }
        public Int32 MarginIncomeOfRounding { get; set; }
        public Int32 MarginIncomeOfWithhold { get; set; }
        public Int32 MarginIncomeOfSolidary { get; set; }
        public Int32 MarginIncomeOfTaxRate2 { get; set; }
        public Int32 MarginIncomeOfWthEmp { get; set; }
        public Int32 MarginIncomeOfWthAgr { get; set; }

        public bool ValueEquals(IPropsTaxing other)
        {
            if (other == null)
            {
                return false;
            }
            return (this.AllowancePayer == other.AllowancePayer &&
                    this.AllowanceDisability1st == other.AllowanceDisability1st &&
                    this.AllowanceDisability2nd == other.AllowanceDisability2nd &&
                    this.AllowanceDisability3rd == other.AllowanceDisability3rd &&
                    this.AllowanceStudy == other.AllowanceStudy &&
                    this.AllowanceChild1st == other.AllowanceChild1st &&
                    this.AllowanceChild2nd == other.AllowanceChild2nd &&
                    this.AllowanceChild3rd == other.AllowanceChild3rd &&
                    this.FactorAdvances == other.FactorAdvances &&
                    this.FactorWithhold == other.FactorWithhold &&
                    this.FactorSolidary == other.FactorSolidary &&
                    this.FactorTaxRate2 == other.FactorTaxRate2 &&
                    this.MinAmountOfTaxBonus == other.MinAmountOfTaxBonus &&
                    this.MaxAmountOfTaxBonus == other.MaxAmountOfTaxBonus &&
                    this.MarginIncomeOfTaxBonus == other.MarginIncomeOfTaxBonus &&
                    this.MarginIncomeOfRounding == other.MarginIncomeOfRounding &&
                    this.MarginIncomeOfWithhold == other.MarginIncomeOfWithhold &&
                    this.MarginIncomeOfSolidary == other.MarginIncomeOfSolidary &&
                    this.MarginIncomeOfTaxRate2 == other.MarginIncomeOfTaxRate2 &&
                    this.MarginIncomeOfWthEmp == other.MarginIncomeOfWthEmp &&
                    this.MarginIncomeOfWthAgr == other.MarginIncomeOfWthAgr);
        }
        public Int32 IntTaxRoundUp(decimal valueDec)
        {
            return OperationsRound.RoundUp(valueDec);
        }
        public Int32 IntTaxRoundNearUp(decimal valueDec, Int32 nearest = 100)
        {
            return OperationsRound.NearRoundUp(valueDec, nearest);
        }
        public Int32 IntTaxRoundDown(decimal valueDec)
        {
            return OperationsRound.RoundDown(valueDec);
        }
        public Int32 IntTaxRoundNearDown(decimal valueDec, Int32 nearest = 100)
        {
            return OperationsRound.NearRoundDown(valueDec, nearest);
        }

        public decimal DecTaxRoundUp(decimal valueDec)
        {
            return OperationsRound.DecRoundUp(valueDec);
        }

        public decimal DecTaxRoundNearUp(decimal valueDec, Int32 nearest = 100)
        {
            return OperationsRound.DecNearRoundUp(valueDec, nearest);
        }
        public decimal DecTaxRoundDown(decimal valueDec)
        {
            return OperationsRound.DecRoundDown(valueDec);
        }
        public decimal DecTaxRoundNearDown(decimal valueDec, Int32 nearest = 100)
        {
            return OperationsRound.DecNearRoundDown(valueDec, nearest);
        }

        public abstract bool HasWithholdIncome(WorkTaxingTerms termOpt, TaxDeclSignOption signOpt, TaxNoneSignOption noneOpt, Int32 incomeSum);
        public Int32 BenefitAllowancePayer(TaxDeclSignOption signOption, TaxDeclBenneOption benefitOption)
        {
            Int32 benefitValue = 0;
            if (signOption == TaxDeclSignOption.DECL_TAX_DO_SIGNED)
            {
                if (benefitOption == TaxDeclBenneOption.DECL_TAX_BENEF1)
                {
                    benefitValue = AllowancePayer;
                }
            }
            return benefitValue;
        }
        public Int32 BenefitAllowanceDisability(TaxDeclSignOption signOption, TaxDeclDisabilityOption benefitOption)
        {
            Int32 benefitValue = 0;
            if (signOption == TaxDeclSignOption.DECL_TAX_DO_SIGNED)
            {
                switch (benefitOption)
                {
                    case TaxDeclDisabilityOption.DECL_TAX_DISAB1:
                        benefitValue = AllowanceDisability1st;
                        break;
                    case TaxDeclDisabilityOption.DECL_TAX_DISAB2:
                        benefitValue = AllowanceDisability2nd;
                        break;
                    case TaxDeclDisabilityOption.DECL_TAX_DISAB3:
                        benefitValue = AllowanceDisability3rd;
                        break;
                }
            }
            return benefitValue;
        }
        public Int32 BenefitAllowanceStudy(TaxDeclSignOption signOption, TaxDeclBenneOption benefitOption)
        {
            Int32 benefitValue = 0;

            if (signOption == TaxDeclSignOption.DECL_TAX_DO_SIGNED)
            {
                if (benefitOption == TaxDeclBenneOption.DECL_TAX_BENEF1)
                {
                    benefitValue = AllowanceStudy;
                }
            }
            return benefitValue;
        }
        public Int32 BenefitAllowanceChild(TaxDeclSignOption signOption, TaxDeclBenneOption benefitOption, Int32 benefitOrds, Int32 disabelOption)
        {
            Int32 benefitValue = 0;
            if (signOption == TaxDeclSignOption.DECL_TAX_DO_SIGNED)
            {
                Int32 benefitUnits = 0;
                switch (benefitOrds)
                {
                    case 0:
                        benefitUnits = AllowanceChild1st;
                        break;
                    case 1:
                        benefitUnits = AllowanceChild2nd;
                        break;
                    case 2:
                        benefitUnits = AllowanceChild3rd;
                        break;
                }
                if (benefitOption == TaxDeclBenneOption.DECL_TAX_BENEF1)
                {
                    if (disabelOption == 1)
                    {
                        benefitValue = benefitUnits * 2;
                    }
                    else
                    {
                        benefitValue = benefitUnits;
                    }
                }
            }
            return benefitValue;
        }
        public Int32 BonusChildRaw(Int32 income, Int32 benefit, Int32 rebated)
        {
            decimal bonusForChild = decimal.Negate(Math.Min(0, rebated - benefit));

            if (MarginIncomeOfTaxBonus > 0)
            {
                if (income < MarginIncomeOfTaxBonus)
                {
                    bonusForChild = 0;
                }
            }
            return OperationsRound.RoundToInt(bonusForChild);
        }
        public Int32 BonusChildFix(Int32 income, Int32 benefit, Int32 rebated)
        {
            Int32 childBonus = BonusChildRaw(income, benefit, rebated);

            if (MinAmountOfTaxBonus > 0)
            {
                if (childBonus < MinAmountOfTaxBonus)
                {
                    return 0;
                }
            }
            if (MaxAmountOfTaxBonus > 0)
            {
                if (childBonus > MaxAmountOfTaxBonus)
                {
                    return MaxAmountOfTaxBonus;
                }
            }
            return childBonus;
        }

        public Int32 TaxableIncomeSupers(Int32 incomeResult, Int32 healthResult, Int32 socialResult)
        {
            return TaxableIncomeBasis(incomeResult + healthResult + socialResult);
        }

        public Int32 TaxableIncomeBasis(Int32 incomeResult)
        {
            Int32 taxableSuper = Math.Max(0, incomeResult);
            return taxableSuper;
        }

        public Int32 RoundedBaseAdvances(Int32 incomeResult, Int32 healthResult, Int32 socialResult)
        {
            Int32 advanceBase = RoundedBaseAdvances(incomeResult + healthResult + socialResult);

            return advanceBase;
        }

        public Int32 RoundedBaseAdvances(Int32 incomeResult)
        {
            Int32 amountForCalc = TaxableIncomeBasis(incomeResult);

            Int32 advanceBase = 0;
            if (amountForCalc <= MarginIncomeOfRounding)
            {
                advanceBase = IntTaxRoundUp(amountForCalc);
            }
            else
            {
                advanceBase = IntTaxRoundNearUp(amountForCalc, 100);
            }
            return advanceBase;
        }

        public Int32 RoundedBaseSolidary(Int32 incomeResult)
        {
            Int32 solidaryBase = 0;

            Int32 taxableIncome = Math.Max(0, incomeResult);
            if (MarginIncomeOfSolidary != 0)
            {
                solidaryBase = Math.Max(0, taxableIncome - MarginIncomeOfSolidary);
            }
            return solidaryBase;
        }
        public abstract Int32 RoundedAdvancesPayment(Int32 supersResult, Int32 basisResult);
        public Int32 RoundedSolidaryPayment(Int32 basisResult)
        {
            decimal factorSolidary = OperationsDec.Divide(FactorSolidary, 100);

            Int32 solidaryTaxing = 0;
            if (MarginIncomeOfSolidary != 0)
            {
                solidaryTaxing = IntTaxRoundUp(OperationsDec.Multiply(basisResult, factorSolidary));
            }

            return solidaryTaxing;
        }
        public Int32 RoundedBaseWithhold(Int32 incomeResult)
        {
            Int32 amountForCalc = Math.Max(0, incomeResult);
            Int32 withholdBase = IntTaxRoundDown(amountForCalc);

            return withholdBase;
        }
        public Int32 RoundedWithholdPayment(Int32 supersResult, Int32 basisResult)
        {
            decimal factorWithhold = OperationsDec.Divide(FactorWithhold, 100);

            Int32 withholdTaxing = Math.Max(0, supersResult);
            if (withholdTaxing > 0)
            {
                withholdTaxing = IntTaxRoundDown(OperationsDec.Multiply(supersResult, factorWithhold));
            }
            return withholdTaxing;
        }
    }
}
