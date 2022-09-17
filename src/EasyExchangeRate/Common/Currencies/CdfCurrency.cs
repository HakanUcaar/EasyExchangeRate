namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cdf Currency
    /// </summary>
    public class CdfCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static CdfCurrency()
        {
            Info = Currency.From(("FC", CurrencyCodes.CDF, "976", "Congolese franc", "centime"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
