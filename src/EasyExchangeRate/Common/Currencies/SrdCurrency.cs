using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class SrdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static SrdCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.SRD, "968", "Surinamese dollarc", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
