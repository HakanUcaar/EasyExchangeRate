namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Xpf Currency
    /// </summary>
    public class XpfCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static XpfCurrency()
        {
            Info = Currency.From(("R", CurrencyCodes.ZAR, "710", "South African Rand", "centime"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
