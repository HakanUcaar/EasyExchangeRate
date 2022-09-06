namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Ern Currency
    /// </summary>
    public class ErnCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static ErnCurrency()
        {
            Info = EasyCurrency.From(("Nfk", CurrencyCodes.ERN, "232", "Eritrean nakfa"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
