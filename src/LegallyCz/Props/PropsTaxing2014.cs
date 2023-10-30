﻿using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.MathOperations;
using HraveMzdy.LegallyCz.Types;

namespace HraveMzdy.LegallyCz.Props;

public class PropsTaxing2014 : PropsTaxingBase, IPropsTaxing
{
    public static IPropsTaxing Empty()
    {
        return new PropsTaxing2014(VERSION_ZERO);
    }
    public PropsTaxing2014(Int16 version) : base(version)
    {
    }
    public PropsTaxing2014(IVersionId version,
        Int32 allowancePayer,
        Int32 allowanceDisability1st, Int32 allowanceDisability2nd, Int32 allowanceDisability3rd,
        Int32 allowanceStudy,
        Int32 allowanceChild1st, Int32 allowanceChild2nd, Int32 allowanceChild3rd,
        decimal factorAdvances, decimal factorWithhold,
        decimal factorSolidary, decimal factorTaxRate2,
        Int32 minAmountOfTaxBonus, Int32 maxAmountOfTaxBonus, Int32 marginIncomeOfTaxBonus,
        Int32 marginIncomeOfRounding, Int32 marginIncomeOfWithhold,
        Int32 marginIncomeOfSolidary, Int32 marginIncomeOfTaxRate2,
        Int32 marginIncomeOfWthEmp, Int32 marginIncomeOfWthAgr)
        : base(version, 
            allowancePayer, 
            allowanceDisability1st, allowanceDisability2nd, allowanceDisability3rd,
            allowanceStudy,
            allowanceChild1st, allowanceChild2nd, allowanceChild3rd,
            factorAdvances, factorWithhold, 
            factorSolidary, factorTaxRate2,
            minAmountOfTaxBonus, maxAmountOfTaxBonus, 
            marginIncomeOfTaxBonus,
            marginIncomeOfRounding, marginIncomeOfWithhold,
            marginIncomeOfSolidary, marginIncomeOfTaxRate2,
            marginIncomeOfWthEmp, marginIncomeOfWthAgr)
    { 
    }

    public override bool HasWithholdIncome(WorkTaxingTerms termOpt, TaxDeclSignOption signOpt, TaxNoneSignOption noneOpt, int incomeSum)
    {
        //*****************************************************************************
        // Tax income for advance from Year 2014 to Year 2017
        //*****************************************************************************
        // - withhold tax (non-signed declaration) and income
        // if (period.Year >= 2014 && period.Year =< 2017)
        // -- income from DPP is less than X CZK
        // -- income from statutory employment and non-resident is always withhold tax

        bool withholdIncome = false;
        if (signOpt != TaxDeclSignOption.DECL_TAX_NO_SIGNED)
        {
            return withholdIncome;
        }
        if (noneOpt != TaxNoneSignOption.NOSIGN_TAX_WITHHOLD)
        {
            return withholdIncome;
        }
        if (termOpt == WorkTaxingTerms.TAXING_TERM_AGREEM_TASK)
        {
            if (MarginIncomeOfWthAgr == 0 || incomeSum <= MarginIncomeOfWthAgr)
            {
                if (incomeSum > 0)
                {
                    withholdIncome = true;
                }
            }
        }
        else if (termOpt == WorkTaxingTerms.TAXING_TERM_STATUT_PART)
        {
            if (incomeSum > 0)
            {
                withholdIncome = true;
            }
        }
        return withholdIncome;
    }
    public override Int32 RoundedAdvancesPayment(Int32 supersResult, Int32 basisResult)
    {
        decimal factorAdvances = OperationsDec.Divide(FactorAdvances, 100);

        Int32 advanceTaxing = 0;
        if (basisResult <= MarginIncomeOfRounding)
        {
            advanceTaxing = IntTaxRoundUp(OperationsDec.Multiply(supersResult, factorAdvances));
        }
        else
        {
            advanceTaxing = IntTaxRoundUp(OperationsDec.Multiply(supersResult, factorAdvances));
        }

        return advanceTaxing;
    }
}
