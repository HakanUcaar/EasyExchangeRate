using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Xcd Currency
    /// </summary>
    public class XcdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static XcdCurrency()
        {
            Info = Currency.From(("EC$", CurrencyCodes.XCD, "951", "East Caribbean Dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
