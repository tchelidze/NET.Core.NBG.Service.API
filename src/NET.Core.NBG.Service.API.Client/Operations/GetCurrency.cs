namespace NET.Core.NBG.Service.API.Client.Operations
{
    public class GetCurrency
    {
        public class Request
        {
            public CurrencyCode Code { get; set; }
        }

        public class Response
        {
            public decimal Rate { get; set; }
        }
    }
}