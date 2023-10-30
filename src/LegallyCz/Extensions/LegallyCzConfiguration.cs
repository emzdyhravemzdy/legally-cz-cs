using HraveMzdy.LegallyCz.Providers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace HraveMzdy.LegallyCz.Extensions;

public class LegallyCzConfiguration
{
    /// <summary>
    /// Service lifetime to register services under. Default value is <see cref="ServiceLifetime.Transient"/>
    /// </summary>
    public ServiceLifetime ProviderLifetime { get; set; } = ServiceLifetime.Transient;

    internal List<Assembly> AssembliesToRegister { get; } = new();
    internal List<Type> SalaryProviderTypes { get; } = new();
    internal List<Type> HealthProviderTypes { get; } = new();
    internal List<Type> SocialProviderTypes { get; } = new();
    internal List<Type> TaxingProviderTypes { get; } = new();

    public LegallyCzConfiguration WithProvidersLifetime(ServiceLifetime _providerLifetime)
    {
        ProviderLifetime = _providerLifetime;
        return this;
    }
    public LegallyCzConfiguration RegisterServicesFromAssemblyContaining<T>()
        => RegisterServicesFromAssemblyContaining(typeof(T));

    public LegallyCzConfiguration RegisterServicesFromAssemblyContaining(Type type)
        => RegisterServicesFromAssembly(type.Assembly);

    public LegallyCzConfiguration RegisterServicesFromAssembly(Assembly assembly)
    {
        AssembliesToRegister.Add(assembly);

        return this;
    }
    public LegallyCzConfiguration RegisterServicesFromAssemblies(
        params Assembly[] assemblies)
    {
        AssembliesToRegister.AddRange(assemblies);

        return this;
    }
    public LegallyCzConfiguration WithSalaryProvider<TProvider>() where TProvider : IProviderSalary
    {
        this.SalaryProviderTypes.Add(typeof(TProvider));
        return this;
    }
    public LegallyCzConfiguration WithHealthProvider<TProvider>() where TProvider : IProviderHealth
    {
        this.HealthProviderTypes.Add(typeof(TProvider));
        return this;
    }
    public LegallyCzConfiguration WithSocialProvider<TProvider>() where TProvider : IProviderSocial
    {
        this.SocialProviderTypes.Add(typeof(TProvider));
        return this;
    }
    public LegallyCzConfiguration WithTaxingProvider<TProvider>() where TProvider : IProviderTaxing
    {
        this.TaxingProviderTypes.Add(typeof(TProvider));
        return this;
    }

    public LegallyCzConfiguration WithSalaryProviders(params Type[] providers)
    {
        providers.MustDeriveFrom<IProviderSalary>();
        this.SalaryProviderTypes.AddRange(providers);
        return this;
    }

    public LegallyCzConfiguration WithHealthProviders(params Type[] providers)
    {
        providers.MustDeriveFrom<IProviderHealth>();
        this.SalaryProviderTypes.AddRange(providers);
        return this;
    }

    public LegallyCzConfiguration WithSocialProviders(params Type[] providers)
    {
        providers.MustDeriveFrom<IProviderSocial>();
        this.SalaryProviderTypes.AddRange(providers);
        return this;
    }

    public LegallyCzConfiguration WithTaxingProviders(params Type[] providers)
    {
        providers.MustDeriveFrom<IProviderTaxing>();
        this.SalaryProviderTypes.AddRange(providers);
        return this;
    }
    internal void LogDiscoveredProviderTypes(ILogger logger)
    {
        foreach (var provider in this.SalaryProviderTypes)
        {
            logger.LogDebug("Found IProviderSalary {ProviderName}", provider.Name);
        }

        foreach (var provider in this.HealthProviderTypes)
        {
            logger.LogDebug("Found IProviderHealth {ProviderName}", provider.Name);
        }

        foreach (var provider in this.SocialProviderTypes)
        {
            logger.LogDebug("Found IProviderSocial {ProviderName}", provider.Name);
        }

        foreach (var provider in this.TaxingProviderTypes)
        {
            logger.LogDebug("Found IProviderTaxing {ProviderName}", provider.Name);
        }
    }
}
