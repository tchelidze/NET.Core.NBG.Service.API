using System.Xml.Serialization;

namespace NET.Core.NBG.Service.API.Client.ApiModels
{
    [XmlRoot("GetCurrencyChange", Namespace = "urn:NBGCurrency")]
    public class GetCurrencyChangeRequest
    {
        [XmlElement(ElementName = "code", Type = typeof(string))]
        public string Code { get; set; }
    }

    [XmlRoot("GetCurrencyChangeResponse", Namespace = "urn:NBGCurrency")]
    public class GetCurrencyChangeResponse
    {
        [XmlElement("return", DataType = "string", Namespace = "")]
        public string Return { get; set; }
    }
}
