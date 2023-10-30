using ErrorOr;
using HraveMzdy.LegallyCz.Providers;

namespace HraveMzdy.LegallyCz.Interfaces;

public interface IServiceLegallyCz
{
#if __VERSIONS__
    void AddSalaryProviders(IEnumerable<Type> providerTypes);
    void AddHealthProviders(IEnumerable<Type> providerTypes);
    void AddSocialProviders(IEnumerable<Type> providerTypes);
    void AddTaxingProviders(IEnumerable<Type> providerTypes);
#endif
    ErrorOr<IBundleProps> GetBundle(ILegallyPeriod period);
}
