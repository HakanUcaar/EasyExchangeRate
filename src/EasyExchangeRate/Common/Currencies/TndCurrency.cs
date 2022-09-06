namespace EasyExchangeRate.Common
{
    public class TndCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static TndCurrency()
        {
            Info = EasyCurrency.From(("د.ت.", CurrencyCodes.TND, "788", "Tunisian Dinar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
