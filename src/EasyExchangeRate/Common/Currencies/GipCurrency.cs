using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Gip Currency
    /// </summary>
    public class GipCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static GipCurrency()
        {
            Info = Currency.From(("£", CurrencyCodes.GIP, "292", "Gibraltar pound", "Penny"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
