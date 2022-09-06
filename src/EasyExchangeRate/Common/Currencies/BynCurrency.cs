namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Byn Currency
    /// </summary>
    public class BynCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BynCurrency()
        {
            Info = EasyCurrency.From(("Br", CurrencyCodes.BYN, "933", "Belarusian ruble"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
