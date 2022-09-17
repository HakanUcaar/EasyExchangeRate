namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Nzd Currency
    /// </summary>
    public class NzdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static NzdCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.NZD, "554", "New Zealand Dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
