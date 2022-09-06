namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Hkd Currency
    /// </summary>
    public class HkdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static HkdCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.HKD, "344", "Hong Kong Dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
