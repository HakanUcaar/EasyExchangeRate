using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Jod Currency
    /// </summary>
    public class JodCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static JodCurrency()
        {
            Info = Currency.From(("د.ا.‏", CurrencyCodes.JOD, "400", "Jordanian Dinar", "qirsh"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
