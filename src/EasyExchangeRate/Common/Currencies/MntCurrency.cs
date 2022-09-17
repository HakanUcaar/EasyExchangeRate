namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mnt Currency
    /// </summary>
    public class MntCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MntCurrency()
        {
            Info = Currency.From(("₮", CurrencyCodes.MNT, "496", "Mongolian Tugrik", "мөнгө"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
