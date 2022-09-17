namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Kmf Currency
    /// </summary>
    public class KmfCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static KmfCurrency()
        {
            Info = Currency.From(("CF", CurrencyCodes.KMF, "174", "Comoro franc", "centime"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
