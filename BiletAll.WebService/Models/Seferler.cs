using System.Xml.Serialization;

namespace BiletAll.WebService.Models {
  [XmlRoot("NewDataSet")]
  public class Seferler {
    [XmlElement("Table")]
    public List<Sefer>? SeferListesi { get; set; }

    [XmlElement("OTipOzellik")]
    public List<OTipOzellik>? OTipOzellik { get; set; }
  }
}
