namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mop Currency
    /// </summary>
    public class MopCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MopCurrency()
        {
            Info = EasyCurrency.From(("MOP", CurrencyCodes.MOP, "446", "Macanese Pataca"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
