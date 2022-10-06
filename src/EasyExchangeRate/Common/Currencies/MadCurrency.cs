using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Mad Currency
    /// </summary>
    public class MadCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MadCurrency()
        {
            Info = Currency.From(("د.م.", CurrencyCodes.MAD, "504", "Moroccan Dirham", "santim"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
