using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common
{
    public class Money : EasyValueOf<(decimal Amount, Currency Currency), Money>
    {
        public decimal Amount => Value.Amount;
        public Currency Currency => Value.Currency;

        public override string ToString()
        {
            return $"{Value.Amount}{Value.Currency.Symbol}";
        }

        protected static bool Equal(Money a, Money b)
        {
            if (a is null || b is null)
                return false;

            return a.Value.Currency.Symbol == b.Value.Currency.Symbol;
        }
        public static Money operator *(Money a, Decimal b)
        {
            return Money.From(((a.Value.Amount * b), a.Value.Currency));
        }
        public static Money operator + (Money a, Decimal b)
        {
            return Money.From(((a.Value.Amount + b), a.Value.Currency));
        }
        public static Money operator -(Money a, Decimal b)
        {
            return Money.From(((a.Value.Amount - b), a.Value.Currency));
        }
        public static Money operator /(Money a, Decimal b)
        {
            return Money.From(((a.Value.Amount / b), a.Value.Currency));
        }
        public static Money operator + (Money a, Money b)
        {
            if (!Equal(a,b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return Money.From(((a.Value.Amount + b.Value.Amount), a.Value.Currency));
        }
        public static Money operator - (Money a, Money b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return Money.From(((a.Value.Amount - b.Value.Amount), a.Value.Currency));
        }
    }
}
