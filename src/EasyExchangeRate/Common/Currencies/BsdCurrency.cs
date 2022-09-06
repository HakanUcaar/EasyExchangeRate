namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bsd Currency
    /// </summary>
    public class BsdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BsdCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.BSD, "044", "Bahamian dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
