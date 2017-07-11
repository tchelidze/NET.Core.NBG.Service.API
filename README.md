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

`using (var nbpClient = new NbgApiClient())`

Invoke client's method and pass corresponding request object

`var getCurrencyResponse = await  nbpClient.GetCurrencyAsync(new GetCurrency.Request { Code = "USD" });`

See usage of all client's method [here](https://github.com/tchelidze/NET.Core.NBG.Service.API/blob/master/NET.Core.NBG.Service.API.Example/Program.cs)
