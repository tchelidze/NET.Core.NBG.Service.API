# NET.Core.NBG.Service.API
National Bank of Georgia (NBG) currency service API wrapper for .NET Standart

## [NuGet](https://www.nuget.org/packages/NET.Core.NBG.Service.API.Client/1.0.0)

`PM> Install-Package NET.Core.NBG.Service.API.Client`   

## Usage

* supported operations
1. `GetCurrencyAsync`
2. `GetCurrencyDescriptionAsync`
3. `GetCurrencyChangeAsync`
4. `GetCurrencyRateAsync`
5. `GetDateAsync`

Create an NbgApiClient, you can surround the code with `using` block.

`using (var nbpClient = new NbgApiClient())
            {
                var getCurrencyResponse = nbpClient.GetCurrencyAsync(new GetCurrency.Request { Code = "USD" }).Result;
                Console.WriteLine($"GetCurrencyAsync -> Code : USD Result : {getCurrencyResponse.Rate}");

                var getCurrencyDescriptionResponse = nbpClient.GetCurrencyDescriptionAsync(new GetCurrencyDescription.Request { Code = "USD" }).Result;
                Console.WriteLine($"GetCurrencyDescriptionAsync -> Code : USD Result : {getCurrencyDescriptionResponse.Description}");

                var getCurrencyChangeResponse = nbpClient.GetCurrencyChangeAsync(new GetCurrencyChange.Request { Code = "USD" }).Result;
                Console.WriteLine($"GetCurrencyChangeAsync -> Code : USD Result : {getCurrencyChangeResponse.Change}");

                var getCurrencyRateResponse = nbpClient.GetCurrencyRateAsync(new GetCurrencyRate.Request { Code = "USD" }).Result;
                Console.WriteLine($"GetCurrencyRateAsync -> Code : USD Result : {getCurrencyRateResponse.Rate}");

                var getDateResponse = nbpClient.GetDateAsync(new GetDate.Request()).Result;
                Console.WriteLine($"GetDateAsync -> Code : USD Result : {getDateResponse.Date}");
            }`
 
