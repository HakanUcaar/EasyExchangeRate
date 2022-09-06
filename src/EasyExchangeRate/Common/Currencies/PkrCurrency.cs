namespace EasyExchangeRate.Common
{
    public class PkrCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static PkrCurrency()
        {
            Info = EasyCurrency.From(("Rs", CurrencyCodes.PKR, "586", "Pakistani Rupee"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
