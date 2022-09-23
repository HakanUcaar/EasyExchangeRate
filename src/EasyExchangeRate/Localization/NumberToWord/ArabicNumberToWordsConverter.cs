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
    public class ArabicNumberToWordsConverter : AbstractNumberToWordConverter
    {
        public ArabicNumberToWordsConverter()
        {
            AddDigit(Digit.From(("صفر", "", 0)));
            AddDigit(Digit.From(("وَاحِد", "", 1)));
            AddDigit(Digit.From(("اِثْنَان", "", 2)));
            AddDigit(Digit.From(("ثَلَاثَة", "", 3)));
            AddDigit(Digit.From(("أَرْبَعَة", "", 4)));
            AddDigit(Digit.From(("خَمْسَة", "", 5)));
            AddDigit(Digit.From(("سِتَّة", "", 6)));
            AddDigit(Digit.From(("سَبْعَة", "", 7)));
            AddDigit(Digit.From(("ثَمَانِيَة", "", 8)));
            AddDigit(Digit.From(("تِسْعَة", "", 9)));
            AddDigit(Digit.From(("عَشَرَة", "", 10)));
            AddDigit(Digit.From(("أَحَدَ عَشَرَ", "", 11)));
            AddDigit(Digit.From(("اِثْنَا عَشَرَ", "", 12)));
            AddDigit(Digit.From(("ثَلَاثَةَ عَشَرَ", "", 13)));
            AddDigit(Digit.From(("أَرْبَعَةَ عَشَرَ", "", 14)));
            AddDigit(Digit.From(("خَمْسَةَ عَشَرَ", "", 15)));
            AddDigit(Digit.From(("سِتَّةَ عَشَرَ", "", 16)));
            AddDigit(Digit.From(("سَبْعَةَ عَشَرَ", "", 17)));
            AddDigit(Digit.From(("ثَمَانِيَةَ عَشَرَ", "", 18)));
            AddDigit(Digit.From(("تِسْعَةَ عَشَرَ", "", 19)));

            AddDigit(Digit.From(("عِشْرُونَ", "", 20)));
            AddDigit(Digit.From(("ثَلَاثُونَ", "", 30)));
            AddDigit(Digit.From(("أَرْبَعُونَ", "", 40)));
            AddDigit(Digit.From(("خَمْسُونَ", "", 50)));
            AddDigit(Digit.From(("سِتُّونَ", "", 60)));
            AddDigit(Digit.From(("سَبْعُونَ", "", 70)));
            AddDigit(Digit.From(("ثَمَانُونَ", "", 80)));
            AddDigit(Digit.From(("تِسْعُونَ", "", 90)));
            AddDigit(Digit.From(("مِئَة", "", 100)));
            AddDigit(Digit.From(("ألف", "", 1000)));
            AddDigit(Digit.From(("مليون", "", 1000000)));
            AddDigit(Digit.From(("مليار", "", 1000000000)));
            AddDigit(Digit.From(("تريليون", "", 1000000000000)));
            AddDigit(Digit.From(("كوادريليون", "", 1000000000000000)));
            AddDigit(Digit.From(("كوينتليون", "", 1000000000000000000)));
        }
        public static ArabicNumberToWordsConverter New()
        {
            return new ArabicNumberToWordsConverter();
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
                listWord.Add((1 == (number / x.Number) && Math.Floor(Math.Log10(number) + 1) <= 2) ? x.Singular : $" {x.Singular} و {Convert(number / x.Number)}");
                listWord.Add(Convert(number % x.Number));
            });

            return string.Join(" ", listWord.ToArray());
        }
    }
}
