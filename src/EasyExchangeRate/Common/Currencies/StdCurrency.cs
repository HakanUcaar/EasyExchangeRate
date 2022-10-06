using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class StdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static StdCurrency()
        {
            Info = Currency.From(("Db", CurrencyCodes.STD, "678", "São Tomé and Príncipe dobra", "cêntimo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
