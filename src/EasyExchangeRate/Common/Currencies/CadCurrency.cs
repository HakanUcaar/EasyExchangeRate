namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cad Currency
    /// </summary>
    public class CadCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static CadCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.CAD, "124", "Canadian dollar", "colloquial"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
