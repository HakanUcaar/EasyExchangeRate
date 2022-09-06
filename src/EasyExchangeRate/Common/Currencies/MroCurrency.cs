namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mro Currency
    /// </summary>
    public class MroCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MroCurrency()
        {
            Info = EasyCurrency.From(("UM", CurrencyCodes.MRO, "478", "Mauritanian ouguiya"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
