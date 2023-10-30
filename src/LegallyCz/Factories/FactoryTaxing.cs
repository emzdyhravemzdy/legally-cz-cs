using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Providers;

namespace HraveMzdy.LegallyCz.Factories;
using VERSION = Int16;
public class FactoryTaxing : ProviderFactory<IProviderTaxing, IPropsTaxing>
{
    public FactoryTaxing(VERSION defaultVersion) : base(defaultVersion)
    {
    }

    private readonly IPropsTaxing emptyPeriodProps = PropsTaxing.Empty();
    protected override IPropsTaxing EmptyPeriodProps => emptyPeriodProps;
}
