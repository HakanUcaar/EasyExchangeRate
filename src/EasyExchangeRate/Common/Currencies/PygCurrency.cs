using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class PygCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static PygCurrency()
        {
            Info = Currency.From(("₲", CurrencyCodes.PYG, "600", "Paraguayan Guarani", "céntimo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
