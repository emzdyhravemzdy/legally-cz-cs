using HraveMzdy.LegallyCz.Interfaces;

namespace HraveMzdy.LegallyCz.Providers;

public interface IProviderTaxing : IPropsProvider<IPropsTaxing>
{
    Int32 AllowancePayer(ILegallyPeriod period);
    Int32 AllowanceDisability1st(ILegallyPeriod period);
    Int32 AllowanceDisability2nd(ILegallyPeriod period);
    Int32 AllowanceDisability3rd(ILegallyPeriod period);
    Int32 AllowanceStudy(ILegallyPeriod period);
    Int32 AllowanceChild1st(ILegallyPeriod period);
    Int32 AllowanceChild2nd(ILegallyPeriod period);
    Int32 AllowanceChild3rd(ILegallyPeriod period);
    decimal FactorAdvances(ILegallyPeriod period);
    decimal FactorWithhold(ILegallyPeriod period);
    decimal FactorSolidary(ILegallyPeriod period);
    Int32 MinAmountOfTaxBonus(ILegallyPeriod period);
    Int32 MaxAmountOfTaxBonus(ILegallyPeriod period);
    Int32 MarginIncomeOfTaxBonus(ILegallyPeriod period);
    Int32 MarginIncomeOfRounding(ILegallyPeriod period);
    Int32 MarginIncomeOfWithhold(ILegallyPeriod period);
    Int32 MarginIncomeOfSolidary(ILegallyPeriod period);
    Int32 MarginIncomeOfWthEmp(ILegallyPeriod period);
    Int32 MarginIncomeOfWthAgr(ILegallyPeriod period);
}
