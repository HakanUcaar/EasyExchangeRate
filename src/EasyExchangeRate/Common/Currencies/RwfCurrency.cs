using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class RwfCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static RwfCurrency()
        {
            Info = Currency.From(("RF", CurrencyCodes.RWF, "646", "Rwandan Franc", "santime"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
