namespace EasyExchangeRate.Common
{
    public class SspCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static SspCurrency()
        {
            Info = EasyCurrency.From(("SS£", CurrencyCodes.SSP, "728", "South Sudanese pound"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
