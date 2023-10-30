using HraveMzdy.LegallyCz.Providers;

namespace LegallyCz.Tests.Protokol;


public class ProtokolSalaryTest_WorkingShiftWeek : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderSalary, IPropsSalary> _sut;
    public ProtokolSalaryTest_WorkingShiftWeek(ITestOutputHelper outputHelper) : base(outputHelper, "02_Salary_01_WorkingShiftWeek.txt")
    {
        _sut = new FactorySalary(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolSalaryTest_WorkingShiftWeek>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.WorkingShiftWeek)));
        }
    }
}

public class ProtokolSalaryTest_WorkingShiftTime : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderSalary, IPropsSalary> _sut;
    public ProtokolSalaryTest_WorkingShiftTime(ITestOutputHelper outputHelper) : base(outputHelper, "02_Salary_02_WorkingShiftTime.txt")
    {
        _sut = new FactorySalary(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolSalaryTest_WorkingShiftTime>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.WorkingShiftTime)));
        }
    }
}

public class ProtokolSalaryTest_MinMonthlyWage : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderSalary, IPropsSalary> _sut;
    public ProtokolSalaryTest_MinMonthlyWage(ITestOutputHelper outputHelper) : base(outputHelper, "02_Salary_03_MinMonthlyWage.txt")
    {
        _sut = new FactorySalary(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolSalaryTest_MinMonthlyWage>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MinMonthlyWage)));
        }
    }
}

public class ProtokolSalaryTest_MinHourlyWage : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderSalary, IPropsSalary> _sut;
    public ProtokolSalaryTest_MinHourlyWage(ITestOutputHelper outputHelper) : base(outputHelper, "02_Salary_04_MinHourlyWage.txt")
    {
        _sut = new FactorySalary(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolSalaryTest_MinHourlyWage>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MinHourlyWage)));
        }
    }
}
