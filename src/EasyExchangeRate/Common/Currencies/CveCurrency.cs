namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cve Currency
    /// </summary>
    public class CveCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static CveCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.CVE, "132", "Cape Verdean escudo"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
