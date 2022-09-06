namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Npr Currency
    /// </summary>
    public class NprCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static NprCurrency()
        {
            Info = EasyCurrency.From(("रु", CurrencyCodes.NPR, "524", "Nepalese Rupee"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
