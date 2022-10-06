using EasyExchangeRate;
using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Mro Currency
    /// </summary>
    public class MroCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MroCurrency()
        {
            Info = Currency.From(("UM", CurrencyCodes.MRO, "478", "Mauritanian ouguiya", "khoums"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
