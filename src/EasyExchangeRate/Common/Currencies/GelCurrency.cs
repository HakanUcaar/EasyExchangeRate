namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Gel Currency
    /// </summary>
    public class GelCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static GelCurrency()
        {
            Info = EasyCurrency.From(("₾", CurrencyCodes.GEL, "981", "Georgian Lari"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
