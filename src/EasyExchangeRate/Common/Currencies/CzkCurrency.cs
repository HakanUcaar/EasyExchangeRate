namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Czk Currency
    /// </summary>
    public class CzkCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static CzkCurrency()
        {
            Info = EasyCurrency.From(("Kč", CurrencyCodes.CZK, "203", "Czech koruna"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
