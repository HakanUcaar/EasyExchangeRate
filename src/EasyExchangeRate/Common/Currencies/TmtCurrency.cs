namespace EasyExchangeRate.Common
{
    public class TmtCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static TmtCurrency()
        {
            Info = EasyCurrency.From(("m.", CurrencyCodes.TMT, "934", "Turkmenistani Manat"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
