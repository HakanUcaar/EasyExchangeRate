using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Fkp Currency
    /// </summary>
    public class FkpCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static FkpCurrency()
        {
            Info = Currency.From(("£", CurrencyCodes.FKP, "238", "Falkland Islands pound", "penny"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
