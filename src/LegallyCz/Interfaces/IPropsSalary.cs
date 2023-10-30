namespace HraveMzdy.LegallyCz.Interfaces;

public interface IPropsSalary : IProps
{
    Int32 WorkingShiftWeek { get; }
    Int32 WorkingShiftTime { get; }
    Int32 MinMonthlyWage { get; }
    Int32 MinHourlyWage { get; }
    bool ValueEquals(IPropsSalary other);
    decimal CoeffWithPartAndFullHours(decimal fullWorkHours, decimal partWorkHours);
    decimal PaymentWithMonthlyAndFullWeekAndFullAndWorkHours(decimal amountMonthly,
        Int32 fullWeekHours, Int32 partWeekHours,
        Int32 fullWorkHours, Int32 partWorkHours);
    decimal PaymentRoundUpWithMonthlyAndFullWeekAndFullAndWorkHours(decimal amountMonthly,
        Int32 fullWeekHours, Int32 partWeekHours,
        Int32 fullWorkHours, Int32 partWorkHours);
    decimal PaymentWithMonthlyAndCoeffAndFullAndWorkHours(decimal amountMonthly,
        decimal monthlyCoeff, Int32 fullWorkHours, Int32 partWorkHours);
    decimal PaymentRoundUpWithMonthlyAndCoeffAndFullAndWorkHours(decimal amountMonthly,
        decimal monthlyCoeff, Int32 fullWorkHours, Int32 partWorkHours);
    decimal PaymentWithMonthlyAndCoeffAndWorkCoeff(decimal amountMonthly,
        decimal monthlyCoeff, decimal workingCoeff);
    decimal PaymentRoundUpWithMonthlyAndCoeffAndWorkCoeff(decimal amountMonthly,
        decimal monthlyCoeff, decimal workingCoeff);
    decimal RelativeAmountWithMonthlyAndCoeffAndWorkCoeff(decimal amountMonthly,
        decimal monthlyCoeff, decimal workingCoeff);
    decimal RelativeTariffWithMonthlyAndCoeffAndWorkCoeff(decimal amountMonthly,
        decimal monthlyCoeff, decimal workingCoeff);
    decimal RelativePaymentWithMonthlyAndCoeffAndWorkCoeff(decimal amountMonthly,
        decimal monthlyCoeff, decimal workingCoeff);
    decimal RevertedAmountWithMonthlyAndCoeffAndWorkCoeff(decimal amountMonthly,
        decimal monthlyCoeff, decimal workingCoeff);
    decimal RevertedTariffWithMonthlyAndCoeffAndWorkCoeff(decimal amountMonthly,
        decimal monthlyCoeff, decimal workingCoeff);
    decimal RevertedPaymentWithMonthlyAndCoeffAndWorkCoeff(decimal amountMonthly,
        decimal monthlyCoeff, decimal workingCoeff);
    decimal PaymentWithTariffAndUnits(decimal tariffPerUnit, decimal workingsUnits);
    decimal PaymentRoundUpWithTariffAndUnits(decimal tariffPerUnit, decimal workingsUnits);
    decimal PaymentRoundDownWithTariffAndUnits(decimal tariffPerUnit, decimal workingsUnits);
    decimal TariffWithPaymentAndUnits(decimal amountPerUnit, decimal workingsUnits);
    decimal PaymentWithAmountFixed(decimal amountFixed);
    decimal PaymentRoundUpWithAmountFixed(decimal amountFixed);
    decimal HoursToHalfHoursUp(decimal hoursValue);
    decimal HoursToQuartHoursUp(decimal hoursValue);
    decimal HoursToHalfHoursDown(decimal hoursValue);
    decimal HoursToQuartHoursDown(decimal hoursValue);
    decimal HoursToHalfHoursNorm(decimal hoursValue);
    decimal HoursToQuartHoursNorm(decimal hoursValue);
    decimal MoneyToRoundDown(decimal moneyValue);
    decimal MoneyToRoundUp(decimal moneyValue);
    decimal MoneyToRoundNorm(decimal moneyValue);
}
