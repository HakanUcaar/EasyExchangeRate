using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Iqd Currency
    /// </summary>
    public class IqdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static IqdCurrency()
        {
            Info = Currency.From(("د.ع.", CurrencyCodes.IQD, "368", "Iraqi Dinar", "fils"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
