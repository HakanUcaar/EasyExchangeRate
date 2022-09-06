namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Syp Currency
    /// </summary>
    public class SypCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static SypCurrency()
        {
            Info = EasyCurrency.From(("ل.س.‏", CurrencyCodes.SYP, "760", "Syrian Pound"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
