
using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using EasyExchangeRate.Localization;
using EasyExchangeRate.Localization.NumberToWord;
using System.Diagnostics;

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
            //Humanizer();
            NumberToWord();
            //WordToNumber();

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
            Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");
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
            //EasyRate rate = ExchangeRate.TurkeyAdapterHumanizer.EUR.NeKadar;
            //Console.WriteLine($"1 {rate.TargetCurrency.Name} = {rate.Money.Amount} {rate.Money.Currency.IsoCode}");

            //List<EasyRate> rates = ExchangeRate.TurkeyAdapterHumanizer.EUR.USD.DövizKuru;
            //rates.ForEach(rate => Console.WriteLine($"1 {rate.TargetCurrency.Name} = {rate.Money.Amount} {rate.Money.Currency.IsoCode}"));

            List<Rate> convert = ExchangeRate.TurkeyAdapterHumanizer.USD.EUR.GBP.Çevir;
            convert.ForEach(rate => Console.WriteLine($"1 {rate.TargetCurrency.Name} = {rate.Money.Amount} {rate.Money.Currency.IsoCode}"));
        }

        static void NumberToWord()
        {
            ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.EUR).Do(rate =>
            {
                Console.WriteLine(EnglishNumberToWordsConverter.New().ToWord(rate));
            });

            Console.WriteLine(EnglishNumberToWordsConverter.New().Convert(123456789));
            Console.WriteLine(TurkishNumberToWordConverter.New().Convert(123456789));
            Console.WriteLine(AzerbaijaniNumberToWordsConverter.New().Convert(123456789));
            Console.WriteLine(ItalianNumberToWordsConverter.New().Convert(123456789));
            Console.WriteLine(UkrainianNumberToWordsConverter.New().Convert(123456789));
            Console.WriteLine(UzbekLatnNumberToWordConverter.New().Convert(123456789));
            Console.WriteLine(ArmenianNumberToWordsConverter.New().Convert(123456789));
        }

        static void WordToNumber()
        {
            Console.WriteLine(EnglishNumberToWordsConverter.New().Convert("One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety Two"));
            Console.WriteLine(TurkishNumberToWordConverter.New().Convert("Bir Milyar İki Yüz Otuz Dört Milyon Beş Yüz Altmış Yedi Bin Sekiz Yüz Doksan İki"));
        }
    }
}
