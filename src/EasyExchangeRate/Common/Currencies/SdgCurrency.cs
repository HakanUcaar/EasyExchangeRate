namespace EasyExchangeRate.Common
{
    public class SdgCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static SdgCurrency()
        {
            Info = EasyCurrency.From(("SDG", CurrencyCodes.SDG, "938", "Sudanese pound"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
