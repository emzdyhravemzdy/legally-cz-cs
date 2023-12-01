namespace HraveMzdy.LegallyCz.Extensions;

internal static class EnumConstExtension
{
    public static string GetSymbol<T>(Int32 symbol) where T : struct, Enum
    {
        var enumValue = (T)Enum.ToObject(typeof(T), symbol);
        return Enum.GetName<T>(enumValue) ?? "";
    }
    public static T GetEnum<T>(Int32 symbol, T empty) where T : struct, Enum
    {
        T? enumValue = (T)Enum.ToObject(typeof(T), symbol);
        return (enumValue) ?? empty;
    }
    public static T GetEnum<T>(Int16 symbol, T empty) where T : struct, Enum
    {
        T? enumValue = (T)Enum.ToObject(typeof(T), symbol);
        return (enumValue) ?? empty;
    }
}
