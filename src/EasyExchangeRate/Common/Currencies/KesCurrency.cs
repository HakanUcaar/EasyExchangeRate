using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Kes Currency
    /// </summary>
    public class KesCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static KesCurrency()
        {
            Info = Currency.From(("Ksh", CurrencyCodes.KES, "404", "Kenyan Shilling", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
