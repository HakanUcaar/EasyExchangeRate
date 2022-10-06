using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Czk Currency
    /// </summary>
    public class CzkCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static CzkCurrency()
        {
            Info = Currency.From(("Kč", CurrencyCodes.CZK, "203", "Czech koruna", "haléř"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
