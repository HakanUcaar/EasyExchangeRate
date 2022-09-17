namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mwk Currency
    /// </summary>
    public class MwkCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MwkCurrency()
        {
            Info = Currency.From(("K", CurrencyCodes.MWK, "454", "Malawian kwacha", "tambala"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
