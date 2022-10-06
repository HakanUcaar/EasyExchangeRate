using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class SekCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static SekCurrency()
        {
            Info =  Currency.From(("kr", CurrencyCodes.SEK, "752", "Swedish Krona", "öre"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
