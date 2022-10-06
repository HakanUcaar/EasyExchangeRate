using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Nio Currency
    /// </summary>
    public class NioCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static NioCurrency()
        {
            Info = Currency.From(("C$", CurrencyCodes.NIO, "558", "Nicaraguan Córdoba", "centavo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
