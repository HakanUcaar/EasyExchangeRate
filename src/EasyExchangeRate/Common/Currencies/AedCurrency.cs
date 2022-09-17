namespace EasyExchangeRate.Common
{
    /// <summary>
    /// United Arab Emirates dirham
    /// </summary>
    public class AedCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static AedCurrency()
        {
            Info = Currency.From(("د.إ.", CurrencyCodes.AED, "784", "United Arab Emirates dirham", "fils"));
        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
