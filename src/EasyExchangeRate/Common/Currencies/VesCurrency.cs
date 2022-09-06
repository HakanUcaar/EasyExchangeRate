namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Ves Currency
    /// </summary>
    public class VesCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static VesCurrency()
        {
            Info = EasyCurrency.From(("Bs.S", CurrencyCodes.VES, "928", "Venezuelan Bolívar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
