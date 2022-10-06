using EasyExchangeRate;
using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Mkd Currency
    /// </summary>
    public class MkdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MkdCurrency()
        {
            Info = Currency.From(("ден", CurrencyCodes.MKD, "807", "Macedonian Denar", "deni"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
