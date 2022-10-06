using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class SbdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static SbdCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.SBD, "090", "Solomon Islands dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
