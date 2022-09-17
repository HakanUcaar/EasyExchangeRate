namespace EasyExchangeRate.Common
{
    public class TmtCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static TmtCurrency()
        {
            Info = Currency.From(("m.", CurrencyCodes.TMT, "934", "Turkmenistani Manat", "teňňe"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
