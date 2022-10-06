using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Azn Currency
    /// </summary>
    public class AznCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static AznCurrency()
        {
            Info = Currency.From(("₼", CurrencyCodes.AZN, "944", "Azerbaijani manat", "qəpik"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
