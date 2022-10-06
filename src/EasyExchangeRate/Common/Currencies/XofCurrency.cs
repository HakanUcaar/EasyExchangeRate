using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Xof Currency
    /// </summary>
    public class XofCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static XofCurrency()
        {
            Info = Currency.From(("CFA", CurrencyCodes.XOF, "952", "West African CFA Franc", "centime"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
