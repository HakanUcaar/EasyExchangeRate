namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Xpf Currency
    /// </summary>
    public class XpfCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static XpfCurrency()
        {
            Info = EasyCurrency.From(("R", CurrencyCodes.ZAR, "710", "South African Rand"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
