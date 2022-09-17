namespace EasyExchangeRate.Common
{
    public class ScrCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static ScrCurrency()
        {
            Info = Currency.From(("SCR", CurrencyCodes.SCR, "690", "Seychelles rupee", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
