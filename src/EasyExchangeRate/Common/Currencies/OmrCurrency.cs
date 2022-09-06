namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Omr Currency
    /// </summary>
    public class OmrCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static OmrCurrency()
        {
            Info = EasyCurrency.From(("ر.ع.", CurrencyCodes.OMR, "512", "Omani Rial"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
