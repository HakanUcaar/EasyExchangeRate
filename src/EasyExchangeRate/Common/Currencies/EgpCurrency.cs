namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Egp Currency
    /// </summary>
    public class EgpCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static EgpCurrency()
        {
            Info = EasyCurrency.From(("ج.م.", CurrencyCodes.EGP, "818", "Egyptian pound"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
