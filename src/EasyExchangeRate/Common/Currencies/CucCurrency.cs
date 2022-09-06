namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cuc Currency
    /// </summary>
    public class CucCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static CucCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.CUC, "931", "Cuban convertible peso"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
