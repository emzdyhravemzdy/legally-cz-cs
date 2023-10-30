using HraveMzdy.LegallyCz.Providers;
using Microsoft.Extensions.Logging;
using System.Text;

namespace LegallyCz.Tests;

public class LegallyCzProtokolBaseTest : LegallyCzInfoBaseTest
{
    public const string PROTOKOL_TEST_FOLDER = "LegallyCz.Tests.Protocols";

    public LegallyCzProtokolBaseTest(ITestOutputHelper outputHelper, string testSuiteFileName)
        : base(outputHelper, PROTOKOL_TEST_FOLDER, testSuiteFileName)
    {
    }

    protected ILogger CreateLoggerFile<TType>()
        where TType : class
    {
        var loggerFactory = host.Services.GetRequiredService<ILoggerFactory>();

        var logger = loggerFactory.CreateLogger(typeof(TType));

        return logger;
    }
    protected void ExportPropsLine<B, P>(ILogger testLogger, short testYear, IProviderFactory<B, P> sut, Func<P, int> func) where B : IPropsProvider<P>
    {
        var serviceProvider = host.Services.GetRequiredService<IServiceProvider>();

        StringBuilder protokol = new StringBuilder();

        ExportPropsYear(protokol, testYear);


        for (short testMonth = 1; testMonth <= 12; testMonth++)
        {
            StringBuilder hb = new StringBuilder();

            var testPeriod = new LegallyPeriod(testYear, testMonth);

            var testResult = sut.GetProps(serviceProvider, testPeriod);

            decimal testValue = 0;
            if (testResult != null)
            {
                testValue = func.Invoke(testResult);
            }
            ExportPropsValue(protokol, testValue);
        }

        testLogger.LogInformation(protokol.ToString());
    }

    protected void ExportPropsValue(StringBuilder protokol, int value)
    {
        protokol.Append(string.Format("\t{0}", value));
    }

    protected void ExportPropsLine<B, P>(ILogger testLogger, short testYear, IProviderFactory<B, P> sut, Func<P, decimal> func) where B : IPropsProvider<P>
    {
        var serviceProvider = host.Services.GetRequiredService<IServiceProvider>();

        StringBuilder protokol = new StringBuilder();

        ExportPropsYear(protokol, testYear);


        for (short testMonth = 1; testMonth <= 12; testMonth++)
        {
            StringBuilder hb = new StringBuilder();

            var testPeriod = new LegallyPeriod(testYear, testMonth);

            var testResult = sut.GetProps(serviceProvider, testPeriod);

            decimal testValue = 0;
            if (testResult != null)
            {
                testValue = func.Invoke(testResult);
            }
            ExportPropsValue(protokol, testValue);
        }

        testLogger.LogInformation(protokol.ToString());
    }

    protected void ExportPropsValue(StringBuilder protokol, decimal value)
    {
        int intValue = Convert.ToInt32(value * 100);
        protokol.Append(string.Format("\t{0}", intValue));
    }

    protected void ExportPropsYear(StringBuilder protokol, short value)
    {
        protokol.Append(string.Format("{0}", value));
    }

    protected void ExportPropsStart(ILogger testLogger)
    {
        StringBuilder protokol = new StringBuilder();

        protokol.Append(string.Format("{0}", "YEAR"));
        for (short testMonth = 1; testMonth <= 12; testMonth++)
        {
            protokol.Append(string.Format("\t{0}", testMonth));
        }
        protokol.AppendLine();

        testLogger.LogInformation(protokol.ToString());
    }
}
