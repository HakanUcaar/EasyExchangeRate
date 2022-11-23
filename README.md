<p align="center">
  <img src="https://github.com/HakanUcaar/EasyExchangeRate/blob/main/imgs/icon_128.png?raw=true" alt="icon"/>
</p>


# EasyExchangeRate
Some central bank exchange rates

<details>
 <summary>Minimal APi</summary>
 
 Deploy on heroku :
  ```
	docker build -t exchange .
	docker tag exchange registry.heroku.com/<herokuAppName>/web

	heroku login
	heroku container:login

	heroku container:push web -a <herokuAppName>
	heroku container:release web -a <herokuAppName>
 ```
 
 Heroku url : https://easy-exchange-rate.herokuapp.com/swagger/index.html
 
 Test Api :
 ``` 
 getCurrencies :  https://easy-exchange-rate.herokuapp.com/currencies?adapter=TurkeyAdapter
 getRates :  https://easy-exchange-rate.herokuapp.com/getRates?adapter=DenmarkAdapter
 numberToWord : https://easy-exchange-rate.herokuapp.com/numberToWord?language=English&value=123456789
 ```
 
</details>

<details>
	<summary>Todo</summary>
 
  - [X] JSON serialize
  - [X] Nuget package
  - [X] Web deploy(open api)
  - [ ] DateRange
	- [ ] Australia
	- [ ] Canada
	- [ ] Denmark
	- [X] Europe
	- [ ] Israel
	- [ ] Poland
	- [ ] Russia
	- [X] Turkey
  - [ ] Add number to word localizations
	- [X] Turkish
	- [X] English
	- [ ] Affrikan
	- [ ] Arabic
	- [X] Armenian
	- [X] Azerbaijani
	- [ ] Bangla
	- [ ] Bulgarian
	- [ ] Chinese
	- [ ] Croatian
	- [ ] Czech
	- [ ] Farsi
	- [ ] Finnish
	- [ ] French
	- [ ] German
	- [ ] Greek
	- [ ] Indian
	- [X] Italian
	- [ ] Japanese
	- [ ] Korean
	- [ ] Latvian
	- [ ] Polish
	- [ ] Romanian
	- [ ] Russian
	- [ ] Spanish
	- [ ] Tamil
	- [ ] Thai
	- [X] Ukrainian
	- [X] Uzbek
	- [ ] Vietnamase
 
</details>

## Adapter List
- TurkeyAdapter
- EuropeAdapter 
- DenmarkAdapter
- IsraelAdapter 
- RussiaAdapter 
- AustraliaAdapter
- PolandAdapter 
- CanadaAdapter


## Usage

### *Get Currencies
``` csharp
  ExchangeRate.EuropeAdapter.Currencies.ForEach(currency =>
  {
      Console.WriteLine(currency.ToString());
  });
```
Output
```
US Dollar
Japanese Yen
Bulgarian lev
Czech koruna
Danish krone
British Pound
Hungarian Forint
Polish Zloty
Romanian Leu
Swedish Krona
Swiss franc
Icelandic Króna
Norwegian Krone
Croatian Kuna
Turkish Lira
Australian dollar
Brazilian real
Canadian dollar
Renminbi
Hong Kong Dollar
Indonesian Rupiah
Israeli New Shekel
Indian Rupee
South Korean Won
Mexican Peso
Malaysian Ringgit
New Zealand Dollar
Philippine Piso
Singapore Dollar
Thai Baht
CFP franc
```

### *Get Rate
``` csharp
  var rate = ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.EUR);
  Console.WriteLine($"1 {rate.TargetCurrency.Name} = {rate.Money.Amount} {rate.Money.Currency.IsoCode}" );
```
Output
```
  Base Currency : Turkish Lira
  Rate : 1 Euro = 18,0545 TRY
```

### *Get Rates
``` csharp
  ExchangeRate.TurkeyAdapter.GetRates().ForEach(rate =>
  {
      Console.WriteLine($"1 {rate.TargetCurrency.Name} = { rate.Money.Amount} {rate.Money.Currency.IsoCode}");
  });
```
Output
```
Base Currency : Turkish Lira
Rates :
1 US Dollar = 18,2050 TRY
1 Australian dollar = 12,3295 TRY
1 Danish krone = 2,4240 TRY
1 Euro = 18,0545 TRY
1 British Pound = 20,8916 TRY
1 Swiss franc = 18,4913 TRY
1 Swedish Krona = 1,6740 TRY
1 Canadian dollar = 13,8206 TRY
1 Kuwaiti Dinar = 58,6698 TRY
1 Norwegian Krone = 1,8133 TRY
1 Saudi Riyal = 4,8436 TRY
1 Japanese Yen = 12,9276 TRY
1 Bulgarian lev = 9,2100 TRY
1 Romanian Leu = 3,7237 TRY
1 Russian Ruble = 0,29787 TRY
1 Iranian Rial = 0,04310 TRY
1 Renminbi = 2,6103 TRY
1 Pakistani Rupee = 0,08247 TRY
1 Qatari Rial = 4,9327 TRY
1 South Korean Won = 0,01320 TRY
1 Azerbaijani manat = 10,6551 TRY
1 United Arab Emirates dirham = 4,9286 TRY
1 Special Drawing Rights = 23,6160 TRY
```
### *Convert
``` csharp
  var convert = ExchangeRate.TurkeyAdapter.HowMuch<EurCurrency, UsdCurrency>(1);
  Console.WriteLine($"1 {convert.TargetCurrency.ToString()} = {Math.Round(convert.Money.Amount, 4)}{convert.Money.Currency.Symbol} ");
```
Output
```
  1 Euro = 0,9917$
```
### *Operators
``` csharp
  var rateUsd = ExchangeRate.EuropeAdapter.GetRate(CurrencyCodes.USD);
  Console.WriteLine($"1 {rateUsd.Money.Currency.Name } = {rateUsd.Money.Amount} {rateUsd.TargetCurrency.Name}");
  Console.WriteLine($"Plus +3 = " + (rateUsd + 3));
  Console.WriteLine($"Minus -1.5 = " + (rateUsd - 1.3M));
  Console.WriteLine($"Divide 2 = " + (rateUsd / 2));
  Console.WriteLine($"Multiply 5 = " + (rateUsd * 5)); 
```
Output
```
1 Euro = 0,9920 US Dollar
Plus +3 = 3,9920 USD
Minus -1.5 = -0,3080 USD
Divide 2 = 0,4960 USD
Multiply 5 = 4,9600 USD
```
### *Sum Two Rate
``` csharp
 ... 
```

### *Rate To Word / Number To Word 
``` csharp
Code :
	ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.EUR).Do(rate =>
	{
		Console.WriteLine(EnglishNumberToWordsConverter.New().ToWord(rate));
	});
	
Output :
	Eighteen  Turkish Lira One Thousand Nine Hundred Fifty Four  kuruş	
```

``` csharp
Code :
	Console.WriteLine(EnglishNumberToWordsConverter.New().Convert(1000100));
	Console.WriteLine(TurkishNumberToWordConverter.New().Convert(1000100));    

Output :
	One Million One Hundred
	Bir Milyon Yüz
```

### *Word To Number 
``` csharp
Code :
	Console.WriteLine(EnglishNumberToWordsConverter.New().Convert("One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety Two"));
	Console.WriteLine(TurkishNumberToWordConverter.New().Convert("Bir Milyar İki Yüz Otuz Dört Milyon Beş Yüz Altmış Yedi Bin Sekiz Yüz Doksan İki"));
	
Output :
	1234567892
	1234567892
```

### *Humanizer
``` csharp
Code

Rate rate = ExchangeRate.TurkeyAdapterHumanizer.EUR.DövizKuru;
Console.WriteLine($"1 {rate.TargetCurrency.Name} = {rate.Money.Amount} {rate.Money.Currency.IsoCode}" );

Output

    1 Euro = 18,5130 TRY

```


``` csharp
Code

List<Rate> rates = ExchangeRate.TurkeyAdapterHumanizer.EUR.USD.DövizKuru;
rates.ForEach(rate => Console.WriteLine($"1 {rate.TargetCurrency.Name} = {rate.Money.Amount} {rate.Money.Currency.IsoCode}"));

Output

   1 US Dollar = 18,2205 TRY
   1 Euro = 18,5130 TRY
   
```


``` csharp
Code

List<Rate> convert = ExchangeRate.TurkeyAdapterHumanizer.USD.EUR.GBP.Çevir;
convert.ForEach(rate => Console.WriteLine($"1 {rate.TargetCurrency.Name} = {rate.Money.Amount} {rate.Money.Currency.IsoCode}"));

Output

   1 US Dollar = 0,9842 EUR
   1 US Dollar = 0,8546 GBP

```

### *JSON
``` csharp
Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");

ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.USD).Do(rate =>
{
	Console.WriteLine($"Rate : {EnglishNumberToWordsConverter.New().ToWord(rate)}");
	Console.WriteLine(rate.ToJson());
});
```

Output
```
Base Currency : Turkish Lira
Rate word : Eighteen  Turkish Lira Five Thousand Five Hundred Fifty  kuruş
{
  "TargetCurrency": {
    "Symbol": "$",
    "IsoCode": 840,
    "NumericCode": "840",
    "Name": "US Dollar",
    "SubUnit": "Cent"
  },
  "Money": {
    "Amount": 18.5589,
    "Currency": {
      "Symbol": "?",
      "IsoCode": 949,
      "NumericCode": "949",
      "Name": "Turkish Lira",
      "SubUnit": "kuruş"
    }
  },
  "ExtraInfo": {
    "ForexBuying": 18.5589,
    "ForexSelling": 18.5923,
    "BanknoteBuying": 18.5459,
    "BanknoteSelling": 18.6202
  }
}
```

### *Date
``` csharp
Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");
ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.EUR,DateTime.Now.AddDays(-3)).Do(rate =>
{
	Console.WriteLine($"Relase Date : {rate.RelaseDate.ToString("dd.MM.yyyy")}");
	Console.WriteLine($"{rate.TargetCurrency.Name} = " + rate.Money.Amount);
});
```
Output
```
Base Currency : Turkish Lira
Relase Date : 07.10.2022
Euro = 18,1795
```

### *DateRange
``` csharp
Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");
Console.WriteLine("Rates :");

Console.WriteLine(ExchangeRate.TurkeyAdapter.GetJsonRates(DateRange.From((DateTime.Now.AddDays(-1), DateTime.Now))));
```
Output
```
[
  [
    {
      "RelaseDate": "2022-10-09T22:11:25.1056739+03:00",
      "TargetCurrency": {
        "Symbol": "$",
        "IsoCode": 840,
        "NumericCode": "840",
        "Name": "US Dollar",
        "SubUnit": "Cent"
      },
      "Money": {
        "Amount": 18.5592,
        "Currency": {
          "Symbol": "?",
          "IsoCode": 949,
          "NumericCode": "949",
          "Name": "Turkish Lira",
          "SubUnit": "kuruş"
        }
      },
      "ExtraInfo": {
        "ForexBuying": 18.5592,
        "ForexSelling": 18.5927,
        "BanknoteBuying": 18.5462,
        "BanknoteSelling": 18.6206
      }
    }...
	],
	 [
    {
      "RelaseDate": "2022-10-10T22:11:26.9664876+03:00",
      "TargetCurrency": {
        "Symbol": "$",
        "IsoCode": 840,
        "NumericCode": "840",
        "Name": "US Dollar",
        "SubUnit": "Cent"
      },
      "Money": {
        "Amount": 18.5581,
        "Currency": {
          "Symbol": "?",
          "IsoCode": 949,
          "NumericCode": "949",
          "Name": "Turkish Lira",
          "SubUnit": "kuruş"
        }
      },
      "ExtraInfo": {
        "ForexBuying": 18.5581,
        "ForexSelling": 18.5915,
        "BanknoteBuying": 18.5451,
        "BanknoteSelling": 18.6194
      }
    }...
	]
]
```
### *Setting
``` csharp
ExchangeRate.TurkeyAdapter.AddOption<DataSetting>(option => option.RateDigit = 2);
Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Name}");
Console.WriteLine("Rate :");
ExchangeRate.TurkeyAdapter.GetRate(CurrencyCodes.EUR).Do(rate =>
{
Console.WriteLine($"{rate.TargetCurrency.Name} = " + rate.Money.Amount);
});
```
Output
```
Base Currency : Turkish Lira
Rate :
Euro = 18,68
```
### *Configuration
Add appsetting.json to project
``` json
{
  "EasyExchangeRate": {
    "DataSetting": {
      "RateDigit": 2
    },
    "JsonSetting": {
      "DateFormat": "yyyy-MM-dd"
    }
  },
//alternative
  "DataSetting": {
    "RateDigit": 2
  },
  "JsonSetting": {
    "DateFormat": "yyyy-MM-dd"
  }
}	
```	
Code
``` csharp
var config = new ConfigurationBuilder()
	 .AddJsonFile("appsettings.json", true,true)
	 .Build();

ExchangeRate.EuropeAdapter
	.UseSection(config.GetSection("EasyExchangeRate"))
			.Configure<DataSetting>()
			.Configure<JsonSetting>();

//Alternative usage
//ExchangeRate.EuropeAdapter.Configure<DataSetting>(config.GetSection(nameof(DataSetting)));
//ExchangeRate.EuropeAdapter.Configure<JsonSetting>(config.GetSection(nameof(JsonSetting)));

Console.WriteLine($"Base Currency : {ExchangeRate.EuropeAdapter.BaseCurrency.Name}");
Console.WriteLine("Rate :");
ExchangeRate.EuropeAdapter.GetRate(CurrencyCodes.TRY).Do(rate =>
{
	Console.WriteLine($"{rate.TargetCurrency.Name} = " + rate.Money.Amount);
});
```
Output
```
Base Currency : Euro
Rate :
Turkish Lira = 18,46
```	
free icon : https://www.iconfinder.com/icons/8725865/exchange_icon







