using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Abstractions
{
    public abstract class AbstractNumberToWordConverter: INumberToWordConverter
    {
        public List<Digit> Digits { get; protected set; } = new List<Digit>();

        public void AddDigit(Digit digit)
        {
            Digits.Add(digit);
        }

        public Digit FindInDigits(long number)
        {
            return Digits.Find(x => x.Number == number);
        }

        public virtual string Convert(long number)
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
        public virtual string ToWord(Rate rate,int commaDigit = 4)
        {
            var subUnit = Math.Round(rate.Money.Amount, commaDigit);
            subUnit = (subUnit - Decimal.Truncate(subUnit)) * ((decimal)Math.Pow(10, commaDigit));

            return $"{Convert((int)Decimal.Truncate(rate.Money.Amount))} {rate.Money.Currency} {Convert((int)subUnit)} {rate.Money.Currency.SubUnit}";
        }
    }
}
