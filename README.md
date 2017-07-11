# NET.Core.NBG.Service.API
National Bank of Georgia (NBG) currency service API wrapper for .NET Standart

## [NuGet](https://www.nuget.org/packages/NET.Core.NBG.Service.API.Client/1.0.0)

`PM> Install-Package NET.Core.NBG.Service.API.Client`   

## Usage

Create an NbgApiClient, you can surround the code with `using` block.

 `using (var nbpClient = new NbgApiClient())`
 
⋅⋅* supported operations
1. `GetCurrencyAsync`
2. `GetCurrencyDescriptionAsync`
3. `GetCurrencyChangeAsync`
4. `GetCurrencyRateAsync`
5. `GetDateAsync`
