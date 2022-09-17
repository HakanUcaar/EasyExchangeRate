namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Syp Currency
    /// </summary>
    public class SypCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static SypCurrency()
        {
            Info = Currency.From(("ل.س.‏", CurrencyCodes.SYP, "760", "Syrian Pound", "piastre"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
