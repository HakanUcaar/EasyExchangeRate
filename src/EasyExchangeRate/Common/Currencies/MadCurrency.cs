namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mad Currency
    /// </summary>
    public class MadCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MadCurrency()
        {
            Info = EasyCurrency.From(("د.م.", CurrencyCodes.MAD, "504", "Moroccan Dirham"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
