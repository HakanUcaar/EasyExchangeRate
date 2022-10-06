using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Hrk Currency
    /// </summary>
    public class HrkCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static HrkCurrency()
        {
            Info = Currency.From(("kn", CurrencyCodes.HRK, "191", "Croatian Kuna", "lipa"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
