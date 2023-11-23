using HraveMzdy.LegallyCz.Attributes;
using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Providers;
using Microsoft.Extensions.DependencyInjection;
#if __VERSIONS__
using System.Collections.Immutable;
#endif

namespace HraveMzdy.LegallyCz.Factories;
using VERSION = Int16;

public abstract class ProviderFactory<B, P> : IProviderFactory<B, P>
    where B : class, IPropsProvider<P>
{
    private readonly VERSION _defaultVersion;
    public ProviderFactory(VERSION defaultVersion)
    {
        _defaultVersion = defaultVersion;
    }

    protected abstract P EmptyPeriodProps { get; }

#if __VERSIONS__
    private IReadOnlyDictionary<VERSION, Type> Versions { get; set; } = ImmutableDictionary<VERSION, Type>.Empty;
    private Type? GetProviderType(ILegallyPeriod period)
    {
        if (period.Year > _defaultVersion)
        {
            return Versions.GetValueOrDefault(_defaultVersion);
        }
        return Versions.GetValueOrDefault(period.Year);
    }
    public void AddProviders(IServiceProvider serviceProvider, IEnumerable<Type> providerTypes)
    {
        this.Versions = providerTypes.Select(pt => (pt, (B?)serviceProvider.GetService(pt)))
            .Where(pair => (pair.Item2 is not null))
            .ToImmutableDictionary(pair => pair.Item2!.Version.Value, pair => pair.Item1);
    }
    public P GetProps(IServiceProvider serviceProvider, ILegallyPeriod period)
    {
        Type? providerType = GetProviderType(period);
        if (providerType is null)
        {
            return EmptyPeriodProps;
        }

        if (serviceProvider.GetRequiredService(providerType) is not B provider)
        {
            return EmptyPeriodProps;
        }
        return provider.GetProps(period);
    }
#else
    public P GetProps(IServiceProvider serviceProvider, ILegallyPeriod period)
    {
        HistoryVersion historyVersion = new HistoryVersion(period.Year);
        if (historyVersion.Version > _defaultVersion)
        {
            historyVersion = new HistoryVersion(_defaultVersion);
        }
        if (serviceProvider.GetKeyedService<B>(historyVersion) is not B provider)
        {
            return EmptyPeriodProps;
        }
        return provider.GetProps(period);
    }
#endif

}
