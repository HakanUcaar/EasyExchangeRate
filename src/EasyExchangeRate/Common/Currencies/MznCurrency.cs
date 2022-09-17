namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mzn Currency
    /// </summary>
    public class MznCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MznCurrency()
        {
            Info = Currency.From(("MT", CurrencyCodes.MZN, "943", "Mozambican metical", "centavo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
