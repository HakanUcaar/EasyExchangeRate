namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bdt Currency
    /// </summary>
    public class BdtCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BdtCurrency()
        {
            Info = Currency.From(("৳", CurrencyCodes.BDT, "050", "Bangladeshi taka", "paisa"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
