﻿using HraveMzdy.LegallyCz.Providers.Period2019;

namespace HraveMzdy.LegallyCz.Providers.Period2020;

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
class HistoryConstTaxing2020
{
    public const Int16 VERSION_CODE = 2020;

    public const Int32 ALLOWANCE_PAYER = HistoryConstTaxing2019.ALLOWANCE_PAYER;
    public const Int32 ALLOWANCE_DISAB_1ST = HistoryConstTaxing2019.ALLOWANCE_DISAB_1ST;
    public const Int32 ALLOWANCE_DISAB_2ND = HistoryConstTaxing2019.ALLOWANCE_DISAB_2ND;
    public const Int32 ALLOWANCE_DISAB_3RD = HistoryConstTaxing2019.ALLOWANCE_DISAB_3RD;
    public const Int32 ALLOWANCE_STUDY = HistoryConstTaxing2019.ALLOWANCE_STUDY;
    public const Int32 ALLOWANCE_CHILD_1ST = HistoryConstTaxing2019.ALLOWANCE_CHILD_1ST;
    public const Int32 ALLOWANCE_CHILD_2ND = HistoryConstTaxing2019.ALLOWANCE_CHILD_2ND;
    public const Int32 ALLOWANCE_CHILD_3RD = HistoryConstTaxing2019.ALLOWANCE_CHILD_3RD;
    public const decimal FACTOR_ADVANCES = HistoryConstTaxing2019.FACTOR_ADVANCES;
    public const decimal FACTOR_WITHHOLD = HistoryConstTaxing2019.FACTOR_WITHHOLD;
    public const decimal FACTOR_SOLIDARY = HistoryConstTaxing2019.FACTOR_SOLIDARY;
    public const decimal FACTOR_TAXRATE2 = HistoryConstTaxing2019.FACTOR_TAXRATE2;
    public const Int32 MIN_AMOUNT_OF_TAXBONUS = HistoryConstTaxing2019.MIN_AMOUNT_OF_TAXBONUS;
    public const Int32 MAX_AMOUNT_OF_TAXBONUS = HistoryConstTaxing2019.MAX_AMOUNT_OF_TAXBONUS;
    public const Int32 MARGIN_INCOME_OF_TAXBONUS = (HistoryConstSalary2020.MIN_MONTHLY_WAGE / 2);
    public const Int32 MARGIN_INCOME_OF_ROUNDING = HistoryConstTaxing2019.MARGIN_INCOME_OF_ROUNDING;
    public const Int32 MARGIN_INCOME_OF_WITHHOLD = HistoryConstTaxing2019.MARGIN_INCOME_OF_WITHHOLD;
    public const Int32 MARGIN_INCOME_OF_SOLIDARY = (4 * 34835);
    public const Int32 MARGIN_INCOME_OF_TAXRATE2 = HistoryConstTaxing2019.MARGIN_INCOME_OF_TAXRATE2;
    public const Int32 MARGIN_INCOME_OF_WHT_EMP = HistoryConstTaxing2019var05.MARGIN_INCOME_OF_WHT_EMP;
    public const Int32 MARGIN_INCOME_OF_WHT_AGR = HistoryConstTaxing2019.MARGIN_INCOME_OF_WHT_AGR;
}