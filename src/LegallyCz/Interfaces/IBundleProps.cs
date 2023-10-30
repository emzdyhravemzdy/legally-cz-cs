namespace HraveMzdy.LegallyCz.Interfaces;

public interface IBundleProps
{
    ILegallyPeriod PeriodProps { get; }
    IPropsSalary SalaryProps { get; }
    IPropsHealth HealthProps { get; }
    IPropsSocial SocialProps { get; }
    IPropsTaxing TaxingProps { get; }
}
