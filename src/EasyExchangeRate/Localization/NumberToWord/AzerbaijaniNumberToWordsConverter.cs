using EasyExchangeRate.Abstractions;
using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Localization.NumberToWord
{
    public class AzerbaijaniNumberToWordsConverter : AbstractNumberToWordConverter
    {
        public AzerbaijaniNumberToWordsConverter()
        {
            AddDigit(Digit.From(("Sıfır", "", 0)));
            AddDigit(Digit.From(("Bir", "", 1)));
            AddDigit(Digit.From(("İki", "", 2)));
            AddDigit(Digit.From(("Üç", "", 3)));
            AddDigit(Digit.From(("Dörd", "", 4)));
            AddDigit(Digit.From(("Beş", "", 5)));
            AddDigit(Digit.From(("Altı", "", 6)));
            AddDigit(Digit.From(("Yeddi", "", 7)));
            AddDigit(Digit.From(("Səkkiz", "", 8)));
            AddDigit(Digit.From(("Doqquz", "", 9)));
            AddDigit(Digit.From(("On", "", 10)));
            AddDigit(Digit.From(("İyirmi", "", 20)));
            AddDigit(Digit.From(("Otuz", "", 30)));
            AddDigit(Digit.From(("Qırx", "", 40)));
            AddDigit(Digit.From(("Əlli", "", 50)));
            AddDigit(Digit.From(("Altmış", "", 60)));
            AddDigit(Digit.From(("Yetmiş", "", 70)));
            AddDigit(Digit.From(("Səksən", "", 80)));
            AddDigit(Digit.From(("Doxsan", "", 90)));
            AddDigit(Digit.From(("Yüz", "", 100)));
            AddDigit(Digit.From(("Bin", "", 1000)));
            AddDigit(Digit.From(("Milyon", "", 1000000)));
            AddDigit(Digit.From(("Milyard", "", 1000000000)));
            AddDigit(Digit.From(("Trilyon", "", 1000000000000)));
            AddDigit(Digit.From(("Katrilyon", "", 1000000000000000)));
            AddDigit(Digit.From(("Sextillion", "", 1000000000000000000)));
        }
        public static AzerbaijaniNumberToWordsConverter New()
        {
            return new AzerbaijaniNumberToWordsConverter();
        }
    }
}
