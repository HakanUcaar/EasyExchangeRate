namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Aud Currency
    /// </summary>
    public class AudCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static AudCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.AUD, "036", "Australian dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
