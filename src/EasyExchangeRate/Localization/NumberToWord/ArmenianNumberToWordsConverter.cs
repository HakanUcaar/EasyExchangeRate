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
    public class ArmenianNumberToWordsConverter : AbstractNumberToWordConverter
    {
        public ArmenianNumberToWordsConverter()
        {
            AddDigit(Digit.From(("Զրո", "", 0)));
            AddDigit(Digit.From(("Մեկ", "", 1)));
            AddDigit(Digit.From(("Երկու", "", 2)));
            AddDigit(Digit.From(("Երեք", "", 3)));
            AddDigit(Digit.From(("Չորս", "", 4)));
            AddDigit(Digit.From(("Հինգ", "", 5)));
            AddDigit(Digit.From(("Վեց", "", 6)));
            AddDigit(Digit.From(("Յոթ", "", 7)));
            AddDigit(Digit.From(("Ութ", "", 8)));
            AddDigit(Digit.From(("Ինը", "", 9)));
            AddDigit(Digit.From(("Տաս", "", 10)));

            AddDigit(Digit.From(("Տասնմեկ", "", 11)));
            AddDigit(Digit.From(("Տասներկու", "", 12)));
            AddDigit(Digit.From(("Տասներեք", "", 13)));
            AddDigit(Digit.From(("Տասնչորս", "", 14)));
            AddDigit(Digit.From(("Տասնհինգ", "", 15)));
            AddDigit(Digit.From(("Տասնվեց", "", 16)));
            AddDigit(Digit.From(("Տասնյոթ", "", 17)));
            AddDigit(Digit.From(("Տասնութ", "", 18)));
            AddDigit(Digit.From(("Տասնինը", "", 19)));

            AddDigit(Digit.From(("Քսան", "", 20)));
            AddDigit(Digit.From(("Երեսուն", "", 30)));
            AddDigit(Digit.From(("Քառասուն", "", 40)));
            AddDigit(Digit.From(("Հիսուն", "", 50)));
            AddDigit(Digit.From(("Վաթսուն", "", 60)));
            AddDigit(Digit.From(("Յոթանասուն", "", 70)));
            AddDigit(Digit.From(("Ութսուն", "", 80)));
            AddDigit(Digit.From(("Իննսուն", "", 90)));
            AddDigit(Digit.From(("Հարյուր", "", 100)));
            AddDigit(Digit.From(("Հազար", "", 1000)));
            AddDigit(Digit.From(("Միլիոն", "", 1000000)));
            AddDigit(Digit.From(("Միլիարդ", "", 1000000000)));
            AddDigit(Digit.From(("Տրիլիոն", "", 1000000000000)));
            AddDigit(Digit.From(("Կվադրիլիոն", "", 1000000000000000)));
            AddDigit(Digit.From(("Քվինտիլիոն", "", 1000000000000000000)));
        }
        public static ArmenianNumberToWordsConverter New()
        {
            return new ArmenianNumberToWordsConverter();
        }
    }
}
