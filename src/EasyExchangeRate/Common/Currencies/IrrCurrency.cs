namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Irr Currency
    /// </summary>
    public class IrrCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static IrrCurrency()
        {
            Info =  Currency.From(("ريال", CurrencyCodes.IRR, "364", "Iranian Rial", "dinar"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
