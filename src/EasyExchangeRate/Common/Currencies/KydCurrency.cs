using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Kyd Currency
    /// </summary>
    public class KydCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static KydCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.KYD, "136", "Cayman Islands dollar", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
