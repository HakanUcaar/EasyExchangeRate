using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Egp Currency
    /// </summary>
    public class EgpCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static EgpCurrency()
        {
            Info = Currency.From(("ج.م.", CurrencyCodes.EGP, "818", "Egyptian pound", "قرش"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
