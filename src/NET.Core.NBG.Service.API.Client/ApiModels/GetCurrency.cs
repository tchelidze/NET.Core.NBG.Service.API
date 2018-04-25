using System.Xml.Serialization;

namespace NET.Core.NBG.Service.API.Client.ApiModels
{
    [XmlRoot("GetCurrency", Namespace = "urn:NBGCurrency")]
    public class GetCurrencyRequest
    {
        [XmlElement(ElementName = "code", Type = typeof(string))]
        public string Code { get; set; }
    }

    [XmlRoot("GetCurrencyResponse", Namespace = "urn:NBGCurrency")]
    public class GetCurrencyResponse
    {
        [XmlElement("return", DataType = "string", Namespace = "")]
        public string Return { get; set; }
    }
}