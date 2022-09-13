
using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
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
            //MathOperations();
            //Convert();
            Humanizer();

            Console.ReadLine();
        }

        static void GetCurrencies()
        {
            ExchangeRate.RussiaAdapter.Currencies.ForEach(currency =>
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
                Console.WriteLine($"{rate.TargetCurrency.Name} = " + rate.Money.Amount);
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
            ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.EUR).Do(rateEur =>
            {
                Console.WriteLine($"{rateEur.TargetCurrency.Name} = " + rateEur.Money.Amount);
                Console.WriteLine($"Sum +3 = " + (rateEur + 3));
                Console.WriteLine($"Minus -1.5 = " + (rateEur - 1.3M));
                Console.WriteLine($"Divide 2 = " + (rateEur / 2));
                Console.WriteLine($"Multi 5 = " + (rateEur * 5));

                ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.USD).Do(rateUsd =>
                {
                    Console.WriteLine($"Sum two rate = " + (rateEur + rateUsd));
                });
            });
        }

        static void Convert()
        {
            ExchangeRate.TurkeyAdapter.HowMuch<EurCurrency, UsdCurrency>(1).Do(convert =>
            {
                var amount = convert.Money.Amount;
                Console.WriteLine($"1 {convert.TargetCurrency.ToString()} = {Math.Round(amount, 4)}{convert.Money.Currency.Symbol} ");
            });

            ExchangeRate.TurkeyAdapter.HowMuch<UsdCurrency,EurCurrency>(1).Do(convert =>
            {
                var amount = convert.Money.Amount;
                Console.WriteLine($"1 {convert.TargetCurrency.ToString()} = {Math.Round(amount, 4)}{convert.Money.Currency.ToString()} ");
            });
        }

        static void Humanizer()
        {
            //currs.ForEach(x => Console.WriteLine(x));

            //EasyRate rate = ExchangeRate.TurkeyAdapterHumanizer.EUR.Kur;
            //Console.WriteLine(rate);

            //List<EasyRate> rates = ExchangeRate.TurkeyAdapterHumanizer.EUR.USD.Kur;
            //rates.ForEach(x => Console.WriteLine(x));

            List<EasyRate> convert = ExchangeRate.TurkeyAdapterHumanizer.USD.EUR.USD.NeKadar;
            convert.ForEach(x => Console.WriteLine(x));
        }
    }
}
