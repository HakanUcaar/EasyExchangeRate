namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Aoa Currency
    /// </summary>
    public class AoaCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static AoaCurrency()
        {
            Info = EasyCurrency.From(("Kz", CurrencyCodes.AOA, "973", "Angolan kwanza"));
        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
