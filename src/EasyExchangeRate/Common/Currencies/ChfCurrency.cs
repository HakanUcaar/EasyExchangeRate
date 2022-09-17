namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Chf Currency
    /// </summary>
    public class ChfCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static ChfCurrency()
        {
            Info = Currency.From(("CHF", CurrencyCodes.CHF, "756", "Swiss franc", "francs"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
