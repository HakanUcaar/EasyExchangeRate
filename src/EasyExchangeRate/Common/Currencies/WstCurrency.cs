using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Wst Currency
    /// </summary>
    public class WstCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static WstCurrency()
        {
            Info = Currency.From(("WS$", CurrencyCodes.WST, "882", "Samoan tala", "sene"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
