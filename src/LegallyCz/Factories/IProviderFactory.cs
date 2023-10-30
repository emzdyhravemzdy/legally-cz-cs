using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Providers;

namespace HraveMzdy.LegallyCz.Factories;

public interface IProviderFactory<B, P> where B : IPropsProvider<P>
{
    P GetProps(IServiceProvider serviceProvider, ILegallyPeriod period);
#if __VERSIONS__
    void AddProviders(IServiceProvider serviceProvider, IEnumerable<Type> providerTypes);
#endif
}
