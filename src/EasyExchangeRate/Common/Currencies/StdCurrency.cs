namespace EasyExchangeRate.Common
{
    public class StdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static StdCurrency()
        {
            Info = EasyCurrency.From(("Db", CurrencyCodes.STD, "678", "São Tomé and Príncipe dobra"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
