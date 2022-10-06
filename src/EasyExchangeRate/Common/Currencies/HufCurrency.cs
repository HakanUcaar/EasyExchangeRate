using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Huf Currency
    /// </summary>
    public class HufCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static HufCurrency()
        {
            Info = Currency.From(("Ft", CurrencyCodes.HUF, "348", "Hungarian Forint", "fill�r"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
