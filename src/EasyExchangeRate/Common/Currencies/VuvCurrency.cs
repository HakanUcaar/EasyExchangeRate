namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Vuv Currency
    /// </summary>
    public class VuvCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static VuvCurrency()
        {
            Info = EasyCurrency.From(("VT", CurrencyCodes.VUV, "548", "Vanuatu vatu"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
