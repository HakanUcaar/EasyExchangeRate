using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Brl Currency
    /// </summary>
    public class BrlCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BrlCurrency()
        {
            Info = Currency.From(("R$", CurrencyCodes.BRL, "986", "Brazilian real", "centavo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
