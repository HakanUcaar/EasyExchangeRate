namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Htg Currency
    /// </summary>
    public class HtgCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static HtgCurrency()
        {
            Info = EasyCurrency.From(("G", CurrencyCodes.HTG, "332", "Haitian Gourde"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
