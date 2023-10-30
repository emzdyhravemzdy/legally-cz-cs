using Microsoft.Extensions.Logging;
using System.Text;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace LegallyCz.Tests.Service;

[CollectionDefinition("TestEngine")]
public class Service_LegallyCz_Example_BaseTest : LegallyCzTestInfoDataBaseTest
{
    public const string EXAMPLE_TEST_FOLDER = "LegallyCz.Tests.Histories";

    public Service_LegallyCz_Example_BaseTest(ITestOutputHelper outputHelper, string testSuiteFileName)
        : base(outputHelper, EXAMPLE_TEST_FOLDER, testSuiteFileName)
    {
    }

    protected ILogger CreateLoggerFile<TType>() 
        where TType : class
    {
        var loggerFactory = host.Services.GetRequiredService<ILoggerFactory>();

        var logger = loggerFactory.CreateLogger(typeof(TType));

        return logger;
    }
    protected void LogExampleYear(StringBuilder protokol, string value)
    {
        protokol.Append(string.Format("{0}", value));
    }

    protected void LogExampleStart(StringBuilder protokol)
    {
        protokol.Append(string.Format("{0}", "YEAR"));
        for (Int16 testMonth = 1; testMonth <= 12; testMonth++)
        {
            protokol.Append(string.Format("\t{0}", testMonth));
        }
    }

    protected void LogTestExamples(ILogger testLogger, TestIntScenario[] tests)
    {
        StringBuilder hb = new StringBuilder();
        LogExampleStart(hb);
        testLogger.LogInformation(hb.ToString());

        foreach (var tx in tests)
        {
            StringBuilder sb = new StringBuilder();

            LogExampleYear(sb, tx.testTitle);

            foreach (var tt in tx.tests)
            {
                LogExampleValue(sb, tt.resultValue);
            }

            testLogger.LogInformation(sb.ToString());
        }
    }
    protected void LogExampleValue(StringBuilder protokol, Int32 resultValue)
    {
        protokol.Append(string.Format("\t{0}", resultValue));
    }
    protected void LogTestExamples(ILogger testLogger, TestDecScenario[] tests)
    {
        StringBuilder hb = new StringBuilder();
        LogExampleStart(hb);
        testLogger.LogInformation(hb.ToString());

        foreach (var tx in tests)
        {
            StringBuilder sb = new StringBuilder();

            LogExampleYear(sb, tx.testTitle);

            foreach (var tt in tx.tests)
            {
                LogExampleValue(sb, tt.resultValue);
            }

            testLogger.LogInformation(sb.ToString());
        }
    }
    protected void LogExampleValue(StringBuilder protokol, decimal resultValue)
    {
        Int32 intValue = Convert.ToInt32(resultValue * 100);
        protokol.Append(string.Format("\t{0}", intValue));
    }
}
