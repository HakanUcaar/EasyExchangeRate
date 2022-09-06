namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Xdr Currency
    /// </summary>
    public class XdrCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static XdrCurrency()
        {
            Info = EasyCurrency.From(("XDR", CurrencyCodes.XDR, "960", "Special Drawing Rights"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
