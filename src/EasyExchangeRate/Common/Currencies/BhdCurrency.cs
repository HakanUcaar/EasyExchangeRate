namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bhd Currency
    /// </summary>
    public class BhdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BhdCurrency()
        {
            Info = Currency.From(("د.ب.", CurrencyCodes.BHD, "048", "Bahraini dinar", "fils"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
