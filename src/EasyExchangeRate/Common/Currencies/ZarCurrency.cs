namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Zar Currency
    /// </summary>
    public class ZarCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static ZarCurrency()
        {
            Info = EasyCurrency.From(("", CurrencyCodes.XPF, "953", "CFP franc"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
