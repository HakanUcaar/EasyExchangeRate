using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class SgdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static SgdCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.SGD, "702", "Singapore Dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
