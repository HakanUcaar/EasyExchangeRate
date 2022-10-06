using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class DjfCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static DjfCurrency()
        {
            Info = Currency.From(("Fdj", CurrencyCodes.DJF, "262", "Djiboutian franc", "centime"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
