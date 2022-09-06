namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mzn Currency
    /// </summary>
    public class MznCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MznCurrency()
        {
            Info = EasyCurrency.From(("MT", CurrencyCodes.MZN, "943", "Mozambican metical"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
