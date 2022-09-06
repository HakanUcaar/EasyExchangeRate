namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bwp Currency
    /// </summary>
    public class BwpCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BwpCurrency()
        {
            Info = EasyCurrency.From(("P", CurrencyCodes.BWP, "072", "Botswana pula"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
