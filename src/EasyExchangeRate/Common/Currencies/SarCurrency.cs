namespace EasyExchangeRate.Common
{
    public class SarCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static SarCurrency()
        {
            Info = Currency.From(("ر.س.", CurrencyCodes.SAR, "682", "Saudi Riyal", "halala"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
