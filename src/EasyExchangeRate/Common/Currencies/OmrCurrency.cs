namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Omr Currency
    /// </summary>
    public class OmrCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static OmrCurrency()
        {
            Info = Currency.From(("ر.ع.", CurrencyCodes.OMR, "512", "Omani Rial", "baisa"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
