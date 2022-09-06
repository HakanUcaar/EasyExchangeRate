namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Albanian lek
    /// </summary>
    public class AllCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static AllCurrency()
        {
            Info = EasyCurrency.From(("L", CurrencyCodes.ALL, "008", "Albanian lek"));
        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
