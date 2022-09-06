namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Gyd Currency
    /// </summary>
    public class GydCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static GydCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.GYD, "328", "Guyanese dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
