namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Lkr Currency
    /// </summary>
    public class LkrCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static LkrCurrency()
        {
            Info = EasyCurrency.From(("රු.", CurrencyCodes.LKR, "144", "Sri Lankan Rupee"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
