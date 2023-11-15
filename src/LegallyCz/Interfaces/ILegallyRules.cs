namespace HraveMzdy.LegallyCz.Interfaces;

public interface ILegallyRules
{
    ILegallyPeriod Period { get; }
    IPropsSalary SalaryProps { get; }
    IPropsHealth HealthProps { get; }
    IPropsSocial SocialProps { get; }
    IPropsTaxing TaxingProps { get; }
}
