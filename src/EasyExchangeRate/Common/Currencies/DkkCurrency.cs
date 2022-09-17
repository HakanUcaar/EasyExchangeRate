namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Dkk Currency
    /// </summary>
    public class DkkCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static DkkCurrency()
        {
            Info = Currency.From(("kr.", CurrencyCodes.DKK, "208", "Danish krone", "øre"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
