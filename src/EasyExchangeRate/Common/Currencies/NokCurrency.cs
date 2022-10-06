using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Nok Currency
    /// </summary>
    public class NokCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static NokCurrency()
        {
            Info = Currency.From(("kr", CurrencyCodes.NOK, "578", "Norwegian Krone", "øre"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
