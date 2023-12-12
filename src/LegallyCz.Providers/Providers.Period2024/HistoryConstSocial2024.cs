using HraveMzdy.LegallyCz.Providers.Period2023;

namespace HraveMzdy.LegallyCz.Providers.Period2024;

// MAX_ANNUALS_BASIS            Maximální roční vyměřovací základ na jednoho pracovníka (tzv.strop)
//
// FACTOR_EMPLOYER              Sazba - standardní sociálního pojištění - zaměstnavatele
//
// FACTOR_EMPLOYER_HIGHER       Sazba - vyší sociálního pojištění - zaměstnavatele
//
// FACTOR_EMPLOYEE              Sazba sociálního pojištění - zaměstnance
//
// FACTOR_EMPLOYEE_REDUCE       Snížení sazby sociálního pojištění - zaměstnance - s důchodovým spořením
//
// FACTOR_EMPLOYEE_GARANT       Sazba důchodového spoření - zaměstnance - s důchodovým spořením
//
// MARGIN_INCOME_EMP            hranice příjmu pro vznik účasti na pojištění pro zaměstnance v pracovním poměru
//
// MARGIN_INCOME_AGR            hranice příjmu pro vznik účasti na pojištění pro zaměstnance na dohodu
class HistoryConstSocial2024
{
    public const Int16 VERSION_CODE = 2024;

    public const Int32 MAX_ANNUALS_BASIS = 2110416;
    public const decimal FACTOR_EMPLOYER = HistoryConstSocial2023.FACTOR_EMPLOYER;
    public const decimal FACTOR_EMPLOYER_HIGHER = HistoryConstSocial2023.FACTOR_EMPLOYER_HIGHER;
    public const decimal FACTOR_EMPLOYEE = 7.1m;
    public const decimal FACTOR_EMPLOYEE_REDUCE = HistoryConstSocial2023.FACTOR_EMPLOYEE_REDUCE;
    public const decimal FACTOR_EMPLOYEE_GARANT = HistoryConstSocial2023.FACTOR_EMPLOYEE_GARANT;
    public const Int32 MARGIN_INCOME_EMP = HistoryConstSocial2023.MARGIN_INCOME_EMP;
    public const Int32 MARGIN_INCOME_AGR = HistoryConstSocial2023.MARGIN_INCOME_AGR;
}
