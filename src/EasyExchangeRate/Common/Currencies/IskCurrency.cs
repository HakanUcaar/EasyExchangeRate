using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Isk Currency
    /// </summary>
    public class IskCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static IskCurrency()
        {
            Info = Currency.From(("kr", CurrencyCodes.ISK, "352", "Icelandic Króna", "eyrir"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
