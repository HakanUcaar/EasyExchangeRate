namespace EasyExchangeRate.Common
{
    public class TwdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static TwdCurrency()
        {
            Info = Currency.From(("NT$", CurrencyCodes.TWD, "901", "New Taiwan Dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
