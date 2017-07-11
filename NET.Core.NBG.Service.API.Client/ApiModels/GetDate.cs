using System.Xml.Serialization;

namespace NET.Core.NBG.Service.API.Client.ApiModels
{
    [XmlRoot("GetDate", Namespace = "urn:NBGCurrency")]
    public class GetDateRequest
    {
    }

    [XmlRoot("GetDateResponse", Namespace = "urn:NBGCurrency")]
    public class GetDateResponse
    {
        [XmlElement("return", DataType = "string", Namespace = "")]
        public string Return { get; set; }
    }
}
