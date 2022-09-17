namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Albanian lek
    /// </summary>
    public class AllCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static AllCurrency()
        {
            Info = Currency.From(("L", CurrencyCodes.ALL, "008", "Albanian lek", "qindarkë"));
        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
