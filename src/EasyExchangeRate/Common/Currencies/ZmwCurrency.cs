namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Zmw Currency
    /// </summary>
    public class ZmwCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static ZmwCurrency()
        {
            Info = EasyCurrency.From(("K", CurrencyCodes.ZMW, "967", "Zambian kwacha"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
