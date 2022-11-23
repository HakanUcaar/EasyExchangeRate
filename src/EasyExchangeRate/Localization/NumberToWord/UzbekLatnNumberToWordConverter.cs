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
    public class UzbekLatnNumberToWordConverter : AbstractNumberToWordConverter
    {
        public UzbekLatnNumberToWordConverter()
        {
            AddDigit(Digit.From(("Nol", "", 0)));
            AddDigit(Digit.From(("Bir", "", 1)));
            AddDigit(Digit.From(("İkki", "", 2)));
            AddDigit(Digit.From(("Uch", "", 3)));
            AddDigit(Digit.From(("To`rt", "", 4)));
            AddDigit(Digit.From(("Besh", "", 5)));
            AddDigit(Digit.From(("Olti", "", 6)));
            AddDigit(Digit.From(("Yetti", "", 7)));
            AddDigit(Digit.From(("Sakkiz", "", 8)));
            AddDigit(Digit.From(("To`qqiz", "", 9)));
            AddDigit(Digit.From(("O`n", "", 10)));
            AddDigit(Digit.From(("Yigirma", "", 20)));
            AddDigit(Digit.From(("O`ttiz", "", 30)));
            AddDigit(Digit.From(("Qirq", "", 40)));
            AddDigit(Digit.From(("Ellik", "", 50)));
            AddDigit(Digit.From(("Oltmish", "", 60)));
            AddDigit(Digit.From(("Yetmish", "", 70)));
            AddDigit(Digit.From(("Sakson", "", 80)));
            AddDigit(Digit.From(("To`qson", "", 90)));
            AddDigit(Digit.From(("Yuz", "", 100)));
            AddDigit(Digit.From(("Ming", "", 1000)));
            AddDigit(Digit.From(("Million", "", 1000000)));
            AddDigit(Digit.From(("Milliard ", "", 1000000000)));
            AddDigit(Digit.From(("Trilyon", "", 1000000000000)));
            AddDigit(Digit.From(("Katrilyon", "", 1000000000000000)));
            AddDigit(Digit.From(("Sextillion", "", 1000000000000000000)));
        }
        public static UzbekLatnNumberToWordConverter New()
        {
            return new UzbekLatnNumberToWordConverter();
        }
        public override string Convert(long number)
        {
            if (number <= 0)
            {
                return "";
            }

            var listWord = new List<string>();

            Digits.Last(x => number >= x.Number).Do(x =>
            {
                listWord.Add((1 == (number / x.Number) && Math.Floor(Math.Log10(number) + 1) < 3) ? x.Singular : $"{Convert(number / x.Number)}{x.Singular}");
                listWord.Add(Convert(number % x.Number));
            });

            return string.Join(" ", listWord.ToArray());
        }
    }
}
