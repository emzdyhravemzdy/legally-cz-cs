using Microsoft.Extensions.Hosting;
using Serilog;

namespace LegallyCz.Tests;

public class LegallyCzInfoBaseTest
{
    public const Int16 CURRENT_VERSION = 2022;

    protected readonly IHost host;
    protected readonly IServiceLegallyCz service;
    public LegallyCzInfoBaseTest(ITestOutputHelper outputHelper, string loggerDir, string loggerFileName,
        [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "")
    {
        string testOutputFolder = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(sourceFilePath) ?? "", "..", loggerDir));

        var builder = new HostBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddLegallyCz(cfg => cfg.WithProvidersLifetime(ServiceLifetime.Singleton)
                    .RegisterServicesFromAssembly(HraveMzdy.LegallyCz.Providers.AssemblyReference.Assembly));

                services.AddLogging(loggingBuilder =>
                    loggingBuilder.AddSerilog(new LoggerConfiguration()
                        .MinimumLevel.Information()
                        .WriteTo.File(Path.Combine(testOutputFolder, loggerFileName), 
                            outputTemplate: "{Message:lj}{NewLine}{Exception}", 
                            rollingInterval: RollingInterval.Infinite)
                        .CreateLogger(), 
                        dispose: true));
            });

        host = builder.Build();

        host.UseLegallyCz();

        service = host.Services.GetRequiredService<IServiceLegallyCz>();
    }
}
