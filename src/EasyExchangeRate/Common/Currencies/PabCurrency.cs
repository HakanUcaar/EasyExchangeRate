namespace EasyExchangeRate.Common
{
    public class PabCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static PabCurrency()
        {
            Info = EasyCurrency.From(("B/.", CurrencyCodes.PAB, "590", "Panamanian Balboa"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
