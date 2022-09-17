namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Lyd Currency
    /// </summary>
    public class LydCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static LydCurrency()
        {
            Info = Currency.From(("د.ل.", CurrencyCodes.LYD, "434", "Libyan Dinar", "dirham"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
