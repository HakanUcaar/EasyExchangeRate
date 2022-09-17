namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Gbp Currency
    /// </summary>
    public class GbpCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static GbpCurrency()
        {
            Info = Currency.From(("£", CurrencyCodes.GBP, "826", "British Pound", "penny"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
