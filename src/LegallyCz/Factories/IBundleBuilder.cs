using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Providers;

namespace HraveMzdy.LegallyCz.Factories;

interface IBundleBuilder
{
#if __VERSIONS__
    void AddSalaryProviders(IEnumerable<Type> providerTypes);
    void AddHealthProviders(IEnumerable<Type> providerTypes);
    void AddSocialProviders(IEnumerable<Type> providerTypes);
    void AddTaxingProviders(IEnumerable<Type> providerTypes);
#endif
    IBundleProps? GetBundle(ILegallyPeriod period);
}
