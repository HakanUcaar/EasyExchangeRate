using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common
{
    public class EasyMoney : EasyValueOf<(decimal Amount, EasyCurrency Currency), EasyMoney>
    {
        public decimal Amount => Value.Amount;
        public EasyCurrency Currency => Value.Currency;

        public override string ToString()
        {
            return $"{Value.Amount}{Value.Currency.Value.Symbol}";
        }

        protected static bool Equal(EasyMoney a, EasyMoney b)
        {
            if (a is null || b is null)
                return false;

            return a.Value.Currency.Value.Symbol == b.Value.Currency.Value.Symbol;
        }
        public static EasyMoney operator *(EasyMoney a, Decimal b)
        {
            return EasyMoney.From(((a.Value.Amount * b), a.Value.Currency));
        }
        public static EasyMoney operator + (EasyMoney a, Decimal b)
        {
            return EasyMoney.From(((a.Value.Amount + b), a.Value.Currency));
        }
        public static EasyMoney operator -(EasyMoney a, Decimal b)
        {
            return EasyMoney.From(((a.Value.Amount - b), a.Value.Currency));
        }
        public static EasyMoney operator /(EasyMoney a, Decimal b)
        {
            return EasyMoney.From(((a.Value.Amount / b), a.Value.Currency));
        }
        public static EasyMoney operator + (EasyMoney a, EasyMoney b)
        {
            if (!Equal(a,b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return EasyMoney.From(((a.Value.Amount + b.Value.Amount), a.Value.Currency));
        }
        public static EasyMoney operator - (EasyMoney a, EasyMoney b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return EasyMoney.From(((a.Value.Amount - b.Value.Amount), a.Value.Currency));
        }
    }
}
