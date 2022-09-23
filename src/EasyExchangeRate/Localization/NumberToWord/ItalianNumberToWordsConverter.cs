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
    public class ItalianNumberToWordsConverter : AbstractNumberToWordConverter
    {
        public ItalianNumberToWordsConverter()
        {
            AddDigit(Digit.From(("", "", 0)));
            AddDigit(Digit.From(("uno", "", 1)));
            AddDigit(Digit.From(("due", "", 2)));
            AddDigit(Digit.From(("tre", "", 3)));
            AddDigit(Digit.From(("quattro", "", 4)));
            AddDigit(Digit.From(("cinque", "", 5)));
            AddDigit(Digit.From(("sei", "", 6)));
            AddDigit(Digit.From(("sette", "", 7)));
            AddDigit(Digit.From(("otto", "", 8)));
            AddDigit(Digit.From(("nove", "", 9)));
            AddDigit(Digit.From(("dieci", "", 10)));

            AddDigit(Digit.From(("undici", "", 11)));
            AddDigit(Digit.From(("dodici", "", 12)));
            AddDigit(Digit.From(("tredici", "", 13)));
            AddDigit(Digit.From(("quattordici", "", 14)));
            AddDigit(Digit.From(("quindici", "", 15)));
            AddDigit(Digit.From(("quindici", "", 16)));
            AddDigit(Digit.From(("diciassette", "", 17)));
            AddDigit(Digit.From(("diciotto", "", 18)));
            AddDigit(Digit.From(("diciannove", "", 19)));

            AddDigit(Digit.From(("venti", "", 20)));
            AddDigit(Digit.From(("trenta", "", 30)));
            AddDigit(Digit.From(("quaranta", "", 40)));
            AddDigit(Digit.From(("cinquanta", "", 50)));
            AddDigit(Digit.From(("sessanta", "", 60)));
            AddDigit(Digit.From(("settanta", "", 70)));
            AddDigit(Digit.From(("ottanta", "", 80)));
            AddDigit(Digit.From(("novanta", "", 90)));

            AddDigit(Digit.From(("cento", "", 100)));
            AddDigit(Digit.From(("duecento", "", 200)));
            AddDigit(Digit.From(("trecento", "", 300)));
            AddDigit(Digit.From(("quattrocento", "", 400)));
            AddDigit(Digit.From(("cinquecento", "", 500)));
            AddDigit(Digit.From(("seicento", "", 600)));
            AddDigit(Digit.From(("settecento", "", 700)));
            AddDigit(Digit.From(("ottocento", "", 800)));
            AddDigit(Digit.From(("novecento", "", 900)));

            AddDigit(Digit.From(("mila", "", 1000)));   
            AddDigit(Digit.From(("milioni", "", 1000000)));
            AddDigit(Digit.From(("miliardi", "", 1000000000)));
            AddDigit(Digit.From(("Trillion", "", 1000000000000)));
            AddDigit(Digit.From(("Quadrillion", "", 1000000000000000)));
            AddDigit(Digit.From(("Quintillion", "", 1000000000000000000)));
        }
        public static ItalianNumberToWordsConverter New()
        {
            return new ItalianNumberToWordsConverter();
        }
    }
}
