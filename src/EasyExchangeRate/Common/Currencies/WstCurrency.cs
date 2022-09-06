namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Wst Currency
    /// </summary>
    public class WstCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static WstCurrency()
        {
            Info = EasyCurrency.From(("WS$", CurrencyCodes.WST, "882", "Samoan tala"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
