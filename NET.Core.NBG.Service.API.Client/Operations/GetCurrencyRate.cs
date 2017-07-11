namespace NET.Core.NBG.Service.API.Client.Operations
{
    public class GetCurrencyRate
    {
        public class Request
        {
            public CurrencyCode Code { get; set; }
        }

        public class Response
        {
            public int Rate { get; set; }
        }
    }
}