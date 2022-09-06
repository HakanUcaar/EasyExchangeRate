namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Gmd Currency
    /// </summary>
    public class GmdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static GmdCurrency()
        {
            Info = EasyCurrency.From(("D", CurrencyCodes.GMD, "270", "Gambian dalasi"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
