using HraveMzdy.LegallyCz.Extensions;

namespace HraveMzdy.LegallyCz.Types;

public enum TaxDeclSignOption : UInt16
{
    DECL_TAX_NO_SIGNED = 0,
    DECL_TAX_DO_SIGNED = 1,
};
public static class TaxDeclSignOptionEnum
{
    public static TaxDeclSignOption Get(this Int32 symbol)
    {
        return EnumConstExtension.GetEnum<TaxDeclSignOption>((UInt16)symbol, TaxDeclSignOption.DECL_TAX_NO_SIGNED);
    }
}
public enum TaxNoneSignOption : UInt16
{
    NOSIGN_TAX_WITHHOLD = 0,
    NOSIGN_TAX_ADVANCES = 1,
};
public static class TaxNoneSignOptionEnum
{
    public static TaxNoneSignOption Get(this Int32 symbol)
    {
        return EnumConstExtension.GetEnum<TaxNoneSignOption>((UInt16)symbol, TaxNoneSignOption.NOSIGN_TAX_WITHHOLD);
    }
}
public enum TaxDeclBenneOption : UInt16
{
    DECL_TAX_BENEF0 = 0,
    DECL_TAX_BENEF1 = 1,
};
public static class TaxDeclBenneOptionEnum
{
    public static TaxDeclBenneOption Get(this Int32 symbol)
    {
        return EnumConstExtension.GetEnum<TaxDeclBenneOption>((UInt16)symbol, TaxDeclBenneOption.DECL_TAX_BENEF0);
    }
}
public enum TaxDeclDisabilityOption : UInt16
{
    DECL_TAX_BENEF0 = 0,
    DECL_TAX_DISAB1 = 1,
    DECL_TAX_DISAB2 = 2,
    DECL_TAX_DISAB3 = 3,
};
public static class TaxDeclDisabilityOptionEnum
{
    public static TaxDeclDisabilityOption Get(this Int32 symbol)
    {
        return EnumConstExtension.GetEnum<TaxDeclDisabilityOption>((UInt16)symbol, TaxDeclDisabilityOption.DECL_TAX_BENEF0);
    }
}
