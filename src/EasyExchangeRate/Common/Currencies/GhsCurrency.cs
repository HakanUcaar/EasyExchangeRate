namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Ghs Currency
    /// </summary>
    public class GhsCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static GhsCurrency()
        {
            Info = EasyCurrency.From(("GH₵", CurrencyCodes.GHS, "936", "Ghanaian cedi"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
