using HraveMzdy.LegallyCz.Providers.Period2022;

namespace HraveMzdy.LegallyCz.Providers.Period2023;

// ALLOWANCE_PAYER                  Částka slevy na poplatníka
//
// ALLOWANCE_DISAB_1ST              Částka slevy na invaliditu 1.stupně poplatníka
//
// ALLOWANCE_DISAB_2ND              Částka slevy na invaliditu 2.stupně poplatníka
//
// ALLOWANCE_DISAB_3RD              Částka slevy na invaliditu 3.stupně poplatníka
//
// ALLOWANCE_STUDY                  Částka slevy na poplatníka studenta
//
// ALLOWANCE_CHILD_1ST              Částka slevy na dítě 1.pořadí
//
// ALLOWANCE_CHILD_2ND              Částka slevy na dítě 2.pořadí
//
// ALLOWANCE_CHILD_3RD              Částka slevy na dítě 3.pořadí
//
// FACTOR_ADVANCES                  Sazba daně na zálohový příjem
//
// FACTOR_WITHHOLD                  Sazba daně na srážkový příjem
//
// FACTOR_SOLIDARY                  Sazba daně na solidární zvýšení
//
// FACTOR_TAXRATE2                  Sazba daně pro druhé pásmo daně
//
// MIN_AMOUNT_OF_TAXBONUS           Minimální částka pro daňový bonus
//
// MAX_AMOUNT_OF_TAXBONUS           Maximální částka pro daňový bonus
//
// MARGIN_INCOME_OF_TAXBONUS        Minimální výše příjmu pro nároku na daňový bonus
//
// MARGIN_INCOME_OF_ROUNDING        Maximální výše příjmu pro zaokrouhlování
//
// MARGIN_INCOME_OF_WITHHOLD        Maximální výše příjmu pro srážkový příjem
//
// MARGIN_INCOME_OF_SOLIDARY        Minimální výše příjmu pro solidární zvýšení daně
//
// MARGIN_INCOME_OF_TAXRATE2        Minimální výše příjmu pro druhé pásmo daně
//
// MARGIN_INCOME_OF_WHT_AGR         hranice příjmu pro srážkovou daň pro zaměstnance v pracovním poměru (nepodepsal prohlášení)
//
// MARGIN_INCOME_OF_WHT_EMP         hranice příjmu pro srážkovou daň pro zaměstnance na dohodu (nepodepsal prohlášení)
class HistoryConstTaxing2023
{
    public const Int16 VERSION_CODE = 2023;

    public const Int32 ALLOWANCE_PAYER = 2570;
    public const Int32 ALLOWANCE_DISAB_1ST = HistoryConstTaxing2022.ALLOWANCE_DISAB_1ST;
    public const Int32 ALLOWANCE_DISAB_2ND = HistoryConstTaxing2022.ALLOWANCE_DISAB_2ND;
    public const Int32 ALLOWANCE_DISAB_3RD = HistoryConstTaxing2022.ALLOWANCE_DISAB_3RD;
    public const Int32 ALLOWANCE_STUDY = HistoryConstTaxing2022.ALLOWANCE_STUDY;
    public const Int32 ALLOWANCE_CHILD_1ST = HistoryConstTaxing2022.ALLOWANCE_CHILD_1ST;
    public const Int32 ALLOWANCE_CHILD_2ND = HistoryConstTaxing2022.ALLOWANCE_CHILD_2ND;
    public const Int32 ALLOWANCE_CHILD_3RD = HistoryConstTaxing2022.ALLOWANCE_CHILD_3RD;
    public const decimal FACTOR_ADVANCES = HistoryConstTaxing2022.FACTOR_ADVANCES;
    public const decimal FACTOR_WITHHOLD = HistoryConstTaxing2022.FACTOR_WITHHOLD;
    public const decimal FACTOR_SOLIDARY = HistoryConstTaxing2022.FACTOR_SOLIDARY;
    public const decimal FACTOR_TAXRATE2 = HistoryConstTaxing2022.FACTOR_TAXRATE2;
    public const Int32 MIN_AMOUNT_OF_TAXBONUS = HistoryConstTaxing2022.MIN_AMOUNT_OF_TAXBONUS;
    public const Int32 MAX_AMOUNT_OF_TAXBONUS = 0;
    public const Int32 MARGIN_INCOME_OF_TAXBONUS = (HistoryConstSalary2023.MIN_MONTHLY_WAGE / 2);
    public const Int32 MARGIN_INCOME_OF_ROUNDING = HistoryConstTaxing2022.MARGIN_INCOME_OF_ROUNDING;
    public const Int32 MARGIN_INCOME_OF_WITHHOLD = HistoryConstTaxing2022.MARGIN_INCOME_OF_WITHHOLD;
    public const Int32 MARGIN_INCOME_OF_SOLIDARY = HistoryConstTaxing2022.MARGIN_INCOME_OF_SOLIDARY;
    public const Int32 MARGIN_INCOME_OF_TAXRATE2 = (4 * 40324);
    public const Int32 MARGIN_INCOME_OF_WHT_EMP = 4000;
    public const Int32 MARGIN_INCOME_OF_WHT_AGR = HistoryConstTaxing2022.MARGIN_INCOME_OF_WHT_AGR;
}
