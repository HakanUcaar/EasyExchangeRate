using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Mvr Currency
    /// </summary>
    public class MvrCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MvrCurrency()
        {
            Info = Currency.From(("ރ.", CurrencyCodes.MVR, "462", "Maldivian Rufiyaa", "laari"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
