using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Mur Currency
    /// </summary>
    public class MurCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MurCurrency()
        {
            Info = Currency.From(("₨", CurrencyCodes.MUR, "480", "Mauritian rupee", "cent"));
        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
