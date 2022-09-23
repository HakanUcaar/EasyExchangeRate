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
    public class EnglishNumberToWordsConverter : AbstractNumberToWordConverter
    {
        public EnglishNumberToWordsConverter()
        {
            AddDigit(Digit.From(("Zero", "", 0)));
            AddDigit(Digit.From(("One", "", 1)));
            AddDigit(Digit.From(("Two", "", 2)));
            AddDigit(Digit.From(("Three", "", 3)));
            AddDigit(Digit.From(("Four", "", 4)));
            AddDigit(Digit.From(("Five", "", 5)));
            AddDigit(Digit.From(("Six", "", 6)));
            AddDigit(Digit.From(("Seven", "", 7)));
            AddDigit(Digit.From(("Eight", "", 8)));
            AddDigit(Digit.From(("Nine", "", 9)));
            AddDigit(Digit.From(("Ten", "", 10)));

            AddDigit(Digit.From(("Eleven", "", 11)));
            AddDigit(Digit.From(("Twelve", "", 12)));
            AddDigit(Digit.From(("Thirteen", "", 13)));
            AddDigit(Digit.From(("Fourteen", "", 14)));
            AddDigit(Digit.From(("Fifteen", "", 15)));
            AddDigit(Digit.From(("Sixteen", "", 16)));
            AddDigit(Digit.From(("Seventeen", "", 17)));
            AddDigit(Digit.From(("Eighteen", "", 18)));
            AddDigit(Digit.From(("Nineteen", "", 19)));


            AddDigit(Digit.From(("Twenty", "", 20)));
            AddDigit(Digit.From(("Thirty", "", 30)));
            AddDigit(Digit.From(("Forty", "", 40)));
            AddDigit(Digit.From(("Fifty", "", 50)));
            AddDigit(Digit.From(("Sixty", "", 60)));
            AddDigit(Digit.From(("Seventy", "", 70)));
            AddDigit(Digit.From(("Eighty", "", 80)));
            AddDigit(Digit.From(("Ninety", "", 90)));
            AddDigit(Digit.From(("Hundred", "", 100)));
            AddDigit(Digit.From(("Thousand", "", 1000)));
            AddDigit(Digit.From(("Million", "", 1000000)));
            AddDigit(Digit.From(("Billion", "", 1000000000)));
            AddDigit(Digit.From(("Trillion", "", 1000000000000)));
            AddDigit(Digit.From(("Quadrillion", "", 1000000000000000)));
            AddDigit(Digit.From(("Quintillion", "", 1000000000000000000)));
        }
        public static EnglishNumberToWordsConverter New()
        {
            return new EnglishNumberToWordsConverter();
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
