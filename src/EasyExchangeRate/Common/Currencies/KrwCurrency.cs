using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Krw Currency
    /// </summary>
    public class KrwCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static KrwCurrency()
        {
            Info = Currency.From(("₩", CurrencyCodes.KRW, "410", "South Korean Won", "jeon"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
