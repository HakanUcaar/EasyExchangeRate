using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class RonCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static RonCurrency()
        {
            Info = Currency.From(("lei", CurrencyCodes.RON, "946", "Romanian Leu", "bani"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
