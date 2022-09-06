namespace EasyExchangeRate.Common
{
    public class RsdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static RsdCurrency()
        {
            Info = EasyCurrency.From(("дин.", CurrencyCodes.RSD, "941", "Serbian Dinar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
