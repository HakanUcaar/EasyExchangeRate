using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Fjd Currency
    /// </summary>
    public class FjdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static FjdCurrency()
        {
            Info = Currency.From(("FJ$", CurrencyCodes.FJD, "242", "Fiji dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
