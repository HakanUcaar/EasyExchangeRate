namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bhd Currency
    /// </summary>
    public class BhdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BhdCurrency()
        {
            Info = EasyCurrency.From(("د.ب.", CurrencyCodes.BHD, "048", "Bahraini dinar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
