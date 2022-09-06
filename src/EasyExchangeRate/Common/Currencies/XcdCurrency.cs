namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Xcd Currency
    /// </summary>
    public class XcdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static XcdCurrency()
        {
            Info = EasyCurrency.From(("EC$", CurrencyCodes.XCD, "951", "East Caribbean Dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
