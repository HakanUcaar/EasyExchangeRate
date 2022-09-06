namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Jpy Currency
    /// </summary>
    public class JpyCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static JpyCurrency()
        {
            Info = EasyCurrency.From(("¥", CurrencyCodes.JPY, "392", "Japanese Yen"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
