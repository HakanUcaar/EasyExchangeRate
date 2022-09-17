namespace EasyExchangeRate.Common
{
    public class PenCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static PenCurrency()
        {
            Info = Currency.From(("S/", CurrencyCodes.PEN, "604", "Peruvian Sol", "céntimo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
