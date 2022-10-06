using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class SvcCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static SvcCurrency()
        {
            Info = Currency.From(("₡", CurrencyCodes.SVC, "222", "Salvadoran colón",""));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
