namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Afghan afghani
    /// </summary>
    public class AfnCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static AfnCurrency()
        {
            Info = Currency.From(("؋", CurrencyCodes.AFN, "971", "Afghan afghani", "pul"));
        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
