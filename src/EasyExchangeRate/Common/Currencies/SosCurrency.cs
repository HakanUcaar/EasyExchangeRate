using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class SosCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static SosCurrency()
        {
            Info = Currency.From(("S", CurrencyCodes.SOS, "706", "Somali Shilling", "senti"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
