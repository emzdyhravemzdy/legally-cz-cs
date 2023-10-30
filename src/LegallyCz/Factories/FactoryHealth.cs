using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Providers;

namespace HraveMzdy.LegallyCz.Factories;
using VERSION = Int16;
public class FactoryHealth : ProviderFactory<IProviderHealth, IPropsHealth>
{
    public FactoryHealth(VERSION defaultVersion) : base(defaultVersion)
    {
    }

    private readonly IPropsHealth emptyPeriodProps = PropsHealth.Empty();
    protected override IPropsHealth EmptyPeriodProps => emptyPeriodProps;
}
