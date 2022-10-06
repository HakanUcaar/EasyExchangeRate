using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class QarCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static QarCurrency()
        {
            Info = Currency.From(("ر.ق.", CurrencyCodes.QAR, "634", "Qatari Rial", "dirham"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
