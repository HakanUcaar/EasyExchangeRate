namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Azn Currency
    /// </summary>
    public class AznCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static AznCurrency()
        {
            Info = EasyCurrency.From(("₼", CurrencyCodes.AZN, "944", "Azerbaijani manat"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
