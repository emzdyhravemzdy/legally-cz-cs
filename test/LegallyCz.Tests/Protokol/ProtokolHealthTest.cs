using HraveMzdy.LegallyCz.Providers;

namespace LegallyCz.Tests.Protokol;

public class ProtokolHealthTest_MinMonthlyBasis : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderHealth, IPropsHealth> _sut;
    public ProtokolHealthTest_MinMonthlyBasis(ITestOutputHelper outputHelper) : base(outputHelper, "01_Health_01_MinMonthlyBasis.txt")
    {
        _sut = new FactoryHealth(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolHealthTest_MinMonthlyBasis>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MinMonthlyBasis)));
        }
    }
}

public class ProtokolHealthTest_MaxAnnualsBasis : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderHealth, IPropsHealth> _sut;
    public ProtokolHealthTest_MaxAnnualsBasis(ITestOutputHelper outputHelper) : base(outputHelper, "01_Health_02_MaxAnnualsBasis.txt")
    {
        _sut = new FactoryHealth(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolHealthTest_MaxAnnualsBasis>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MaxAnnualsBasis)));
        }
    }
}

public class ProtokolHealthTest_LimMonthlyState : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderHealth, IPropsHealth> _sut;
    public ProtokolHealthTest_LimMonthlyState(ITestOutputHelper outputHelper) : base(outputHelper, "01_Health_03_LimMonthlyState.txt")
    {
        _sut = new FactoryHealth(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolHealthTest_LimMonthlyState>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.LimMonthlyState)));
        }
    }
}

public class ProtokolHealthTest_LimMonthlyDis50 : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderHealth, IPropsHealth> _sut;
    public ProtokolHealthTest_LimMonthlyDis50(ITestOutputHelper outputHelper) : base(outputHelper, "01_Health_04_LimMonthlyDis50.txt")
    {
        _sut = new FactoryHealth(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolHealthTest_LimMonthlyDis50>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.LimMonthlyDis50)));
        }
    }
}

public class ProtokolHealthTest_FactorCompound : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderHealth, IPropsHealth> _sut;
    public ProtokolHealthTest_FactorCompound(ITestOutputHelper outputHelper) : base(outputHelper, "01_Health_05_FactorCompound.txt")
    {
        _sut = new FactoryHealth(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolHealthTest_FactorCompound>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.FactorCompound)));
        }
    }
}

public class ProtokolHealthTest_FactorEmployee : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderHealth, IPropsHealth> _sut;
    public ProtokolHealthTest_FactorEmployee(ITestOutputHelper outputHelper) : base(outputHelper, "01_Health_06_FactorEmployee.txt")
    {
        _sut = new FactoryHealth(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolHealthTest_FactorEmployee>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.FactorEmployee)));
        }
    }
}

public class ProtokolHealthTest_MarginIncomeEmp : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderHealth, IPropsHealth> _sut;
    public ProtokolHealthTest_MarginIncomeEmp(ITestOutputHelper outputHelper) : base(outputHelper, "01_Health_07_MarginIncomeEmp.txt")
    {
        _sut = new FactoryHealth(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolHealthTest_MarginIncomeEmp>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MarginIncomeEmp)));
        }
    }
}

public class ProtokolHealthTest_MarginIncomeAgr : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderHealth, IPropsHealth> _sut;
    public ProtokolHealthTest_MarginIncomeAgr(ITestOutputHelper outputHelper) : base(outputHelper, "01_Health_08_MarginIncomeAgr.txt")
    {
        _sut = new FactoryHealth(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolHealthTest_MarginIncomeAgr>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MarginIncomeAgr)));
        }
    }
}
