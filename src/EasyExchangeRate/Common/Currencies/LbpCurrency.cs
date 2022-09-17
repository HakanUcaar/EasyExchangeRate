namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Lbp Currency
    /// </summary>
    public class LbpCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static LbpCurrency()
        {
            Info = Currency.From(("ل.ل.‏", CurrencyCodes.LBP, "422", "Lebanese Pound", "piastre"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
