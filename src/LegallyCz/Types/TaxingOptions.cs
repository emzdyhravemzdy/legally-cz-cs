namespace HraveMzdy.LegallyCz.Types;

public enum TaxDeclSignOption : UInt16
{
    DECL_TAX_NO_SIGNED = 0,
    DECL_TAX_DO_SIGNED = 1,
};
public enum TaxNoneSignOption : UInt16
{
    NOSIGN_TAX_WITHHOLD = 0,
    NOSIGN_TAX_ADVANCES = 1,
};
public enum TaxDeclBenneOption : UInt16
{
    DECL_TAX_BENEF0 = 0,
    DECL_TAX_BENEF1 = 1,
};
public enum TaxDeclDisabilityOption : UInt16
{
    DECL_TAX_BENEF0 = 0,
    DECL_TAX_DISAB1 = 1,
    DECL_TAX_DISAB2 = 2,
    DECL_TAX_DISAB3 = 3,
};
