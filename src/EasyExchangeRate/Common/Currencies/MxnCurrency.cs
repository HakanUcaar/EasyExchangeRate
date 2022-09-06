namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mxn Currency
    /// </summary>
    public class MxnCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MxnCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.MXN, "484", "Mexican Peso"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
