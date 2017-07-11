# NET.Core.NBG.Service.API
National Bank of Georgia (NBG) currency service API wrapper for .NET Standart

## [NuGet](https://www.nuget.org/packages/NET.Core.NBG.Service.API.Client/1.0.0)

`PM> Install-Package NET.Core.NBG.Service.API.Client`   

## Usage

* supported operations
1. `GetCurrencyAsync` - აბრუნებს ვალუტის კურსს, მაგ. "1.0754"
2. `GetCurrencyDescriptionAsync` - აბრუნებს ვალუტის აღწერას, მაგ. "10 ესტორნური კრონი"
3. `GetCurrencyChangeAsync`  - 	აბრუნებს ვალუტის ცვლილების მნიშვნელობას, მაგ. "-0.0121"
4. `GetCurrencyRateAsync` - 1 - თუ გაიზარდა; -1 - თუ დაიკლო, 0 - თუ იგივე დარჩა
5. `GetDateAsync` - აბრუნებს კურსების შესაბამის თარიღს

Create an NbgApiClient, you can surround the code with `using` block.

```
using (var nbpClient = new NbgApiClient())
{
   var getCurrencyResponse = await  nbpClient.GetCurrencyAsync(new GetCurrency.Request { Code = "USD" });
   Console.WriteLine($"GetCurrencyAsync -> Code : USD Result : {getCurrencyResponse.Rate}");

   var getCurrencyDescriptionResponse = await  nbpClient.GetCurrencyDescriptionAsync(new GetCurrencyDescription.Request { Code = "USD" });
   Console.WriteLine($"GetCurrencyDescriptionAsync -> Code : USD Result : {getCurrencyDescriptionResponse.Description}");

   var getCurrencyChangeResponse = await nbpClient.GetCurrencyChangeAsync(new GetCurrencyChange.Request { Code = "USD" });
   Console.WriteLine($"GetCurrencyChangeAsync -> Code : USD Result : {getCurrencyChangeResponse.Change}");

   var getCurrencyRateResponse = await  nbpClient.GetCurrencyRateAsync(new GetCurrencyRate.Request { Code = "USD" });
   Console.WriteLine($"GetCurrencyRateAsync -> Code : USD Result : {getCurrencyRateResponse.Rate}");
   
   var getDateResponse = await nbpClient.GetDateAsync(new GetDate.Request());
   Console.WriteLine($"GetDateAsync -> Code : USD Result : {getDateResponse.Date}");
 }```
 
