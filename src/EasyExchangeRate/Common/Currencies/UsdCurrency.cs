namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Usd Currency
    /// </summary>
    public class UsdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static UsdCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.USD, "840", "US Dollar", "Cent"));
        }

        public Currency GetInfo()
        {
            return Info;
        }
    }
}
