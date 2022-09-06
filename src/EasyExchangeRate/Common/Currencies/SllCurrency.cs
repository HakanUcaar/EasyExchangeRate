namespace EasyExchangeRate.Common
{
    public class SllCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static SllCurrency()
        {
            Info = EasyCurrency.From(("Le", CurrencyCodes.SLL, "694", "Sierra Leonean leone"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
