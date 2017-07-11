namespace NET.Core.NBG.Service.API.Client.Operations
{
    public class GetCurrencyChange
    {
        public class Request
        {
            public string Code { get; set; }
        }

        public class Response
        {
            public decimal Change { get; set; }
        }
    }
}