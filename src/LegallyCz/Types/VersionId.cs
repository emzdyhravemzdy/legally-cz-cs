using HraveMzdy.LegallyCz.Interfaces;

namespace HraveMzdy.LegallyCz.Types;

public sealed record VersionId(Int16 Value) : IVersionId
{
    public static VersionId New() => new(0);

    public static VersionId Get(Int16 value) => new(value);
}
