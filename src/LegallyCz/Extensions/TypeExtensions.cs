using HraveMzdy.LegallyCz.Attributes;
using System.Reflection;

namespace HraveMzdy.LegallyCz.Extensions;

internal static class TypeExtensions
{
    internal static void MustDeriveFrom<T>(this Type[] types)
    {
        var invalidTypes = types.Where(m => !typeof(T).IsAssignableFrom(m)).ToList();
        if (invalidTypes.Any())
        {
            throw new ArgumentException($"Types must derive from {typeof(T).Name}, failing types: {string.Join(",", invalidTypes)}");
        }
    }
    public static HistoryVersion VersionAttribute(this TypeInfo obj)
    {
        object? attribute = obj.GetCustomAttribute(typeof(HistoryVersionAttribute));
        if (attribute is HistoryVersionAttribute versionAttribute)
        {
            return versionAttribute.Version;
        }
        return HistoryVersion.Empty;
    }
}