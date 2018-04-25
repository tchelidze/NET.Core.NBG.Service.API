using SimpleSOAPClient.Models;
using System;

namespace NET.Core.NBG.Service.API.Client.Exceptions
{
    public class UnableToRetrieveDataFromNbgApiException : Exception
    {
        public SoapEnvelope FaultResponse { get; set; }
    }
}