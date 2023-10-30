namespace HraveMzdy.LegallyCz.Attributes;

public sealed record HistoryVersion(short Version)
{
    public static HistoryVersion Empty { get => new HistoryVersion(0); }
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public sealed class HistoryVersionAttribute(short version) : System.Attribute
{
    public HistoryVersion Version { get; init; } = new HistoryVersion(version);
}

