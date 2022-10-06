using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Bzd Currency
    /// </summary>
    public class BzdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BzdCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.BZD, "084", "Belize dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
