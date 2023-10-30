using ErrorOr;
using HraveMzdy.LegallyCz.Factories;
using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Providers;
using HraveMzdy.LegallyCz.ServiceErrors;

namespace HraveMzdy.LegallyCz;

public class ServiceLegallyCz : IServiceLegallyCz
{
    private const Int16 MINIMAL_VERSION = 2010;
    private const Int16 CURRENT_VERSION = 2022;

    private readonly IServiceProvider _serviceProvider;
    public ServiceLegallyCz(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;

        Builder = new BundleBuilder(_serviceProvider, CURRENT_VERSION, MINIMAL_VERSION);
    }

    private IBundleBuilder Builder { get; }

#if __VERSIONS__
    public void AddSalaryProviders(IEnumerable<Type> providerTypes)
    {
        Builder.AddSalaryProviders(providerTypes);
    }
    public void AddHealthProviders(IEnumerable<Type> providerTypes)
    {
        Builder.AddHealthProviders(providerTypes);
    }
    public void AddSocialProviders(IEnumerable<Type> providerTypes)
    {
        Builder.AddSocialProviders(providerTypes);
    }
    public void AddTaxingProviders(IEnumerable<Type> providerTypes)
    {
        Builder.AddTaxingProviders(providerTypes);
    }
#endif
    public ErrorOr<IBundleProps> GetBundle(ILegallyPeriod period)
    {
        var resultBundle = Builder.GetBundle(period);
        if (resultBundle is not null)
        {
            if (resultBundle.PeriodProps.Code == 0)
            {
                return Errors.History.BundleEmpty(period);
            }
            if (resultBundle.PeriodProps.Code < period.Code)
            {
                return Errors.History.BundleInvalid(period);
            }
            return ErrorOrResult<IBundleProps>.Success(resultBundle);
        }
        return Errors.History.BundleNone(period);
     }
}
