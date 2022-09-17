namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Vuv Currency
    /// </summary>
    public class VuvCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static VuvCurrency()
        {
            Info = Currency.From(("VT", CurrencyCodes.VUV, "548", "Vanuatu vatu",""));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
