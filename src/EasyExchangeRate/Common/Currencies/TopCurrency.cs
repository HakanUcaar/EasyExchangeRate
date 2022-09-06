namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Top Currency
    /// </summary>
    public class TopCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static TopCurrency()
        {
            Info = EasyCurrency.From(("T$", CurrencyCodes.TOP, "776", "Tongan paʻanga"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
