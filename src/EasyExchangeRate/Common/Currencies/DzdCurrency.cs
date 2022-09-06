namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Dzd Currency
    /// </summary>
    public class DzdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static DzdCurrency()
        {
            Info = EasyCurrency.From(("د.ج.", CurrencyCodes.DZD, "012", "Algerian dinar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
