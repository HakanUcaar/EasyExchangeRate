namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Chf Currency
    /// </summary>
    public class ChfCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static ChfCurrency()
        {
            Info = EasyCurrency.From(("CHF", CurrencyCodes.CHF, "756", "Swiss franc"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
