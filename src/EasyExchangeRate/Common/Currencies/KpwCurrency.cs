using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Kpw Currency
    /// </summary>
    public class KpwCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static KpwCurrency()
        {
            Info = Currency.From(("₩", CurrencyCodes.KPW, "408", "North Korean won", "chon"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
