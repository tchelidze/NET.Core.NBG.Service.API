namespace NET.Core.NBG.Service.API.Client.Operations
{
    public class GetCurrencyDescription
    {
        public class Request
        {
            public string Code { get; set; }
        }

        public class Response
        {
            public string Description { get; set; }
        }
    }
}