namespace EasyExchangeRate.Common
{
    public class SzlCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static SzlCurrency()
        {
            Info = EasyCurrency.From(("L", CurrencyCodes.SZL, "748", "Swazi lilangeni"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
