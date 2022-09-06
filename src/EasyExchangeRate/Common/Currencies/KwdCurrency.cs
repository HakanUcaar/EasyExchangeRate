namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Kwd Currency
    /// </summary>
    public class KwdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static KwdCurrency()
        {
            Info = EasyCurrency.From(("د.ك.", CurrencyCodes.KWD, "414", "Kuwaiti Dinar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
