namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Uyu Currency
    /// </summary>
    public class UyuCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static UyuCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.UYU, "858", "Uruguayan Peso"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
