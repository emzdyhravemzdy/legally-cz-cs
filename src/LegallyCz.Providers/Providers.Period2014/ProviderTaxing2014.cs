﻿using HraveMzdy.LegallyCz.Attributes;
using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Providers.Period2014;

namespace HraveMzdy.LegallyCz.Providers;

[HistoryVersion(HistoryConstTaxing2014.VERSION_CODE)]
public class ProviderTaxing2014 : ProviderBase, IProviderTaxing
{
    public ProviderTaxing2014() : base(HistoryConstTaxing2014.VERSION_CODE)
    {
    }

    public IPropsTaxing GetProps(ILegallyPeriod period)
    {
        return new PropsTaxing2014(Version,
            AllowancePayer(period),
            AllowanceDisability1st(period),
            AllowanceDisability2nd(period),
            AllowanceDisability3rd(period),
            AllowanceStudy(period),
            AllowanceChild1st(period),
            AllowanceChild2nd(period),
            AllowanceChild3rd(period),
            FactorAdvances(period),
            FactorWithhold(period),
            FactorSolidary(period),
            FactorTaxRate2(period),
            MinAmountOfTaxBonus(period),
            MaxAmountOfTaxBonus(period),
            MarginIncomeOfTaxBonus(period),
            MarginIncomeOfRounding(period),
            MarginIncomeOfWithhold(period),
            MarginIncomeOfSolidary(period),
            MarginIncomeOfTaxRate2(period),
            MarginIncomeOfWthEmp(period),
            MarginIncomeOfWthAgr(period));
    }

    public Int32 AllowancePayer(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.ALLOWANCE_PAYER;
    }
    public Int32 AllowanceDisability1st(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.ALLOWANCE_DISAB_1ST;
    }
    public Int32 AllowanceDisability2nd(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.ALLOWANCE_DISAB_2ND;
    }
    public Int32 AllowanceDisability3rd(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.ALLOWANCE_DISAB_3RD;
    }
    public Int32 AllowanceStudy(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.ALLOWANCE_STUDY;
    }
    public Int32 AllowanceChild1st(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.ALLOWANCE_CHILD_1ST;
    }
    public Int32 AllowanceChild2nd(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.ALLOWANCE_CHILD_2ND;
    }
    public Int32 AllowanceChild3rd(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.ALLOWANCE_CHILD_3RD;
    }
    public decimal FactorAdvances(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.FACTOR_ADVANCES;
    }
    public decimal FactorWithhold(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.FACTOR_WITHHOLD;
    }
    public decimal FactorSolidary(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.FACTOR_SOLIDARY;
    }
    public decimal FactorTaxRate2(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.FACTOR_TAXRATE2;
    }
    public Int32 MinAmountOfTaxBonus(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.MIN_AMOUNT_OF_TAXBONUS;
    }
    public Int32 MaxAmountOfTaxBonus(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.MAX_AMOUNT_OF_TAXBONUS;
    }
    public Int32 MarginIncomeOfTaxBonus(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.MARGIN_INCOME_OF_TAXBONUS;
    }
    public Int32 MarginIncomeOfRounding(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.MARGIN_INCOME_OF_ROUNDING;
    }
    public Int32 MarginIncomeOfWithhold(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.MARGIN_INCOME_OF_WITHHOLD;
    }
    public Int32 MarginIncomeOfSolidary(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.MARGIN_INCOME_OF_SOLIDARY;
    }
    public Int32 MarginIncomeOfTaxRate2(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.MARGIN_INCOME_OF_TAXRATE2;
    }
    public Int32 MarginIncomeOfWthEmp(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.MARGIN_INCOME_OF_WHT_EMP;
    }
    public Int32 MarginIncomeOfWthAgr(ILegallyPeriod period)
    {
        return HistoryConstTaxing2014.MARGIN_INCOME_OF_WHT_AGR;
    }
}