namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Htg Currency
    /// </summary>
    public class HtgCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static HtgCurrency()
        {
            Info = Currency.From(("G", CurrencyCodes.HTG, "332", "Haitian Gourde", "centime"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
