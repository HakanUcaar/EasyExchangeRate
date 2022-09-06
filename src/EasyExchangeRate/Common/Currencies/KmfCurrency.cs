namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Kmf Currency
    /// </summary>
    public class KmfCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static KmfCurrency()
        {
            Info = EasyCurrency.From(("CF", CurrencyCodes.KMF, "174", "Comoro franc"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
