using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Props;
using HraveMzdy.LegallyCz.Providers;

namespace HraveMzdy.LegallyCz.Factories;
using VERSION = Int16;
public class FactorySocial : ProviderFactory<IProviderSocial, IPropsSocial>
{
    public FactorySocial(VERSION defaultVersion) : base(defaultVersion)
    {
    }

    private readonly IPropsSocial emptyPeriodProps = PropsSocial.Empty();
    protected override IPropsSocial EmptyPeriodProps => emptyPeriodProps;
}
