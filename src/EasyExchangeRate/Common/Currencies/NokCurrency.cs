namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Nok Currency
    /// </summary>
    public class NokCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static NokCurrency()
        {
            Info = EasyCurrency.From(("kr", CurrencyCodes.NOK, "578", "Norwegian Krone"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
