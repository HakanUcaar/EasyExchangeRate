namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Nad Currency
    /// </summary>
    public class NadCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static NadCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.NAD, "516", "Namibian dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
