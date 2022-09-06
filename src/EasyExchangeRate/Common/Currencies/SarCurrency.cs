namespace EasyExchangeRate.Common
{
    public class SarCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static SarCurrency()
        {
            Info = EasyCurrency.From(("ر.س.", CurrencyCodes.SAR, "682", "Saudi Riyal"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
