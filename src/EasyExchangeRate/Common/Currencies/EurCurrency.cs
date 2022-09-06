namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Eur Currency
    /// </summary>
    public class EurCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static EurCurrency()
        {
            Info = EasyCurrency.From(("€", CurrencyCodes.EUR, "978", "Euro"));
        }

        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
