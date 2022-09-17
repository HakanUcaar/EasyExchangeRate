namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cup Currency
    /// </summary>
    public class CupCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static CupCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.CUP, "192", "Cuban peso", "centavo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
