using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Jmd Currency
    /// </summary>
    public class JmdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static JmdCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.JMD, "388", "Jamaican Dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
