namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Xaf Currency
    /// </summary>
    public class XafCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static XafCurrency()
        {
            Info = Currency.From(("FCFA", CurrencyCodes.XAF, "950", "Central African CFA Franc", "centime"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
