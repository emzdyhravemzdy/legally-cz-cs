using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;

namespace HraveMzdy.LegallyCz.Factories;

public class LegallyRules : ILegallyRules
{
    public LegallyRules(ILegallyPeriod period,
        IPropsSalary salary,
        IPropsHealth health,
        IPropsSocial social,
        IPropsTaxing taxing)
    {
        Period = (ILegallyPeriod)period.Clone();
        SalaryProps = salary;
        HealthProps = health;
        SocialProps = social;
        TaxingProps = taxing;
    }
    public ILegallyPeriod Period { get; }
    public IPropsSalary SalaryProps { get; }
    public IPropsHealth HealthProps { get; }
    public IPropsSocial SocialProps { get; }
    public IPropsTaxing TaxingProps { get; }
    public static ILegallyRules Empty(ILegallyPeriod period)
    {
        return new LegallyRules(period,
            PropsSalary.Empty(),
            PropsHealth.Empty(),
            PropsSocial2010.Empty(),
            PropsTaxing.Empty());
    }
}
