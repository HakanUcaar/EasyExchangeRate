namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cop Currency
    /// </summary>
    public class CopCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static CopCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.COP, "170", "Colombian peso", "centavo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
