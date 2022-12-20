
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using EasyExchangeRate.Localization.NumberToWord;
using EasyExchangeRate.Localization;
using EasyExchangeRate.Common.ValueObject;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using Optionable;
using System.Net.NetworkInformation;

namespace EasyExchangeRate.Samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetCurrenciesSample();
            //GetRateSample();
            //GetRatesSample();
            //MathOperationsSample();
            //ConvertSample();
            //HumanizerSample();
            //NumberToWordSample();
            //WordToNumberSample();
            //JsonRateSample();
            //JsonRatesSample();
            //GetRateByDateSample();
            //GetRateByDateRangeSample();
            //SettingSample();
            //ConfigureSample();
            //ToStringOption();

            while (true)
            {
                Console.WriteLine("Please write a number");
                StringOrNumber input = Console.ReadLine();

                if (input.GetString().Text == "exit")
                {
                    break;
                }

                StringOrNumber result = EnglishNumberToWordsConverter.New().Convert(input);
                Console.WriteLine($"result : {result.GetString().Text}");
                Console.WriteLine("---------------------------------");
            }
        }

        static void GetCurrenciesSample()
        {
            ExchangeRate.RussiaAdapter.Currencies.ForEach(currency =>
            {
                Console.WriteLine(currency.ToString());
            });
        }
        static void GetRateSample()
        {
            Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");
            Console.WriteLine("Rate :");
            ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.EUR).Do(rate =>
            {
                Console.WriteLine($"{rate.TargetCurrency.Name} = " + rate.Money.Amount);
            });
        }
        static void GetRatesSample()
        {
            Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");
            Console.WriteLine("Rates :");

            ExchangeRate.TurkeyAdapter.GetRates().ForEach(rate =>
            {
                Console.WriteLine($"1 {rate.TargetCurrency.Name} = {rate.Money.Amount} {rate.Money.Currency.IsoCode}");
            });
        }
        static void MathOperationsSample()
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
        static void ConvertSample()
        {
            ExchangeRate.TurkeyAdapter.HowMuch<EurCurrency, UsdCurrency>(1).Do(convert =>
            {
                var amount = convert.Money.Amount;
                Console.WriteLine($"1 {convert.TargetCurrency.ToString()} = {Math.Round(amount, 4)}{convert.Money.Currency.Symbol} ");
            });

            ExchangeRate.TurkeyAdapter.HowMuch<UsdCurrency, EurCurrency>(1).Do(convert =>
            {
                var amount = convert.Money.Amount;
                Console.WriteLine($"1 {convert.TargetCurrency.ToString()} = {Math.Round(amount, 4)}{convert.Money.Currency.ToString()} ");
            });
        }
        static void HumanizerSample()
        {
            //EasyRate rate = ExchangeRate.TurkeyAdapterHumanizer.EUR.NeKadar;
            //Console.WriteLine($"1 {rate.TargetCurrency.Name} = {rate.Money.Amount} {rate.Money.Currency.IsoCode}");

            //List<EasyRate> rates = ExchangeRate.TurkeyAdapterHumanizer.EUR.USD.DövizKuru;
            //rates.ForEach(rate => Console.WriteLine($"1 {rate.TargetCurrency.Name} = {rate.Money.Amount} {rate.Money.Currency.IsoCode}"));

            List<Rate> convert = ExchangeRate.TurkeyAdapterHumanizer.USD.EUR.GBP.Çevir;
            convert.ForEach(rate => Console.WriteLine($"1 {rate.TargetCurrency.Name} = {rate.Money.Amount} {rate.Money.Currency.IsoCode}"));
        }
        static void NumberToWordSample()
        {
            ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.EUR).Do(rate =>
            {
                Console.WriteLine(EnglishNumberToWordsConverter.New().ToWord(rate));
            });

            Console.WriteLine(EnglishNumberToWordsConverter.New().Convert(1234567892));
            Console.WriteLine(TurkishNumberToWordConverter.New().Convert(1234567892));
            Console.WriteLine(AzerbaijaniNumberToWordsConverter.New().Convert(1234567892));
            Console.WriteLine(ItalianNumberToWordsConverter.New().Convert(1234567892));
            Console.WriteLine(UkrainianNumberToWordsConverter.New().Convert(1234567892));
            Console.WriteLine(UzbekLatnNumberToWordConverter.New().Convert(1234567892));
            Console.WriteLine(ArmenianNumberToWordsConverter.New().Convert(1234567892));
        }
        static void WordToNumberSample()
        {
            Console.WriteLine(EnglishNumberToWordsConverter.New().Convert("OneBillionTwoHundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety Two"));
            Console.WriteLine(TurkishNumberToWordConverter.New().Convert("Bir Milyar İki Yüz Otuz Dört MilyonBeşYüz Altmış Yedi Bin Sekiz Yüz Doksan İki"));
            Console.WriteLine(TurkishNumberToWordConverter.New().Convert("yüzyirmisekiz"));
            Console.WriteLine(AzerbaijaniNumberToWordsConverter.New().Convert("Bir Milyard İki Yüz Otuz Dörd MilyonBeş Yüz Altmış Yeddi Bin Səkkiz Yüz Doxsan İki"));
            Console.WriteLine(ItalianNumberToWordsConverter.New().Convert("uno miliardi duecento trenta quattro milioni cinquecento sessanta sette mila ottocento novanta due"));
            Console.WriteLine(UkrainianNumberToWordsConverter.New().Convert("один мільярда двісті тридцять чотири мільйона п'ятсот шістдесят сім тисячі вісімсот дев'яносто два"));
            Console.WriteLine(UzbekLatnNumberToWordConverter.New().Convert("bir milliard İkki Yuz O`ttiz To`rt MillionBesh Yuz Oltmish Yetti Ming Sakkiz Yuz To`qson İkki"));
            Console.WriteLine(ArmenianNumberToWordsConverter.New().Convert("Մեկ Միլիարդ Երկու Հարյուր Երեսուն Չորս Միլիոն Հինգ Հարյուր Վաթսուն Յոթ Հազար Ութ Հարյուր Իննսուն Երկու"));
        }
        static void JsonRateSample()
        {
            Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");

            ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.USD).Do(rate =>
            {
                Console.WriteLine($"Rate : {EnglishNumberToWordsConverter.New().ToWord(rate)}");
                Console.WriteLine(rate.ToJson());
            });
        }
        static void JsonRatesSample()
        {
            Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");
            Console.WriteLine("Rates :");

            Console.WriteLine(ExchangeRate.TurkeyAdapter.GetJsonRates());
        }
        static void GetRateByDateSample()
        {
            Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");
            Console.WriteLine("Rate :");
            ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.EUR, DateTime.Now).Do(rate =>
            {
                Console.WriteLine($"{rate.TargetCurrency.Name} = " + rate.Money.Amount);
            });
        }
        static void GetRateByDateRangeSample()
        {
            Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");
            Console.WriteLine("Rates :");

            Console.WriteLine(ExchangeRate.TurkeyAdapter.GetJsonRates(DateRange.From((DateTime.Now.AddDays(-1), DateTime.Now))));
        }
        static void SettingSample()
        {
            ExchangeRate.TurkeyAdapter
                .AddOption<DataSetting>(option => option.RateDigit = 2)
                .AddOption<JsonSetting>(option => option.DateFormat = "yyyy-MM-dd");

            Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");
            Console.WriteLine("Rate :");
            ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.EUR).Do(rate =>
            {
                Console.WriteLine($"{rate.TargetCurrency.Name} = " + rate.Money.Amount);
            });
        }
        static void ConfigureSample()
        {
            var config = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json", true, true)
                 .Build();

            ExchangeRate.EuropeAdapter
                .UseSection(config.GetSection("EasyExchangeRate"))
                    .Configure<DataSetting>()
                    .Configure<JsonSetting>();

            //Alternative usage
            //ExchangeRate.TurkeyAdapter.Configure<DataSetting>(config.GetSection(nameof(DataSetting)));
            //ExchangeRate.TurkeyAdapter.Configure<JsonSetting>(config.GetSection(nameof(JsonSetting)));

            Console.WriteLine($"Base Currency : {ExchangeRate.EuropeAdapter.BaseCurrency.Name}");
            Console.WriteLine("Rate :");
            ExchangeRate.EuropeAdapter.GetRate(CurrencyCodes.TRY).Do(rate =>
            {
                Console.WriteLine($"{rate.TargetCurrency.Name} = " + rate.Money.Amount);
            });
        }
        static void ToStringOption()
        {
            Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");
            ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.EUR).Do(rate =>
            {
                Console.WriteLine($"1 {rate.TargetCurrency.Name} = " + rate.ToString(opt =>
                {
                    opt.Display = DisplayType.Name;
                    opt.SymbolRotation = RotationType.Suffix;
                }));
            });

        }
    }
}
