using HraveMzdy.LegallyCz.Interfaces;

namespace HraveMzdy.LegallyCz.Providers;

public interface IPropsProvider<P>
{
    P GetProps(ILegallyPeriod period);
    IVersionId Version { get; }
}
