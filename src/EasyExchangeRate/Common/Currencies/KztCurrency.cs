using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Kzt Currency
    /// </summary>
    public class KztCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static KztCurrency()
        {
            Info = Currency.From(("₸", CurrencyCodes.KZT, "398", "Kazakhstani Tenge", "тиын"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
