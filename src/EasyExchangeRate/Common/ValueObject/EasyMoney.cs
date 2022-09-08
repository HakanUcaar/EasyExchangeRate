using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common
{
    public class EasyMoney : EasyValueOf<(decimal amount, EasyCurrency currency), EasyMoney>
    {
        public decimal Amount => Value.amount;
        public EasyCurrency Currency => Value.currency;

        public override string ToString()
        {
            return $"{Amount} {Currency.IsoCode}";
        }

        protected static bool Equal(EasyMoney a, EasyMoney b)
        {
            if (a is null || b is null)
                return false;

            return a.Currency.Symbol == b.Currency.Symbol;
        }
        public static EasyMoney operator *(EasyMoney a, Decimal b)
        {
            return EasyMoney.From(((a.Amount * b), a.Currency));
        }
        public static EasyMoney operator + (EasyMoney a, Decimal b)
        {
            return EasyMoney.From(((a.Amount + b), a.Currency));
        }
        public static EasyMoney operator -(EasyMoney a, Decimal b)
        {
            return EasyMoney.From(((a.Amount - b), a.Currency));
        }
        public static EasyMoney operator /(EasyMoney a, Decimal b)
        {
            return EasyMoney.From(((a.Amount / b), a.Currency));
        }
        public static EasyMoney operator + (EasyMoney a, EasyMoney b)
        {
            if (!Equal(a,b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return EasyMoney.From(((a.Amount + b.Amount), a.Currency));
        }
        public static EasyMoney operator - (EasyMoney a, EasyMoney b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return EasyMoney.From(((a.Amount - b.Amount), a.Currency));
        }
    }
}
