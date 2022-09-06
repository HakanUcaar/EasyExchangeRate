namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Armenian dram
    /// </summary>
    public class AmdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static AmdCurrency()
        {
            Info = EasyCurrency.From(("֏", CurrencyCodes.AMD, "051", "Armenian dram"));
        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
