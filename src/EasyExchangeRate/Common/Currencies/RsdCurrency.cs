using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class RsdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static RsdCurrency()
        {
            Info = Currency.From(("дин.", CurrencyCodes.RSD, "941", "Serbian Dinar", "para"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
