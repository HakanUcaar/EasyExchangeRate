using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Bgn Currency
    /// </summary>
    public class BgnCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BgnCurrency()
        {
            Info = Currency.From(("лв.", CurrencyCodes.BGN, "975", "Bulgarian lev", "stotinka"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
