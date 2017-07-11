using System;

namespace NET.Core.NBG.Service.API.Client.Operations
{
    public class GetDate
    {
        public class Request
        {
        }

        public class Response
        {
            public DateTime Date { get; set; }
        }
    }
}