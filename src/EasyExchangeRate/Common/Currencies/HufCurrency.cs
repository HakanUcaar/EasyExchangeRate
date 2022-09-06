namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Huf Currency
    /// </summary>
    public class HufCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static HufCurrency()
        {
            Info = EasyCurrency.From(("Ft", CurrencyCodes.HUF, "348", "Hungarian Forint"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
