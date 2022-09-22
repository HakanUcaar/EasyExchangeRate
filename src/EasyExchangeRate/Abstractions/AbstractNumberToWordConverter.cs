using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.Dynamic;
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
        public virtual long Convert(string word)
        {
            if (word is null)
            {
                return 0;
            }

            var numbers = new List<long>();
            var words = word.Split();

            Array.ForEach(words,(x)=>{
                Digits.Last(y => x == y.Singular).Do(z =>
                {
                    numbers.Add(z.Number);
                });
            });

            var grouped = new List<List<long>>();
            var temp = new List<long>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var digitCount = Math.Floor(Math.Log10(numbers[i]) + 1);
                if (digitCount <= 3 || numbers[i] / (Math.Pow(10,digitCount-1)) != 1)
                {
                    temp.Add(numbers[i]);
                    if(i+1 == numbers.Count)
                    {
                        grouped.Add(temp);
                    }
                }
                else
                {
                    temp.Add(numbers[i]);
                    grouped.Add(temp);
                    temp = new List<long>();
                }
            }

            long total = 0;
            grouped.ForEach(x =>
            {
                long res = x[0];
                for (int i = 1; i < x.Count; i++)
                {
                    var digitCount = Math.Floor(Math.Log10(x[i]) + 1);

                    res = (digitCount > 2 && x[i] / (Math.Pow(10, digitCount - 1)) == 1) ? res * x[i] : res + x[i];
                }
                total += res;
            });
            
            return total;
        }
    }
}
