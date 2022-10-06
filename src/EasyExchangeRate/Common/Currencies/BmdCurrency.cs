using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Bmd Currency
    /// </summary>
    public class BmdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BmdCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.BMD, "060", "Bermudian dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
