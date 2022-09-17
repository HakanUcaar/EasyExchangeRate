namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Kwd Currency
    /// </summary>
    public class KwdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static KwdCurrency()
        {
            Info = Currency.From(("د.ك.", CurrencyCodes.KWD, "414", "Kuwaiti Dinar", "fils"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
