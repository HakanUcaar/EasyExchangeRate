using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class TndCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static TndCurrency()
        {
            Info = Currency.From(("د.ت.", CurrencyCodes.TND, "788", "Tunisian Dinar",""));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
