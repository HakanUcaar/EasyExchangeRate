using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Clp Currency
    /// </summary>
    public class ClpCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static ClpCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.CLP, "152", "Chilean peso", "centavos"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
