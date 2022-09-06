namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mkd Currency
    /// </summary>
    public class MkdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MkdCurrency()
        {
            Info = EasyCurrency.From(("ден", CurrencyCodes.MKD, "807", "Macedonian Denar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
