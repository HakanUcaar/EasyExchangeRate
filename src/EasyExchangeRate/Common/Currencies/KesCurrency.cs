namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Kes Currency
    /// </summary>
    public class KesCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static KesCurrency()
        {
            Info = EasyCurrency.From(("Ksh", CurrencyCodes.KES, "404", "Kenyan Shilling"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
