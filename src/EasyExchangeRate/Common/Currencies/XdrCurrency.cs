namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Xdr Currency
    /// </summary>
    public class XdrCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static XdrCurrency()
        {
            Info = Currency.From(("XDR", CurrencyCodes.XDR, "960", "Special Drawing Rights", "Xdr"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
