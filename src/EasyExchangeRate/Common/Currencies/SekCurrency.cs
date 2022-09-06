namespace EasyExchangeRate.Common
{
    public class SekCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static SekCurrency()
        {
            Info =  EasyCurrency.From(("kr", CurrencyCodes.SEK, "752", "Swedish Krona"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
