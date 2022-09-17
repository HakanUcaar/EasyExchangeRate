namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Byn Currency
    /// </summary>
    public class BynCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BynCurrency()
        {
            Info = Currency.From(("Br", CurrencyCodes.BYN, "933", "Belarusian ruble",""));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
