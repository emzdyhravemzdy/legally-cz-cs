using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Providers;

namespace HraveMzdy.LegallyCz.Factories;
using VERSION = Int16;
public class FactorySalary : ProviderFactory<IProviderSalary, IPropsSalary>
{
    public FactorySalary(VERSION defaultVersion) : base(defaultVersion)
    {
    }

    private readonly IPropsSalary emptyPeriodProps = PropsSalary.Empty();
    protected override IPropsSalary EmptyPeriodProps => emptyPeriodProps;
}
