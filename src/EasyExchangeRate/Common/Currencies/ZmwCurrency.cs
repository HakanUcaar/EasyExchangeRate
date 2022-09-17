namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Zmw Currency
    /// </summary>
    public class ZmwCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static ZmwCurrency()
        {
            Info = Currency.From(("K", CurrencyCodes.ZMW, "967", "Zambian kwacha",""));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
