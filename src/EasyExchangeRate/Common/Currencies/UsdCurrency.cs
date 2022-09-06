namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Usd Currency
    /// </summary>
    public class UsdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static UsdCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.USD, "840", "US Dollar"));
        }

        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
