using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Npr Currency
    /// </summary>
    public class NprCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static NprCurrency()
        {
            Info = Currency.From(("रु", CurrencyCodes.NPR, "524", "Nepalese Rupee", "paisa"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
