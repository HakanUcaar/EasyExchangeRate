namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Try Currency
    /// </summary>
    public class TryCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static TryCurrency()
        {
            Info = Currency.From(("₺", CurrencyCodes.TRY, "949", "Turkish Lira", "kuruş"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
