namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Dkk Currency
    /// </summary>
    public class DkkCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static DkkCurrency()
        {
            Info = EasyCurrency.From(("kr.", CurrencyCodes.DKK, "208", "Danish krone"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
