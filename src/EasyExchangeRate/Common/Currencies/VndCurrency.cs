namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Vnd Currency
    /// </summary>
    public class VndCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static VndCurrency()
        {
            Info = Currency.From(("₫", CurrencyCodes.VND, "704", "Vietnamese Dong", "xu"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
