namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Eur Currency
    /// </summary>
    public class EurCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static EurCurrency()
        {
            Info = Currency.From(("€", CurrencyCodes.EUR, "978", "Euro", "cent"));
        }

        public Currency GetInfo()
        {
            return Info;
        }
    }
}
