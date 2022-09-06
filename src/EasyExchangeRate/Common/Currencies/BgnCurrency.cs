namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bgn Currency
    /// </summary>
    public class BgnCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BgnCurrency()
        {
            Info = EasyCurrency.From(("лв.", CurrencyCodes.BGN, "975", "Bulgarian lev"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
