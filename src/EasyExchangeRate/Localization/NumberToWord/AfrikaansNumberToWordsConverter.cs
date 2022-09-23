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
    //To-Do
    public class AfrikaansNumberToWordsConverter : AbstractNumberToWordConverter
    {
        public AfrikaansNumberToWordsConverter()
        {
            AddDigit(Digit.From(("Nul", "", 0)));
            AddDigit(Digit.From(("Een", "", 1)));
            AddDigit(Digit.From(("Twee", "", 2)));
            AddDigit(Digit.From(("Drie", "", 3)));
            AddDigit(Digit.From(("Vier", "", 4)));
            AddDigit(Digit.From(("Vyf", "", 5)));
            AddDigit(Digit.From(("Ses", "", 6)));
            AddDigit(Digit.From(("Sewe", "", 7)));
            AddDigit(Digit.From(("Agt", "", 8)));
            AddDigit(Digit.From(("Nege", "", 9)));
            AddDigit(Digit.From(("Tien", "", 10)));

            AddDigit(Digit.From(("Elf", "", 11)));
            AddDigit(Digit.From(("Twaalf", "", 12)));
            AddDigit(Digit.From(("Dertien", "", 13)));
            AddDigit(Digit.From(("Veertien", "", 14)));
            AddDigit(Digit.From(("Vyftien", "", 15)));
            AddDigit(Digit.From(("Sestien", "", 16)));
            AddDigit(Digit.From(("Sewentien", "", 17)));
            AddDigit(Digit.From(("Agtien", "", 18)));
            AddDigit(Digit.From(("Negentien", "", 19)));

            AddDigit(Digit.From(("Twintig", "", 20)));
            AddDigit(Digit.From(("Dertig", "", 30)));
            AddDigit(Digit.From(("Veertig", "", 40)));
            AddDigit(Digit.From(("Vyftig", "", 50)));
            AddDigit(Digit.From(("Sestig", "", 60)));
            AddDigit(Digit.From(("Sewentig", "", 70)));
            AddDigit(Digit.From(("Tagtig", "", 80)));
            AddDigit(Digit.From(("Negentig", "", 90)));
            AddDigit(Digit.From(("Honderd", "", 100)));
            AddDigit(Digit.From(("Duisend", "", 1000)));
            AddDigit(Digit.From(("Miljoen", "", 1000000)));
            AddDigit(Digit.From(("Miljard", "", 1000000000)));
            AddDigit(Digit.From(("Trillion", "", 1000000000000)));
            AddDigit(Digit.From(("Quadrillion", "", 1000000000000000)));
            AddDigit(Digit.From(("Quintillion", "", 1000000000000000000)));
        }
        public static AfrikaansNumberToWordsConverter New()
        {
            return new AfrikaansNumberToWordsConverter();
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
                var numberDigitCount = Math.Floor(Math.Log10(number) + 1);
                listWord.Add(
                    (1 == (number / x.Number) && numberDigitCount <= 2) ?
                    (number > 10 && (number % 10) > 0) ? $"{Convert(number % x.Number)} en {x.Singular}" : x.Singular : 
                    $"{Convert(number / x.Number)}{x.Singular}");
                listWord.Add(Convert(number % x.Number));
            });

            return string.Join(" ", listWord.ToArray());
        }
    }
}
