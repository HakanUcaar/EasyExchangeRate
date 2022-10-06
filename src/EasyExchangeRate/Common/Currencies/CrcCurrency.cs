using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Crc Currency
    /// </summary>
    public class CrcCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static CrcCurrency()
        {
            Info = Currency.From(("₡", CurrencyCodes.CRC, "188", "Costa Rican colon", "céntimo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
