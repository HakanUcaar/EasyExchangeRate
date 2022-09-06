namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bbd Currency
    /// </summary>
    public class BbdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BbdCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.BBD, "052", "Barbadian dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
