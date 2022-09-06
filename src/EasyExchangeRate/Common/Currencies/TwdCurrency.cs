namespace EasyExchangeRate.Common
{
    public class TwdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static TwdCurrency()
        {
            Info = EasyCurrency.From(("NT$", CurrencyCodes.TWD, "901", "New Taiwan Dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
