namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Kpw Currency
    /// </summary>
    public class KpwCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static KpwCurrency()
        {
            Info = EasyCurrency.From(("₩", CurrencyCodes.KPW, "408", "North Korean won"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
