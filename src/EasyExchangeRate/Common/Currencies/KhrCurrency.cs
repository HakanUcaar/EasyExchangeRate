using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Khr Currency
    /// </summary>
    public class KhrCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static KhrCurrency()
        {
            Info = Currency.From(("៛", CurrencyCodes.KHR, "116", "Cambodian Riel", "sen"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
