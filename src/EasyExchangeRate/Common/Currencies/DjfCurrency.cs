namespace EasyExchangeRate.Common
{
    public class DjfCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static DjfCurrency()
        {
            Info = EasyCurrency.From(("Fdj", CurrencyCodes.DJF, "262", "Djiboutian franc"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
