namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mwk Currency
    /// </summary>
    public class MwkCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MwkCurrency()
        {
            Info = EasyCurrency.From(("K", CurrencyCodes.MWK, "454", "Malawian kwacha"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
