namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Gmd Currency
    /// </summary>
    public class GmdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static GmdCurrency()
        {
            Info = Currency.From(("D", CurrencyCodes.GMD, "270", "Gambian dalasi", "butut"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
