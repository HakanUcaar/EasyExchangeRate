using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Etb Currency
    /// </summary>
    public class EtbCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static EtbCurrency()
        {
            Info = Currency.From(("ብር", CurrencyCodes.ETB, "230", "Ethiopian birr", "santim"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
