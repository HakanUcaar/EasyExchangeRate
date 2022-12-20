using EasyExchangeRate.Common;
using EasyExchangeRate.Common.ValueObject;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Abstractions
{
    public abstract class AbstractNumberToWordConverter : INumberToWordConverter
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
        public virtual string ToWord(Rate rate, int commaDigit = 4)
        {
            var subUnit = Math.Round(rate.Money.Amount, commaDigit);
            subUnit = (subUnit - Decimal.Truncate(subUnit)) * ((decimal)Math.Pow(10, commaDigit));

            return $"{Convert((int)Decimal.Truncate(rate.Money.Amount))} {rate.Money.Currency} {Convert((int)subUnit)} {rate.Money.Currency.SubUnit}";
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
                listWord.Add((1 == (number / x.Number) && Math.Floor(Math.Log10(number) + 1) <= 3) ? x.Singular : $"{Convert(number / x.Number)}{x.Singular}");
                listWord.Add(Convert(number % x.Number));
            });

            return string.Join(" ", listWord.ToArray());
        }
        public virtual long Convert(string text)
        {
            if (text is null)
            {
                return 0;
            }

            var numbers = new List<long>();
            long tempNumber = 0;
            int index = 0;
            text.Aggregate(new StringBuilder(),
                           (current, next) =>
                           {
                               index = index + 1;
                               current.Append(next);

                               var textInDigits = Digits.Where(x => current.Length > 2 && x.Singular.ToLower().IndexOf(current.ToString().Trim().ToLower()) != -1);
                               var digitsInText = Digits.Where(x => current.Length > 2 && current.ToString().Trim().ToLower().IndexOf(x.Singular.ToLower()) != -1);

                               if (index >= text.Length)
                               {
                                   if (tempNumber > 0)
                                   {
                                       numbers.Add(tempNumber);
                                   }else
                                   if (digitsInText.Any())
                                   {
                                       numbers.Add(digitsInText.Last().Number);
                                   }
                                   else
                                   {
                                       Digits.LastOrDefault(y => current.ToString().Trim().ToLower() == y.Singular.ToLower()).Do(z =>
                                       {
                                           numbers.Add(z.Number);
                                           tempNumber = 0;
                                           current.Clear();
                                       });
                                   }
                               }
                               else
                               if (textInDigits.Count() > 1)
                               {
                                   tempNumber = textInDigits.First().Number;
                               }
                               else
                               if (tempNumber > 0 && digitsInText.Any() && textInDigits.Any())
                               {
                                   numbers.Add(tempNumber);
                                   tempNumber = 0;
                                   current.Clear();
                                   current.Append(next);
                               }
                               else
                               if (digitsInText.Count() > 1)
                               {
                                   tempNumber = digitsInText.First().Number;
                               }                               
                               else
                               if (tempNumber > 0 && textInDigits.Any() && digitsInText.Any())
                               {
                                   numbers.Add(tempNumber);
                                   tempNumber = 0;
                                   current.Clear();
                                   current.Append(next);
                               }
                               else
                               {
                                   Digits.LastOrDefault(y => current.ToString().Trim().ToLower() == y.Singular.ToLower()).Do(z =>
                                   {
                                       numbers.Add(z.Number);
                                       tempNumber = 0;
                                       current.Clear();
                                   });
                               }
                               return current;
                           });

            var grouped = new List<List<long>>();
            var temp = new List<long>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var digitCount = Math.Floor(Math.Log10(numbers[i]) + 1);
                if (digitCount <= 3 || numbers[i] / (Math.Pow(10, digitCount - 1)) != 1)
                {
                    temp.Add(numbers[i]);
                    if (i + 1 == numbers.Count)
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
        public virtual StringOrNumber Convert(StringOrNumber input)
        {
            if (input.TryGetNumber().IsNumber)
            {
                return Convert(input.TryGetNumber().Number);
            }
            else
            {
                return Convert(input.GetString().Text);
            }
        }
    }
}
