namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cve Currency
    /// </summary>
    public class CveCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static CveCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.CVE, "132", "Cape Verdean escudo", "centavo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
