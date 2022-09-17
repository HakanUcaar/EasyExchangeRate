namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Jpy Currency
    /// </summary>
    public class JpyCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static JpyCurrency()
        {
            Info = Currency.From(("¥", CurrencyCodes.JPY, "392", "Japanese Yen", "sen"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
