namespace LegallyCz.Tests.Service;

public class Service_LegallyCz_Example_HealthTest : Service_LegallyCz_Example_BaseTest
{
    public Service_LegallyCz_Example_HealthTest(ITestOutputHelper outputHelper, string testSuiteFileName) : base(outputHelper, testSuiteFileName)
    {
    }
    protected void ShouldBeValidBundle(ErrorOr<IBundleProps> testResult, short resultYear, short resultMonth)
    {
        try
        {
            testResult.IsError.Should().BeFalse();
            testResult.MatchSucc(r => {
                    r.Should().NotBeNull();
                    r.Should().BeAssignableTo<IBundleProps>();
                    r.PeriodProps.Year.Should().Be(resultYear);
                    r.PeriodProps.Month.Should().Be(resultMonth);
                    r.SocialProps.Should().NotBeNull();
                });
        }
        catch (Xunit.Sdk.XunitException e)
        {
            throw e;
        }
    }
}