namespace LegallyCz.Tests;

public class LegallyCzTestInfoDataBaseTest : LegallyCzInfoBaseTest
{
    public LegallyCzTestInfoDataBaseTest(ITestOutputHelper outputHelper, string loggerDir, string loggerFileName) : base(outputHelper, loggerDir, loggerFileName)
    {
    }
    public static IEnumerable<object[]> GetTestData(TestScenario[] tests) =>
        tests.SelectMany((tt) => tt.tests.Select((tx) => (new object[] { tt.testTitle, tx.testName, tx.testYear, tx.testMonth, tx.resultYear })));
    public static IEnumerable<object[]> GetTestIntData(TestIntScenario[] tests) =>
        tests.SelectMany((tt) => tt.tests.Select((tx) => (new object[] { tt.testTitle, tx.testName, tx.testYear, tx.testMonth, tx.resultYear, tx.resultMonth, tx.resultValue })));
    public static IEnumerable<object[]> GetTestDecData(TestDecScenario[] tests) =>
        tests.SelectMany((tt) => tt.tests.Select((tx) => (new object[] { tt.testTitle, tx.testName, tx.testYear, tx.testMonth, tx.resultYear, tx.resultMonth, tx.resultValue })));

}
