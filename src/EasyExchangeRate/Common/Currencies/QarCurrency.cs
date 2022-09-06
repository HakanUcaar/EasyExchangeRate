namespace EasyExchangeRate.Common
{
    public class QarCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static QarCurrency()
        {
            Info = EasyCurrency.From(("ر.ق.", CurrencyCodes.QAR, "634", "Qatari Rial"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
