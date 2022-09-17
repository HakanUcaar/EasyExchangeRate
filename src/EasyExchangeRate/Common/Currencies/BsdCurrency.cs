namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bsd Currency
    /// </summary>
    public class BsdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BsdCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.BSD, "044", "Bahamian dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
