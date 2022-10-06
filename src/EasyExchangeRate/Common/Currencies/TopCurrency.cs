using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Top Currency
    /// </summary>
    public class TopCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static TopCurrency()
        {
            Info = Currency.From(("T$", CurrencyCodes.TOP, "776", "Tongan paʻanga", "seniti"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
