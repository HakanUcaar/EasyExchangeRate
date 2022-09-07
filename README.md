# EasyExchangeRate
Some central bank exchange rates

<details>
	<summary>To Do</summary>
 
  - [X] Add more country
  - [X] JSON serialize
  - [X] Nuget packed
  - [X] Web deploy(open api)
  
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

### *Get Adapter Currencies
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








