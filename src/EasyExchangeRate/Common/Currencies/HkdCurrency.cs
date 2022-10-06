using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Hkd Currency
    /// </summary>
    public class HkdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static HkdCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.HKD, "344", "Hong Kong Dollar", "仙"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
