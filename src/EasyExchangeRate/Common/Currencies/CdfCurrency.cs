namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cdf Currency
    /// </summary>
    public class CdfCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static CdfCurrency()
        {
            Info = EasyCurrency.From(("FC", CurrencyCodes.CDF, "976", "Congolese franc"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
