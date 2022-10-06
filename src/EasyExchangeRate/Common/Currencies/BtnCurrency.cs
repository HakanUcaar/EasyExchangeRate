using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Btn Currency
    /// </summary>
    public class BtnCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BtnCurrency()
        {
            Info = Currency.From(("Nu.", CurrencyCodes.BTN, "064", "Bhutanese ngultrum", "chetrum"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
