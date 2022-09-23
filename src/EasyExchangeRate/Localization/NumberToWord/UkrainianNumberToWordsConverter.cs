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
    //To-Do Add plural info
    public class UkrainianNumberToWordsConverter : AbstractNumberToWordConverter
    {
        public UkrainianNumberToWordsConverter()
        {
            AddDigit(Digit.From(("нуль", "", 0)));
            AddDigit(Digit.From(("один", "", 1)));
            AddDigit(Digit.From(("два", "", 2)));
            AddDigit(Digit.From(("три", "", 3)));
            AddDigit(Digit.From(("чотири", "", 4)));
            AddDigit(Digit.From(("п'ять", "", 5)));
            AddDigit(Digit.From(("шість", "", 6)));
            AddDigit(Digit.From(("сім", "", 7)));
            AddDigit(Digit.From(("вісім", "", 8)));
            AddDigit(Digit.From(("дев'ять", "", 9)));
            AddDigit(Digit.From(("десять", "", 10)));

            AddDigit(Digit.From(("одинадцять", "", 11)));
            AddDigit(Digit.From(("дванадцять", "", 12)));
            AddDigit(Digit.From(("тринадцять", "", 13)));
            AddDigit(Digit.From(("чотирнадцять", "", 14)));
            AddDigit(Digit.From(("п'ятнадцять", "", 15)));
            AddDigit(Digit.From(("шістнадцять", "", 16)));
            AddDigit(Digit.From(("сімнадцять", "", 17)));
            AddDigit(Digit.From(("вісімнадцять", "", 18)));
            AddDigit(Digit.From(("дев'ятнадцять", "", 19)));


            AddDigit(Digit.From(("двадцять", "", 20)));
            AddDigit(Digit.From(("тридцять", "", 30)));
            AddDigit(Digit.From(("сорок", "", 40)));
            AddDigit(Digit.From(("п'ятдесят", "", 50)));
            AddDigit(Digit.From(("шістдесят", "", 60)));
            AddDigit(Digit.From(("сімдесят", "", 70)));
            AddDigit(Digit.From(("вісімдесят", "", 80)));
            AddDigit(Digit.From(("дев'яносто", "", 90)));
            AddDigit(Digit.From(("сто", "", 100)));

            AddDigit(Digit.From(("двісті", "", 200)));
            AddDigit(Digit.From(("триста", "", 300)));
            AddDigit(Digit.From(("чотириста", "", 400)));
            AddDigit(Digit.From(("п'ятсот", "", 500)));
            AddDigit(Digit.From(("шістсот", "", 600)));
            AddDigit(Digit.From(("сімсот", "", 700)));
            AddDigit(Digit.From(("вісімсот", "", 800)));
            AddDigit(Digit.From(("дев'ятсо", "", 900)));

            AddDigit(Digit.From(("тисячі", "", 1000)));
            AddDigit(Digit.From(("мільйона", "", 1000000)));
            AddDigit(Digit.From(("мільярда", "", 1000000000)));
            AddDigit(Digit.From(("трильйона", "", 1000000000000)));
            AddDigit(Digit.From(("квадрильйона", "", 1000000000000000)));
            AddDigit(Digit.From(("квінтильйона", "", 1000000000000000000)));
        }
        public static UkrainianNumberToWordsConverter New()
        {
            return new UkrainianNumberToWordsConverter();
        }
    }
}
