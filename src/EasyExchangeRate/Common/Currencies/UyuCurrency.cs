using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Uyu Currency
    /// </summary>
    public class UyuCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static UyuCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.UYU, "858", "Uruguayan Peso", "centésimo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
