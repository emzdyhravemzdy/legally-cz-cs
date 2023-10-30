using HraveMzdy.LegallyCz.Interfaces;

namespace HraveMzdy.LegallyCz.Types;

public class LegallyPeriod : ILegallyPeriod
{
    public static readonly Int32 EmptyCode = 0;

    public static readonly LegallyPeriod Empty = new(EmptyCode);
    public static LegallyPeriod New() => new(EmptyCode);
    public static LegallyPeriod YearMonth(int year, int month) => new(year, month);

    public LegallyPeriod(int code)
    {
        this.Code = code;
    }
    public LegallyPeriod(int year, int month)
    {
        this.Code = (year * 100 + month);
    }

    public Int32 Code { get; }

    public Int16 Year { get { return (Int16)(Code / 100); } }

    public Int16 Month { get { return (Int16)(Code % 100); } }

    public string Description => (Code == 0) ? "empty period" : $"{Month}/{Year}";

    public object Clone()
    {
        ILegallyPeriod clone = new LegallyPeriod(this.Code);
        return clone;
    }

}
