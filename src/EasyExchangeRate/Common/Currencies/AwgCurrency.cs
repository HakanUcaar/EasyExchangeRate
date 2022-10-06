using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Awg Currency
    /// </summary>
    public class AwgCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static AwgCurrency()
        {
            Info = Currency.From(("Afl", CurrencyCodes.AUD, "533", "Aruban florin", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
