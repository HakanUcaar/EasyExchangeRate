namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Aoa Currency
    /// </summary>
    public class AoaCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static AoaCurrency()
        {
            Info = Currency.From(("Kz", CurrencyCodes.AOA, "973", "Angolan kwanza", "cêntimo"));
        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
