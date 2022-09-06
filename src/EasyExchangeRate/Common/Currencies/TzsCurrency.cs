namespace EasyExchangeRate.Common
{
    public class TzsCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static TzsCurrency()
        {
            Info = EasyCurrency.From(("TSh", CurrencyCodes.TZS, "834", "Tanzanian shilling"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
 }
