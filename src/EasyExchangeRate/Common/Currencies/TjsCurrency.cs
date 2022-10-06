using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class TjsCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static TjsCurrency()
        {
            Info = Currency.From(("смн", CurrencyCodes.TJS, "972", "Tajikistani Somoni", "diram"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
