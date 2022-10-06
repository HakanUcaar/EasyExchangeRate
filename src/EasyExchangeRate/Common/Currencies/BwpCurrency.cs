using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Bwp Currency
    /// </summary>
    public class BwpCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BwpCurrency()
        {
            Info = Currency.From(("P", CurrencyCodes.BWP, "072", "Botswana pula", "thebe"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
