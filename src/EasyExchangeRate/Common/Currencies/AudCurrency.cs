using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Aud Currency
    /// </summary>
    public class AudCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static AudCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.AUD, "036", "Australian dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
