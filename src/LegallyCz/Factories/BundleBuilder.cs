using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Providers;

namespace HraveMzdy.LegallyCz.Factories;

class BundleBuilder : IBundleBuilder
{
    private readonly IServiceProvider _serviceProvider;

    private readonly Int16 _minimalVersion;
    private IProviderFactory<IProviderSalary, IPropsSalary> SalaryFactory { get; }
    private IProviderFactory<IProviderHealth, IPropsHealth> HealthFactory { get; }
    private IProviderFactory<IProviderSocial, IPropsSocial> SocialFactory { get; }
    private IProviderFactory<IProviderTaxing, IPropsTaxing> TaxingFactory { get; }

    public BundleBuilder(IServiceProvider serviceProvider, Int16 defaultVersion, Int16 minimalVersion)
    {
        _serviceProvider = serviceProvider;

        _minimalVersion = minimalVersion;

        SalaryFactory = new FactorySalary(defaultVersion);
        HealthFactory = new FactoryHealth(defaultVersion);
        SocialFactory = new FactorySocial(defaultVersion);
        TaxingFactory = new FactoryTaxing(defaultVersion);
    }
    private bool IsNullOrEmpty(IProps props)
    {
        return (props is null || props.Version.Value < _minimalVersion);
    }
    private bool IsValidBundle(IProps salary, IProps health, IProps social, IProps taxing)
    {
        if (IsNullOrEmpty(salary))
        {
            return false;
        }
        if (IsNullOrEmpty(health))
        {
            return false;
        }
        if (IsNullOrEmpty(social))
        {
            return false;
        }
        if (IsNullOrEmpty(taxing))
        {
            return false;
        }
        return true;
    }
    public ILegallyRules? GetBundle(ILegallyPeriod period)
    {
        IPropsSalary salary = GetSalaryProps(period);
        IPropsHealth health = GetHealthProps(period);
        IPropsSocial social = GetSocialProps(period);
        IPropsTaxing taxing = GetTaxingProps(period);

        if (IsValidBundle(salary, health, social, taxing))
        {
            return new LegallyRules(period, salary, health, social, taxing);
        }
        return null;
    }
    private IPropsSalary GetSalaryProps(ILegallyPeriod period)
    {
        return SalaryFactory.GetProps(_serviceProvider, period);
    }
    private IPropsHealth GetHealthProps(ILegallyPeriod period)
    {
        return HealthFactory.GetProps(_serviceProvider, period);
    }
    private IPropsSocial GetSocialProps(ILegallyPeriod period)
    {
        return SocialFactory.GetProps(_serviceProvider, period);
    }
    private IPropsTaxing GetTaxingProps(ILegallyPeriod period)
    {
        return TaxingFactory.GetProps(_serviceProvider, period);
    }

#if __VERSIONS__
    public void AddSalaryProviders(IEnumerable<Type> providerTypes)
    {
        SalaryFactory.AddProviders(_serviceProvider, providerTypes);
    }

    public void AddHealthProviders(IEnumerable<Type> providerTypes)
    {
        HealthFactory.AddProviders(_serviceProvider, providerTypes);
    }

    public void AddSocialProviders(IEnumerable<Type> providerTypes)
    {
        SocialFactory.AddProviders(_serviceProvider, providerTypes);
    }

    public void AddTaxingProviders(IEnumerable<Type> providerTypes)
    {
        TaxingFactory.AddProviders(_serviceProvider, providerTypes);
    }
#endif
}
