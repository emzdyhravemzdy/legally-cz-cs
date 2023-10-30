using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LegallyCz.Tests;
public class LegallyCzBaseTest
{
    public const Int16 CURRENT_VERSION = 2022;

    protected readonly IHost host;
    protected readonly IServiceLegallyCz service;
    public LegallyCzBaseTest(ITestOutputHelper outputHelper)
    {
        var builder = new HostBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddLegallyCz(cfg => cfg.WithProvidersLifetime(ServiceLifetime.Singleton)
                    .RegisterServicesFromAssembly(HraveMzdy.LegallyCz.Providers.AssemblyReference.Assembly));
                services.AddLogging(b =>
                {
                    b.AddXUnit(outputHelper, x => x.IncludeScopes = true);
                    b.SetMinimumLevel(LogLevel.Debug);
                });
            });

        host = builder.Build();

        host.UseLegallyCz();

        service = host.Services.GetRequiredService<IServiceLegallyCz>();
    }
}
