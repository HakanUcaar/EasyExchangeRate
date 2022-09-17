namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cuc Currency
    /// </summary>
    public class CucCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static CucCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.CUC, "931", "Cuban convertible peso", "centavo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
