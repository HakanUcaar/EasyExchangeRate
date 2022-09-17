namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Myr Currency
    /// </summary>
    public class MyrCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MyrCurrency()
        {
            Info = Currency.From(("RM", CurrencyCodes.MYR, "458", "Malaysian Ringgit", "sen"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
