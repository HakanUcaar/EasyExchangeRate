namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Nad Currency
    /// </summary>
    public class NadCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static NadCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.NAD, "516", "Namibian dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
