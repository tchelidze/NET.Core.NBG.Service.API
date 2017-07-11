using System.Xml.Serialization;

namespace NET.Core.NBG.Service.API.Client.ApiModels
{
    [XmlRoot("GetCurrencyRate", Namespace = "urn:NBGCurrency")]
    public class GetCurrencyRateRequest
    {
        [XmlElement(ElementName = "code", Type = typeof(string))]
        public string Code { get; set; }
    }

    [XmlRoot("GetCurrencyRateResponse", Namespace = "urn:NBGCurrency")]
    public class GetCurrencyRateResponse
    {
        [XmlElement("return", DataType = "int", Namespace = "")]
        public int Return { get; set; }
    }
}