namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Crc Currency
    /// </summary>
    public class CrcCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static CrcCurrency()
        {
            Info = EasyCurrency.From(("₡", CurrencyCodes.CRC, "188", "Costa Rican colon"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
