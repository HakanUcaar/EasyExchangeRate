namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Lsl Currency
    /// </summary>
    public class LslCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static LslCurrency()
        {
            Info = Currency.From(("L", CurrencyCodes.LSL, "426", "Lesotho loti", "sente"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
