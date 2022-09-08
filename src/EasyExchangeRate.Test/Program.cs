
using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using System;
using System.Linq;

namespace EasyExchangeRate.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //GetCurrencies();
            //GetRate();
            //GetRates();
            MathOperations();
            //Convert();

            Console.ReadLine();
        }

        static void GetCurrencies()
        {
            ExchangeRate.EuropeAdapter.Currencies.ForEach(currency =>
            {
                Console.WriteLine(currency.ToString());
            });
        }

        static void GetRate()
        {
            Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");
            Console.WriteLine("Rate :");
            ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.EUR).Do(rate =>
            {
                Console.WriteLine($"1 {rate.TargetCurrency.Name} = {rate.Money.Amount} {rate.Money.Currency.IsoCode}" );
            });
        }

        static void GetRates()
        {
            Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Value.Name}");
            Console.WriteLine("Rates :");

            ExchangeRate.TurkeyAdapter.GetRates().ForEach(rate =>
            {
                Console.WriteLine($"1 {rate.TargetCurrency.Name} = { rate.Money.Amount} {rate.Money.Currency.IsoCode}");
            });
        }

        static void MathOperations()
        {
            var rateUsd = ExchangeRate.EuropeAdapter.GetRate(CurrencyCodes.USD);
            Console.WriteLine($"1 {rateUsd.Money.Currency.Name } = {rateUsd.Money.Amount} {rateUsd.TargetCurrency.Name}");
            Console.WriteLine($"Plus +3 = " + (rateUsd + 3));
            Console.WriteLine($"Minus -1.5 = " + (rateUsd - 1.3M));
            Console.WriteLine($"Divide 2 = " + (rateUsd / 2));
            Console.WriteLine($"Multiply 5 = " + (rateUsd * 5));
        }

        static void Convert()
        {
            ExchangeRate.TurkeyAdapter.HowMuch<EurCurrency, UsdCurrency>(1).Do(convert =>
            {
                var amount = convert.Money.Amount;
                Console.WriteLine($"1 {convert.TargetCurrency} = {Math.Round(amount, 4)}{convert.Money.Currency.Symbol} ");
            });

            ExchangeRate.TurkeyAdapter.HowMuch<UsdCurrency,EurCurrency>(1).Do(convert =>
            {
                var amount = convert.Money.Amount;
                Console.WriteLine($"1 {convert.TargetCurrency} = {Math.Round(amount, 4)}{convert.Money.Currency} ");
            });
        }
    }
}
