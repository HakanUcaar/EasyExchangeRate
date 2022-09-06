namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mmk Currency
    /// </summary>
    public class MmkCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MmkCurrency()
        {
            Info = EasyCurrency.From(("K", CurrencyCodes.MMK, "104", "Myanmar Kyat"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
