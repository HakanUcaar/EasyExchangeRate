using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Dzd Currency
    /// </summary>
    public class DzdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static DzdCurrency()
        {
            Info = Currency.From(("د.ج.", CurrencyCodes.DZD, "012", "Algerian dinar", "defunct"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
