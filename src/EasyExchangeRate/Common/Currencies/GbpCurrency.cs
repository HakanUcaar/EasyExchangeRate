namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Gbp Currency
    /// </summary>
    public class GbpCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static GbpCurrency()
        {
            Info = EasyCurrency.From(("£", CurrencyCodes.GBP, "826", "British Pound"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
