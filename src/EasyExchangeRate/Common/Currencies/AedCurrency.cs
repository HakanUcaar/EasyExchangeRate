namespace EasyExchangeRate.Common
{
    /// <summary>
    /// United Arab Emirates dirham
    /// </summary>
    public class AedCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static AedCurrency()
        {
            Info = EasyCurrency.From(("د.إ.", CurrencyCodes.AED, "784", "United Arab Emirates dirham"));
        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
