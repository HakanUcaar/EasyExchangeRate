using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Hnl Currency
    /// </summary>
    public class HnlCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static HnlCurrency()
        {
            Info = Currency.From(("L", CurrencyCodes.HNL, "340", "Honduran Lempira", "centavo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
