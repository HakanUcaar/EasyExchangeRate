using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Lak Currency
    /// </summary>
    public class LakCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static LakCurrency()
        {
            Info = Currency.From(("₭", CurrencyCodes.LAK, "418", "Laotian Kip", "att"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
