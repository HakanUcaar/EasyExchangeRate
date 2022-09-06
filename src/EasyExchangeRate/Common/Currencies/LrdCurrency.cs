namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Lrd Currency
    /// </summary>
    public class LrdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static LrdCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.LRD, "430", "Liberian dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
