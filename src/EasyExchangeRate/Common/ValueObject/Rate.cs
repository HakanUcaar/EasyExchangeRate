using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common
{
    public class Rate : EasyValueOf<(Money Money, Currency TargetCurrency), Rate>
    {
        public Currency TargetCurrency => Value.TargetCurrency;
        public Money Money => Value.Money;

        public override string ToString()
        {
            return $"{Value.Money.Value.Amount}{Value.Money.Value.Currency.Symbol}";
        }
        protected static bool Equal(Rate a, Rate b)
        {
            if (a is null || b is null)
                return false;

            return a.Value.Money.Currency.Symbol == b.Value.Money.Currency.Symbol;
        }
        public static Money operator *(Rate a, Decimal b)
        {
            return Money.From(((a.Value.Money.Value.Amount * b), a.Value.Money.Value.Currency));
        }
        public static Money operator +(Rate a, Decimal b)
        {
            return Money.From(((a.Value.Money.Value.Amount + b), a.Value.Money.Value.Currency));
        }
        public static Money operator -(Rate a, Decimal b)
        {
            return Money.From(((a.Value.Money.Value.Amount - b), a.Value.Money.Value.Currency));
        }
        public static Money operator /(Rate a, Decimal b)
        {
            return Money.From(((a.Value.Money.Value.Amount / b), a.Value.Money.Value.Currency));
        }
        public static Money operator +(Rate a, Rate b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return Money.From(((a.Value.Money.Value.Amount + b.Value.Money.Value.Amount), a.Value.Money.Value.Currency));
        }
        public static Money operator -(Rate a, Rate b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return Money.From(((a.Value.Money.Value.Amount - b.Value.Money.Value.Amount), a.Value.Money.Value.Currency));
        }
        public static Money operator /(Rate a, Rate b)
        {
            //if (!Equal(a, b))
            //{
            //    throw new NotEqualMoneyCurrencyException();
            //}

            return Money.From((((a.Value.Money.Value.Amount / b.Value.Money.Value.Amount)), b.Value.TargetCurrency));
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this,Formatting.Indented);
        }
    }
}
