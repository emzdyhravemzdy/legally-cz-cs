using System.Reflection;

namespace HraveMzdy.LegallyCz.Providers;
public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}
