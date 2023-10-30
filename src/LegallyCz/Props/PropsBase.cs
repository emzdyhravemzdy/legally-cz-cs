using HraveMzdy.LegallyCz.Interfaces;
using HraveMzdy.LegallyCz.Types;

namespace HraveMzdy.LegallyCz.Props;

public abstract class PropsBase : IProps
{
    public const Int16 VERSION_ZERO = 0;
    public PropsBase(Int16 version)
    {
        this.Version = new VersionId(version);
    }
    public PropsBase(IVersionId version)
    {
        this.Version = new VersionId(version.Value);
    }
    public IVersionId Version { get; }

    public bool IsValid() { return Version.Value != VERSION_ZERO; }

}
