namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Thb Currency
    /// </summary>
    public class ThbCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static ThbCurrency()
        {
            Info = EasyCurrency.From(("฿", CurrencyCodes.THB, "764", "Thai Baht"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
