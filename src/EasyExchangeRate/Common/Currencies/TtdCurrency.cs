namespace EasyExchangeRate.Common
{
    public class TtdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static TtdCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.TTD, "780", "Trinidad and Tobago Dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
