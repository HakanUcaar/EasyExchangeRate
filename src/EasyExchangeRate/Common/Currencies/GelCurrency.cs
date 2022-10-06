using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Gel Currency
    /// </summary>
    public class GelCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static GelCurrency()
        {
            Info = Currency.From(("₾", CurrencyCodes.GEL, "981", "Georgian Lari", "tetri"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
