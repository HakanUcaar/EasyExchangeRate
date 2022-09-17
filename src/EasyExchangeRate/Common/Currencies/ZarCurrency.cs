namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Zar Currency
    /// </summary>
    public class ZarCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static ZarCurrency()
        {
            Info = Currency.From(("", CurrencyCodes.XPF, "953", "CFP franc", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
