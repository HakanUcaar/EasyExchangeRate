namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Lrd Currency
    /// </summary>
    public class LrdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static LrdCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.LRD, "430", "Liberian dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
