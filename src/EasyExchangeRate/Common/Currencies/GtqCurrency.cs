using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Gtq Currency
    /// </summary>
    public class GtqCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static GtqCurrency()
        {
            Info = Currency.From(("Q", CurrencyCodes.GTQ, "320", "Guatemalan Quetzal", "centavo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
