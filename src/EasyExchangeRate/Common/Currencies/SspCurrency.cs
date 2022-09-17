namespace EasyExchangeRate.Common
{
    public class SspCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static SspCurrency()
        {
            Info = Currency.From(("SS£", CurrencyCodes.SSP, "728", "South Sudanese pound",""));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
