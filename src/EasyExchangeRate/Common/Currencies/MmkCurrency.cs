using EasyExchangeRate;
using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Mmk Currency
    /// </summary>
    public class MmkCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MmkCurrency()
        {
            Info = Currency.From(("K", CurrencyCodes.MMK, "104", "Myanmar Kyat", "pya"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
