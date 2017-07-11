using NET.Core.NBG.Service.API.Client;
using NET.Core.NBG.Service.API.Client.Operations;
using System;

namespace NET.Core.NBG.Service.API.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var nbpClient = new NbgApiClient())
            {
                var getCurrencyResponse = nbpClient.GetCurrencyAsync(new GetCurrency.Request { Code = CurrencyCode.USD }).Result;
                Console.WriteLine($"GetCurrencyAsync -> Code : USD Result : {getCurrencyResponse.Rate}");

                var getCurrencyDescriptionResponse = nbpClient.GetCurrencyDescriptionAsync(new GetCurrencyDescription.Request { Code = CurrencyCode.USD }).Result;
                Console.WriteLine($"GetCurrencyDescriptionAsync -> Code : USD Result : {getCurrencyDescriptionResponse.Description}");

                var getCurrencyChangeResponse = nbpClient.GetCurrencyChangeAsync(new GetCurrencyChange.Request { Code = CurrencyCode.USD }).Result;
                Console.WriteLine($"GetCurrencyChangeAsync -> Code : USD Result : {getCurrencyChangeResponse.Change}");

                var getCurrencyRateResponse = nbpClient.GetCurrencyRateAsync(new GetCurrencyRate.Request { Code = CurrencyCode.USD }).Result;
                Console.WriteLine($"GetCurrencyRateAsync -> Code : USD Result : {getCurrencyRateResponse.Rate}");

                var getDateResponse = nbpClient.GetDateAsync(new GetDate.Request()).Result;
                Console.WriteLine($"GetDateAsync -> Code : USD Result : {getDateResponse.Date}");
            }
        }
    }
}