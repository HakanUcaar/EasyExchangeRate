namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Khr Currency
    /// </summary>
    public class KhrCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static KhrCurrency()
        {
            Info = EasyCurrency.From(("៛", CurrencyCodes.KHR, "116", "Cambodian Riel"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
