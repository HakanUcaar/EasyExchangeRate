namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Gtq Currency
    /// </summary>
    public class GtqCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static GtqCurrency()
        {
            Info = EasyCurrency.From(("Q", CurrencyCodes.GTQ, "320", "Guatemalan Quetzal"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
