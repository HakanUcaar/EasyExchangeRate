namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Lkr Currency
    /// </summary>
    public class LkrCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static LkrCurrency()
        {
            Info = Currency.From(("රු.", CurrencyCodes.LKR, "144", "Sri Lankan Rupee", "cents"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
