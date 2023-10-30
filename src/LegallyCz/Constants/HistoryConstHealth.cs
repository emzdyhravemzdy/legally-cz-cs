namespace HraveMzdy.LegallyCz.Constants;

// MIN_MONTHLY_BASIS     Minimální základ zdravotního pojištění na jednoho pracovníka
//
// MAX_ANNUALS_BASIS     Maximální roční vyměřovací základ na jednoho pracovníka (tzv.strop)
//
// LIM_MONTHLY_STATE     Vyměřovací základ ze kterého platí pojistné stát za státní pojištěnce (mateřská, studenti, důchodci)
//
// LIM_MONTHLY_DIS50     Vyměřovací základ ze kterého platí pojistné stát za státní pojištěnce (mateřská, studenti, důchodci)
//                      u zaměstnavatele zaměstnávajícího více než 50% osob OZP
// FACTOR_COMPOUND       složená sazba zdravotního pojištění (zaměstnance + zaměstnavatele)
//
// FACTOR_EMPLOYEE       podíl sazby zdravotního pojištění připadajícího na zaměstnance (1/FACTOR_EMPLOYEE)
//
// MARGIN_INCOME_EMP     hranice příjmu pro vznik účasti na pojištění pro zaměstnance v pracovním poměru
//
// MARGIN_INCOME_AGR     hranice příjmu pro vznik účasti na pojištění pro zaměstnance na dohodu
class HistoryConstHealth
{
    public const Int16 VERSION_CODE = 0;

    public const Int32 MIN_MONTHLY_BASIS = HistoryConstSalary.MIN_MONTHLY_WAGE;
    public const Int32 MAX_ANNUALS_BASIS = 1707048;
    public const Int32 LIM_MONTHLY_STATE = 0;
    public const Int32 LIM_MONTHLY_DIS50 = 5355;
    public const decimal FACTOR_COMPOUND = 13.5m;
    public const decimal FACTOR_EMPLOYEE = 3m;
    public const Int32 MARGIN_INCOME_EMP = 2000;
    public const Int32 MARGIN_INCOME_AGR = MARGIN_INCOME_EMP;
}
