namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Dop Currency
    /// </summary>
    public class DopCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static DopCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.DOP, "214", "Dominican peso", "centavo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
