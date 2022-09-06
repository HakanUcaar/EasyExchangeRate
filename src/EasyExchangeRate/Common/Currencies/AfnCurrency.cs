namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Afghan afghani
    /// </summary>
    public class AfnCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static AfnCurrency()
        {
            Info = EasyCurrency.From(("؋", CurrencyCodes.AFN, "971", "Afghan afghani"));
        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
