namespace LegallyCz.Tests.Service;

public class Service_LegallyCz_Example_BundleFailure2009Test : LegallyCzBaseTest
{
    private readonly IServiceLegallyCz _sut;

    public Service_LegallyCz_Example_BundleFailure2009Test(ITestOutputHelper outputHelper) : base(outputHelper)
    {
        _sut = service;
    }

    [Theory]
    [InlineData(2009, 1)]
    [InlineData(2009, 2)]
    [InlineData(2009, 3)]
    [InlineData(2009, 4)]
    [InlineData(2009, 5)]
    [InlineData(2009, 6)]
    [InlineData(2009, 7)]
    [InlineData(2009, 8)]
    [InlineData(2009, 9)]
    [InlineData(2009,10)]
    [InlineData(2009,11)]
    [InlineData(2009,12)]
    public void GetBundle_ShouldReturnError_ForYear2009(Int16 testYear, Int16 testMonth)
    {
        var testPeriod = new LegallyPeriod(testYear, testMonth);

        var testResult = _sut.GetBundle(testPeriod);

        testResult.IsError.Should().BeTrue();
    }
}
