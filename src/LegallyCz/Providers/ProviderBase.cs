using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Types;

namespace HraveMzdy.LegallyCz.Providers;

public class ProviderBase
{
    public ProviderBase(Int16 version)
    {
        this.Version = new VersionId(version);
    }
    public ProviderBase(IVersionId version)
    {
        this.Version = new VersionId(version.Value);
    }
    public IVersionId Version { get; }

    protected bool IsPeriodGreaterOrEqualThan(ILegallyPeriod period, Int16 yearFrom, Int16 monthFrom)
    {
        return (period.Year > yearFrom || (period.Year == yearFrom && period.Month >= monthFrom));
    }
}
