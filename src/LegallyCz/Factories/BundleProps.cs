using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;

namespace HraveMzdy.LegallyCz.Factories;

public class BundleProps : IBundleProps
{
    public BundleProps(ILegallyPeriod period,
        IPropsSalary salary,
        IPropsHealth health,
        IPropsSocial social,
        IPropsTaxing taxing)
    {
        PeriodProps = (ILegallyPeriod)period.Clone();
        SalaryProps = salary;
        HealthProps = health;
        SocialProps = social;
        TaxingProps = taxing;
    }
    public ILegallyPeriod PeriodProps { get; }
    public IPropsSalary SalaryProps { get; }
    public IPropsHealth HealthProps { get; }
    public IPropsSocial SocialProps { get; }
    public IPropsTaxing TaxingProps { get; }
    public static IBundleProps Empty(ILegallyPeriod period)
    {
        return new BundleProps(period,
            PropsSalary.Empty(),
            PropsHealth.Empty(),
            PropsSocial2010.Empty(),
            PropsTaxing.Empty());
    }
}
