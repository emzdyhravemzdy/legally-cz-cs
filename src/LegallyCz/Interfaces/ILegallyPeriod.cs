namespace HraveMzdy.LegallyCz.Interfaces;

public interface ILegallyPeriod : IEquatable<ILegallyPeriod>, ICloneable
{
    Int32 Code { get; }
    Int16 Year { get; }
    Int16 Month { get; }
    string Description { get; }
}
