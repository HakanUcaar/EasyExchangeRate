using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class PgkCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static PgkCurrency()
        {
            Info = Currency.From(("K", CurrencyCodes.PGK, "598", "Papua New Guinean kina", "toea"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
