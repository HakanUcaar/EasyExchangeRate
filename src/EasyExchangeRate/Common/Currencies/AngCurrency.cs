using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Ang Currency
    /// </summary>
    public class AngCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static AngCurrency()
        {
            Info = Currency.From(("NAƒ", CurrencyCodes.ANG, "532", "Netherlands Antillean guilder", "cent"));
        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
