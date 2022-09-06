namespace EasyExchangeRate.Common
{
    public class TjsCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static TjsCurrency()
        {
            Info = EasyCurrency.From(("смн", CurrencyCodes.TJS, "972", "Tajikistani Somoni"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
