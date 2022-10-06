using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Mga Currency
    /// </summary>
    public class MgaCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MgaCurrency()
        {
            Info = Currency.From(("Ar", CurrencyCodes.MGA, "969", "Malagasy ariary", "iraimbilanja"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
