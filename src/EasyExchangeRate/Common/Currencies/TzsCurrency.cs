using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class TzsCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static TzsCurrency()
        {
            Info = Currency.From(("TSh", CurrencyCodes.TZS, "834", "Tanzanian shilling", "senti"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
 }
