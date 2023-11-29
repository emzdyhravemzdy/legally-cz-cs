using HraveMzdy.LegallyCz;
using HraveMzdy.LegallyCz.Attributes;
using HraveMzdy.LegallyCz.Extensions;
using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Providers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddLegallyCz(this IServiceCollection services,
        Action<LegallyCzConfiguration> configuration)
    {
        var serviceConfig = new LegallyCzConfiguration();

        configuration.Invoke(serviceConfig);

        return services.AddLegallyCz(serviceConfig);
    }
    public static IServiceCollection AddLegallyCz(this IServiceCollection services,
        LegallyCzConfiguration configuration)
    {
        AddLegallyCzServices(services, configuration);

        AddLegallyCzProviders(services, configuration);

        return services;
    }
    public static IHost UseLegallyCz(this IHost app)
    {
        var loggerFactory = app.Services.GetRequiredService<ILoggerFactory>();
        var logger = loggerFactory.CreateLogger(typeof(LegallyCzConfiguration));

        var configuration = app.Services.GetRequiredService<LegallyCzConfiguration>();
        configuration.LogDiscoveredProviderTypes(logger);

#if __VERSIONS__
        var service = app.Services.GetRequiredService<IServiceLegallyCz>();

        service.AddSalaryProviders(configuration.SalaryProviderTypes);

        service.AddHealthProviders(configuration.HealthProviderTypes);

        service.AddSocialProviders(configuration.SocialProviderTypes);

        service.AddTaxingProviders(configuration.TaxingProviderTypes);
#endif
        return app;
    }
    private static void AddLegallyCzServices(IServiceCollection services, LegallyCzConfiguration configuration)
    {
        services.AddSingleton(configuration);

        services.AddSingleton<IServiceLegallyCz, ServiceLegallyCz>();
    }
    private static void AddLegallyCzProviders(IServiceCollection services, LegallyCzConfiguration configuration)
    {
        var assemblies = configuration.AssembliesToRegister;

        if (!assemblies.Any())
        {
            throw new ArgumentException("No assemblies found to scan. Supply at least one assembly to scan for providers.");
        }

        var salaryProviders = GetSalaryProviders(configuration, assemblies);
        var healthProviders = GetHealthProviders(configuration, assemblies);
        var socialProviders = GetSocialProviders(configuration, assemblies);
        var taxingProviders = GetTaxingProviders(configuration, assemblies);

#if __VERSIONS__
        foreach (var provider in salaryProviders)
        {
            services.AddProvider(provider, configuration.ProviderLifetime);
        }
        foreach (var provider in healthProviders)
        {
            services.AddProvider(provider, configuration.ProviderLifetime);
        }
        foreach (var provider in socialProviders)
        {
            services.AddProvider(provider, configuration.ProviderLifetime);
        }
        foreach (var provider in taxingProviders)
        {
            services.AddProvider(provider, configuration.ProviderLifetime);
        }
#else
        foreach (Type providerType in salaryProviders)
        {
            HistoryVersion version = providerType.GetTypeInfo().VersionAttribute();
            services.AddKeyedProvider<IProviderSalary>(providerType, version, configuration.ProviderLifetime);
        }
        foreach (var providerType in healthProviders)
        {
            HistoryVersion version = providerType.GetTypeInfo().VersionAttribute();
            services.AddKeyedProvider<IProviderHealth>(providerType, version, configuration.ProviderLifetime);
        }
        foreach (var providerType in socialProviders)
        {
            HistoryVersion version = providerType.GetTypeInfo().VersionAttribute();
            services.AddKeyedProvider<IProviderSocial>(providerType, version, configuration.ProviderLifetime);
        }
        foreach (var providerType in taxingProviders)
        {
            HistoryVersion version = providerType.GetTypeInfo().VersionAttribute();
            services.AddKeyedProvider<IProviderTaxing>(providerType, version, configuration.ProviderLifetime);
        }
#endif
    }
    private static IEnumerable<Type> GetSalaryProviders(LegallyCzConfiguration configuration,
        IReadOnlyCollection<Assembly> assemblies)
    {
        IEnumerable<Type> providers = GetProviders<IProviderSalary>(configuration.SalaryProviderTypes, assemblies);

        return providers;
    }
    private static IEnumerable<Type> GetHealthProviders(LegallyCzConfiguration configuration,
        IReadOnlyCollection<Assembly> assemblies)
    {
        IEnumerable<Type> providers = GetProviders<IProviderHealth>(configuration.HealthProviderTypes, assemblies);

        return providers;
    }
    private static IEnumerable<Type> GetSocialProviders(LegallyCzConfiguration configuration,
        IReadOnlyCollection<Assembly> assemblies)
    {
        IEnumerable<Type> providers = GetProviders<IProviderSocial>(configuration.SocialProviderTypes, assemblies);

        return providers;
    }
    private static IEnumerable<Type> GetTaxingProviders(LegallyCzConfiguration configuration,
        IReadOnlyCollection<Assembly> assemblies)
    {
        IEnumerable<Type> providers = GetProviders<IProviderTaxing>(configuration.TaxingProviderTypes, assemblies);

        return providers;
    }
    private static IEnumerable<Type> GetProviders<TProvider>(List<Type> providerTypes, IReadOnlyCollection<Assembly> assemblies)
    {
        IEnumerable<Type> providers;
        if (providerTypes.Any())
        {
            providers = providerTypes;
        }
        else
        {
            providers = assemblies.SelectMany(x => x.GetTypes()
                .Where(t =>
                    !t.IsAbstract &&
                    typeof(TProvider).IsAssignableFrom(t) &&
                    t != typeof(TProvider)
                ));

            providerTypes.AddRange(providers);
        }

        return providers;
    }

    private static void AddKeyedProvider<TService>(this IServiceCollection services,
        Type implementationType,
        HistoryVersion version,
        ServiceLifetime lifetime)
        where TService : class
    {
        var descriptor = new ServiceDescriptor(typeof(TService), version, implementationType, lifetime);
        services.Add(descriptor);
    }

#if __VERSIONS__
    private static void AddProvider(
        this IServiceCollection services,
        Type serviceType,
        ServiceLifetime lifetime)
    {
        var descriptor = new ServiceDescriptor(serviceType, serviceType, lifetime);
        services.Add(descriptor);
    }
#endif
}