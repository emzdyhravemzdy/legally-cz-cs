using HraveMzdy.LegallyCz.Providers;

namespace LegallyCz.Tests.Protokol;

public class ProtokolSocialTest_MaxAnnualsBasis : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderSocial, IPropsSocial> _sut;
    public ProtokolSocialTest_MaxAnnualsBasis(ITestOutputHelper outputHelper) : base(outputHelper, "03_Social_01_MaxAnnualsBasis.txt")
    {
        _sut = new FactorySocial(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolSocialTest_MaxAnnualsBasis>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MaxAnnualsBasis)));
        }
    }
}

public class ProtokolSocialTest_FactorEmployer : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderSocial, IPropsSocial> _sut;
    public ProtokolSocialTest_FactorEmployer(ITestOutputHelper outputHelper) : base(outputHelper, "03_Social_02_FactorEmployer.txt")
    {
        _sut = new FactorySocial(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolSocialTest_FactorEmployer>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.FactorEmployer)));
        }
    }
}

public class ProtokolSocialTest_FactorEmployerHigher : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderSocial, IPropsSocial> _sut;
    public ProtokolSocialTest_FactorEmployerHigher(ITestOutputHelper outputHelper) : base(outputHelper, "03_Social_03_FactorEmployerHigher.txt")
    {
        _sut = new FactorySocial(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolSocialTest_FactorEmployerHigher>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.FactorEmployerHigher)));
        }
    }
}

public class ProtokolSocialTest_FactorEmployee : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderSocial, IPropsSocial> _sut;
    public ProtokolSocialTest_FactorEmployee(ITestOutputHelper outputHelper) : base(outputHelper, "03_Social_04_FactorEmployee.txt")
    {
        _sut = new FactorySocial(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolSocialTest_FactorEmployee>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.FactorEmployee)));
        }
    }
}

public class ProtokolSocialTest_FactorEmployeeGarant : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderSocial, IPropsSocial> _sut;
    public ProtokolSocialTest_FactorEmployeeGarant(ITestOutputHelper outputHelper) : base(outputHelper, "03_Social_05_FactorEmployeeGarant.txt")
    {
        _sut = new FactorySocial(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolSocialTest_FactorEmployeeGarant>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.FactorEmployeeGarant)));
        }
    }
}

public class ProtokolSocialTest_FactorEmployeeReduce : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderSocial, IPropsSocial> _sut;
    public ProtokolSocialTest_FactorEmployeeReduce(ITestOutputHelper outputHelper) : base(outputHelper, "03_Social_06_FactorEmployeeReduce.txt")
    {
        _sut = new FactorySocial(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolSocialTest_FactorEmployeeReduce>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.FactorEmployeeReduce)));
        }
    }
}

public class ProtokolSocialTest_MarginIncomeEmp : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderSocial, IPropsSocial> _sut;
    public ProtokolSocialTest_MarginIncomeEmp(ITestOutputHelper outputHelper) : base(outputHelper, "03_Social_07_MarginIncomeEmp.txt")
    {
        _sut = new FactorySocial(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolSocialTest_MarginIncomeEmp>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MarginIncomeEmp)));
        }
    }
}

public class ProtokolSocialTest_MarginIncomeAgr : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderSocial, IPropsSocial> _sut;
    public ProtokolSocialTest_MarginIncomeAgr(ITestOutputHelper outputHelper) : base(outputHelper, "03_Social_08_MarginIncomeAgr.txt")
    {
        _sut = new FactorySocial(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolSocialTest_MarginIncomeAgr>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MarginIncomeAgr)));
        }
    }
}
