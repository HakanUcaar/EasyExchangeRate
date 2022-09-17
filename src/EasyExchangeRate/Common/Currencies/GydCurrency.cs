namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Gyd Currency
    /// </summary>
    public class GydCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static GydCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.GYD, "328", "Guyanese dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
