# EasyExchangeRate
Some central bank exchange rates

<details>
	<summary>Todo</summary>
 
  - [ ] Add more country
  - [X] JSON serialize
  - [ ] Nuget package
  - [ ] Web deploy(open api)
  - [ ] Add number to word localizations
	- [X] Turkish
	- [X] English
	- [ ] Affrikan
	- [ ] Arabic
	- [ ] Armenian
	- [ ] Azerbaijani
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
	- [ ] Italian
	- [ ] Japanese
	- [ ] Korean
	- [ ] Latvian
	- [ ] Polish
	- [ ] Romanian
	- [ ] Russian
	- [ ] Spanish
	- [ ] Tamil
	- [ ] Thai
	- [ ] Ukrainian
	- [ ] Uzbek
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
    "Amount": 18.5550,
    "Currency": {
      "Symbol": "₺",
      "IsoCode": 949,
      "NumericCode": "949",
      "Name": "Turkish Lira",
      "SubUnit": "kuruş"
    }
  }
}
```

free icon : https://www.iconfinder.com/icons/8725865/exchange_icon







