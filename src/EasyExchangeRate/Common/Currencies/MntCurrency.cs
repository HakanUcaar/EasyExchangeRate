namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mnt Currency
    /// </summary>
    public class MntCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MntCurrency()
        {
            Info = EasyCurrency.From(("₮", CurrencyCodes.MNT, "496", "Mongolian Tugrik"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
