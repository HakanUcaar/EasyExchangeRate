namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Xof Currency
    /// </summary>
    public class XofCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static XofCurrency()
        {
            Info = EasyCurrency.From(("CFA", CurrencyCodes.XOF, "952", "West African CFA Franc"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
