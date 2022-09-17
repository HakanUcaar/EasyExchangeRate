namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mxn Currency
    /// </summary>
    public class MxnCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MxnCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.MXN, "484", "Mexican Peso", "centavo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
