namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Try Currency
    /// </summary>
    public class TryCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static TryCurrency()
        {
            Info = EasyCurrency.From(("₺", CurrencyCodes.TRY, "949", "Turkish Lira"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
