namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Nzd Currency
    /// </summary>
    public class NzdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static NzdCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.NZD, "554", "New Zealand Dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
