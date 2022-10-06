using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Ugx Currency
    /// </summary>
    public class UgxCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static UgxCurrency()
        {
            Info = Currency.From(("USh", CurrencyCodes.UGX, "800", "Ugandan shilling", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
