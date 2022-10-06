using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Zwl Currency
    /// </summary>
    public class ZwlCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static ZwlCurrency()
        {
            Info = Currency.From(("", CurrencyCodes.ZWL, "932", "Zimbabwean dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
