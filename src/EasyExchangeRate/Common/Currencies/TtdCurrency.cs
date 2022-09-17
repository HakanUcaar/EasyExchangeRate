namespace EasyExchangeRate.Common
{
    public class TtdCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static TtdCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.TTD, "780", "Trinidad and Tobago Dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
