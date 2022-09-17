namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Gnf Currency
    /// </summary>
    public class GnfCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static GnfCurrency()
        {
            Info = Currency.From(("FG", CurrencyCodes.GNF, "324", "Guinean franc", "centime"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
