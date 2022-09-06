namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Lbp Currency
    /// </summary>
    public class LbpCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static LbpCurrency()
        {
            Info = EasyCurrency.From(("ل.ل.‏", CurrencyCodes.LBP, "422", "Lebanese Pound"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
