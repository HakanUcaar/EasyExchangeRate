using EasyExchangeRate.Abstractions;
using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Localization.NumberToWord
{
    public class TurkishNumberToWordConverter : AbstractNumberToWordConverter
    {
        public TurkishNumberToWordConverter()
        {
            AddDigit(Digit.From(("Sıfır","", 0)));
            AddDigit(Digit.From(("Bir","", 1)));
            AddDigit(Digit.From(("İki", "", 2)));
            AddDigit(Digit.From(("Üç", "", 3)));
            AddDigit(Digit.From(("Dört", "", 4)));
            AddDigit(Digit.From(("Beş", "", 5)));
            AddDigit(Digit.From(("Altı", "", 6)));
            AddDigit(Digit.From(("Yedi", "", 7)));
            AddDigit(Digit.From(("Sekiz", "", 8)));
            AddDigit(Digit.From(("Dokuz", "", 9)));
            AddDigit(Digit.From(("On", "", 10)));
            AddDigit(Digit.From(("Yirmi", "", 20)));
            AddDigit(Digit.From(("Otuz", "", 30)));
            AddDigit(Digit.From(("Kırk", "", 40)));
            AddDigit(Digit.From(("Elli", "", 50)));
            AddDigit(Digit.From(("Altmış", "", 60)));
            AddDigit(Digit.From(("Yetmiş", "", 70)));
            AddDigit(Digit.From(("Seksen", "", 80)));
            AddDigit(Digit.From(("Doksan", "", 90)));
            AddDigit(Digit.From(("Yüz", "", 100)));
            AddDigit(Digit.From(("Bin", "", 1000)));
            AddDigit(Digit.From(("Milyon", "", 1000000)));
            AddDigit(Digit.From(("Milyar", "", 1000000000)));
            AddDigit(Digit.From(("Trilyon", "", 1000000000000)));
            AddDigit(Digit.From(("Katrilyon", "", 1000000000000000)));
            AddDigit(Digit.From(("Sextillion", "", 1000000000000000000)));
        }
        public static TurkishNumberToWordConverter New()
        {
            return new TurkishNumberToWordConverter();
        }
    }
}
