using NET.Core.NBG.Service.API.Client.Exceptions;
using NET.Core.NBG.Service.API.Client.Operations;
using SimpleSOAPClient;
using SimpleSOAPClient.Helpers;
using SimpleSOAPClient.Models;
using System;
using System.Threading.Tasks;
using ApiModel = NET.Core.NBG.Service.API.Client.ApiModels;

namespace NET.Core.NBG.Service.API.Client
{
    /// <summary>
    /// For detailed endpoint description refer to : http://www.nbg.ge/api.html
    /// </summary>
    public class NbgApiClient : IDisposable
    {
        readonly SoapClient _client;
        const string NbgApiEndpoint = "http://nbg.gov.ge/currency_service.php";

        public NbgApiClient() => _client = SoapClient.Prepare();

        async Task<SoapEnvelope> InvokeBngApi<TRequest>(TRequest request, string operation)
        {
            var requestEnvelope =
                SoapEnvelope
                .Prepare()
                .Body(request);

            var response = await _client.SendAsync(NbgApiEndpoint, operation, requestEnvelope);
            if (response.IsFaulted())
                throw new UnableToRetrieveDataFromNbgApiException { FaultResponse = response };

            return response;
        }

        /// <summary>
        /// აბრუნებს ვალუტის კურსს, მაგ. "1.0754"
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Operations.GetCurrency.Response> GetCurrencyAsync(Operations.GetCurrency.Request request)
        {
            var response = await InvokeBngApi(new ApiModel.GetCurrencyRequest { Code = request.Code.ToString() }, "GetCurrency");
            var body = response.Body<ApiModel.GetCurrencyResponse>();
            return new GetCurrency.Response { Rate = decimal.Parse(body.Return) };
        }

        /// <summary>
        /// აბრუნებს ვალუტის აღწერას, მაგ. "10 ესტორნური კრონი"
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Operations.GetCurrencyDescription.Response> GetCurrencyDescriptionAsync(Operations.GetCurrencyDescription.Request request)
        {
            var response = await InvokeBngApi(new ApiModel.GetCurrencyDescriptionRequest { Code = request.Code.ToString() }, "GetCurrencyDescription");
            var body = response.Body<ApiModel.GetCurrencyDescriptionResponse>();
            return new GetCurrencyDescription.Response { Description = body.Return };
        }

        /// <summary>
        /// აბრუნებს ვალუტის ცვლილების მნიშვნელობას, მაგ. "-0.0121"
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Operations.GetCurrencyChange.Response> GetCurrencyChangeAsync(Operations.GetCurrencyChange.Request request)
        {
            var response = await InvokeBngApi(new ApiModel.GetCurrencyChangeRequest { Code = request.Code.ToString() }, "GetCurrencyChange");
            var body = response.Body<ApiModel.GetCurrencyChangeResponse>();
            return new GetCurrencyChange.Response { Change = decimal.Parse(body.Return) };
        }

        /// <summary>
        /// 1 - თუ გაიზარდა; -1 - თუ დაიკლო, 0 - თუ იგივე დარჩა
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Operations.GetCurrencyRate.Response> GetCurrencyRateAsync(Operations.GetCurrencyRate.Request request)
        {
            var response = await InvokeBngApi(new ApiModel.GetCurrencyRateRequest { Code = request.Code.ToString() }, "GetCurrencyRate");
            var body = response.Body<ApiModel.GetCurrencyRateResponse>();
            return new GetCurrencyRate.Response { Rate = body.Return };
        }

        /// <summary>
        /// აბრუნებს კურსების შესაბამის თარიღს
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Operations.GetDate.Response> GetDateAsync(Operations.GetDate.Request request)
        {
            var response = await InvokeBngApi(new ApiModel.GetDateRequest(), "GetDate");
            var body = response.Body<ApiModel.GetDateResponse>();
            return new GetDate.Response { Date = DateTime.Parse(body.Return) };
        }


        public void Dispose() => _client?.Dispose();
    }
}