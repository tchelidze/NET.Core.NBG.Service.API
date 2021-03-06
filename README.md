# NET.Core.NBG.Service.API
National Bank of Georgia (NBG) currency service API wrapper for .NET Standart

## [NuGet](https://www.nuget.org/packages/NET.Core.NBG.Service.API.Client/1.1.0)

`PM> Install-Package NET.Core.NBG.Service.API.Client`   

## Usage

* supported operations
1. `GetCurrencyAsync` - Returns currency exchange rates compared to GEL
2. `GetCurrencyDescriptionAsync` - Returns currency description. ex : "10 ესტორნური კრონი"
3. `GetCurrencyChangeAsync`  - 	Return amount of currency rate change. ex : "-0.0121"
4. `GetCurrencyRateAsync` -  Returns currency rate change summary : 1 - increased , -1 - decreased , 0 - not changed
5. `GetDateAsync` - Returns date for which currency rate is calculated.

Create an NbgApiClient, you can surround the code with `using` block.
```C#
using (var nbpClient = new NbgApiClient())
```

Invoke client's method and pass corresponding request object
```C#
var getCurrencyResponse = await nbpClient.GetCurrencyAsync(new GetCurrency.Request { Code = CurrencyCode.USD });
```

See usage of all client's method [here](https://github.com/tchelidze/NET.Core.NBG.Service.API/blob/master/samples/NET.Core.NBG.Service.API.Example/Program.cs)

## License

This project is licensed under the [MIT license](https://github.com/dotnet/orleans/blob/master/LICENSE)
