namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Armenian dram
    /// </summary>
    public class AmdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static AmdCurrency()
        {
            Info = Currency.From(("֏", CurrencyCodes.AMD, "051", "Armenian dram", "լումա"));
        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
