namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Xaf Currency
    /// </summary>
    public class XafCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static XafCurrency()
        {
            Info = EasyCurrency.From(("FCFA", CurrencyCodes.XAF, "950", "Central African CFA Franc"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
