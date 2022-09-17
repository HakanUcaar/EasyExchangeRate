namespace EasyExchangeRate.Common
{
    public class PabCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static PabCurrency()
        {
            Info = Currency.From(("B/.", CurrencyCodes.PAB, "590", "Panamanian Balboa", "cent�simo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
