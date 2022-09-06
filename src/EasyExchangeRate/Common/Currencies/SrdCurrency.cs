namespace EasyExchangeRate.Common
{
    public class SosCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static SosCurrency()
        {
            Info = EasyCurrency.From(("S", CurrencyCodes.SOS, "706", "Somali Shilling"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
