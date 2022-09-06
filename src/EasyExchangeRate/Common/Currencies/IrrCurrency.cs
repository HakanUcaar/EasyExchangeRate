namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Irr Currency
    /// </summary>
    public class IrrCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static IrrCurrency()
        {
            Info =  EasyCurrency.From(("ريال", CurrencyCodes.IRR, "364", "Iranian Rial"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
