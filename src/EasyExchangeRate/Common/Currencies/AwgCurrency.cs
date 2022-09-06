namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Awg Currency
    /// </summary>
    public class AwgCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static AwgCurrency()
        {
            Info = EasyCurrency.From(("Afl", CurrencyCodes.AUD, "533", "Aruban florin"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
