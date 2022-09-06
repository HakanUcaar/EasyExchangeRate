namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Ang Currency
    /// </summary>
    public class AngCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static AngCurrency()
        {
            Info = EasyCurrency.From(("NAƒ", CurrencyCodes.ANG, "532", "Netherlands Antillean guilder"));
        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
