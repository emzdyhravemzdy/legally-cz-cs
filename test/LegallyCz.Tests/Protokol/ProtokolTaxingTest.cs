using HraveMzdy.LegallyCz.Providers;

namespace LegallyCz.Tests.Protokol;

public class ProtokolTaxingTest_AllowancePayer : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_AllowancePayer(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_01_AllowancePayer.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolSocialTest_MaxAnnualsBasis>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.AllowancePayer)));
        }
    }
}

public class ProtokolTaxingTest_AllowanceDisability1st : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_AllowanceDisability1st(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_02_AllowanceDisability1st.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_AllowanceDisability1st>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.AllowanceDisability1st)));
        }
    }
}

public class ProtokolTaxingTest_AllowanceDisability2nd : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_AllowanceDisability2nd(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_03_AllowanceDisability2nd.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_AllowanceDisability2nd>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.AllowanceDisability2nd)));
        }
    }
}

public class ProtokolTaxingTest_AllowanceDisability3rd : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_AllowanceDisability3rd(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_04_AllowanceDisability3rd.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_AllowanceDisability3rd>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.AllowanceDisability3rd)));
        }
    }
}

public class ProtokolTaxingTest_AllowanceStudy : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_AllowanceStudy(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_05_AllowanceStudy.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_AllowanceStudy>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.AllowanceStudy)));
        }
    }
}

public class ProtokolTaxingTest_AllowanceChild1st : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_AllowanceChild1st(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_06_AllowanceChild1st.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_AllowanceChild1st>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.AllowanceChild1st)));
        }
    }
}

public class ProtokolTaxingTest_AllowanceChild2nd : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_AllowanceChild2nd(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_07_AllowanceChild2nd.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_AllowanceChild2nd>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.AllowanceChild2nd)));
        }
    }
}

public class ProtokolTaxingTest_AllowanceChild3rd : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_AllowanceChild3rd(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_08_AllowanceChild3rd.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_AllowanceChild3rd>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.AllowanceChild3rd)));
        }
    }
}

public class ProtokolTaxingTest_FactorAdvances : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_FactorAdvances(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_09_FactorAdvances.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_FactorAdvances>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.FactorAdvances)));
        }
    }
}

public class ProtokolTaxingTest_FactorWithhold : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_FactorWithhold(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_10_FactorWithhold.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_FactorWithhold>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.FactorWithhold)));
        }
    }
}

public class ProtokolTaxingTest_FactorSolidary : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_FactorSolidary(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_11_FactorSolidary.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_FactorSolidary>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.FactorSolidary)));
        }
    }
}

public class ProtokolTaxingTest_FactorTaxRate2 : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_FactorTaxRate2(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_12_FactorTaxRate2.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_FactorTaxRate2>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.FactorTaxRate2)));
        }
    }
}

public class ProtokolTaxingTest_MinAmountOfTaxBonus : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_MinAmountOfTaxBonus(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_13_MinAmountOfTaxBonus.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_MinAmountOfTaxBonus>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MinAmountOfTaxBonus)));
        }
    }
}

public class ProtokolTaxingTest_MaxAmountOfTaxBonus : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_MaxAmountOfTaxBonus(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_14_MaxAmountOfTaxBonus.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_MaxAmountOfTaxBonus>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MaxAmountOfTaxBonus)));
        }
    }
}

public class ProtokolTaxingTest_MarginIncomeOfTaxBonus : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_MarginIncomeOfTaxBonus(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_15_MarginIncomeOfTaxBonus.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_MarginIncomeOfTaxBonus>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MarginIncomeOfTaxBonus)));
        }
    }
}

public class ProtokolTaxingTest_MarginIncomeOfRounding : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_MarginIncomeOfRounding(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_16_MarginIncomeOfRounding.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_MarginIncomeOfRounding>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MarginIncomeOfRounding)));
        }
    }
}

public class ProtokolTaxingTest_MarginIncomeOfWithhold : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_MarginIncomeOfWithhold(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_17_MarginIncomeOfWithhold.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_MarginIncomeOfWithhold>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MarginIncomeOfWithhold)));
        }
    }
}

public class ProtokolTaxingTest_MarginIncomeOfSolidary : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_MarginIncomeOfSolidary(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_18_MarginIncomeOfSolidary.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_MarginIncomeOfSolidary>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MarginIncomeOfSolidary)));
        }
    }
}

public class ProtokolTaxingTest_MarginIncomeOfTaxRate2 : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_MarginIncomeOfTaxRate2(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_19_MarginIncomeOfTaxRate2.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_MarginIncomeOfTaxRate2>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MarginIncomeOfTaxRate2)));
        }
    }
}

public class ProtokolTaxingTest_MarginIncomeOfWthEmp : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_MarginIncomeOfWthEmp(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_20_MarginIncomeOfWthEmp.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_MarginIncomeOfWthEmp>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MarginIncomeOfWthEmp)));
        }
    }
}

public class ProtokolTaxingTest_MarginIncomeOfWthAgr : LegallyCzProtokolBaseTest
{
    private readonly IProviderFactory<IProviderTaxing, IPropsTaxing> _sut;
    public ProtokolTaxingTest_MarginIncomeOfWthAgr(ITestOutputHelper outputHelper) : base(outputHelper, "04_Taxing_21_MarginIncomeOfWthAgr.txt")
    {
        _sut = new FactoryTaxing(CURRENT_VERSION);
    }
    [Theory]
    [InlineData(2010, 2022)]
    public void GetProps_ShouldExport(Int16 testMinYear, Int16 testMaxYear)
    {
        var testLogger = CreateLoggerFile<ProtokolTaxingTest_MarginIncomeOfWthAgr>();

        ExportPropsStart(testLogger);

        for (Int16 testYear = testMinYear; testYear <= testMaxYear; testYear++)
        {
            ExportPropsLine(testLogger, testYear, _sut, ((prop) => (prop.MarginIncomeOfWthAgr)));
        }
    }
}
