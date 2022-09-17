namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bbd Currency
    /// </summary>
    public class BbdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BbdCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.BBD, "052", "Barbadian dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
