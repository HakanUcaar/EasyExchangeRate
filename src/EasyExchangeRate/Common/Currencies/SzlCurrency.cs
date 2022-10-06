using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class SzlCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static SzlCurrency()
        {
            Info = Currency.From(("L", CurrencyCodes.SZL, "748", "Swazi lilangeni", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
