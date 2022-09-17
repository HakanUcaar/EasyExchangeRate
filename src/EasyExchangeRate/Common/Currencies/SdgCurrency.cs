namespace EasyExchangeRate.Common
{
    public class SdgCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static SdgCurrency()
        {
            Info = Currency.From(("SDG", CurrencyCodes.SDG, "938", "Sudanese pound", "qirsh"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
