using System.Xml.Serialization;

namespace NET.Core.NBG.Service.API.Client.ApiModels
{
    [XmlRoot("GetCurrencyDescription", Namespace = "urn:NBGCurrency")]
    public class GetCurrencyDescriptionRequest
    {
        [XmlElement(ElementName = "code", Type = typeof(string))]
        public string Code { get; set; }
    }

    [XmlRoot("GetCurrencyDescriptionResponse", Namespace = "urn:NBGCurrency")]
    public class GetCurrencyDescriptionResponse
    {
        [XmlElement("return", DataType = "string", Namespace = "")]
        public string Return { get; set; }
    }
}