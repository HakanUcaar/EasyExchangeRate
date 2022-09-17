namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Ars Currency
    /// </summary>
    public class ArsCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static ArsCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.ARS, "032", "Argentine peso", "centavo"));
        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
