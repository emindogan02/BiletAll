using System.Xml.Serialization;

namespace BiletAll.WebService.Models {
  [XmlRoot("KaraNoktalar")]
  public class KaraNoktalar {
    [XmlElement("KaraNokta")]
    public List<KaraNokta>? KaraNokta { get; set; }
  }
}
