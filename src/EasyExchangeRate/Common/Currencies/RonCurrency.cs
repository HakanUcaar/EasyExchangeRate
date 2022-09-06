namespace EasyExchangeRate.Common
{
    public class RonCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static RonCurrency()
        {
            Info = EasyCurrency.From(("lei", CurrencyCodes.RON, "946", "Romanian Leu"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
