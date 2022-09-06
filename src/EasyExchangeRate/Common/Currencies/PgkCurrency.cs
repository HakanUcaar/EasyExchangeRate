namespace EasyExchangeRate.Common
{
    public class PgkCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static PgkCurrency()
        {
            Info = EasyCurrency.From(("K", CurrencyCodes.PGK, "598", "Papua New Guinean kina"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
