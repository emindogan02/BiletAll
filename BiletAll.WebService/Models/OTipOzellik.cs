using System.Xml.Serialization;

namespace BiletAll.WebService.Models {
  [XmlRoot(ElementName = "OTipOzellik")]
  public class OTipOzellik {
    [XmlElement(ElementName = "O_Tip_Ozellik")]
    public int OTipOzellikk { get; set; }

    [XmlElement(ElementName = "O_Tip_Ozellik_Aciklama")]
    public string? OTipOzellikAciklama { get; set; }

    [XmlElement(ElementName = "O_Tip_Ozellik_Detay")]
    public string? OTipOzellikDetay { get; set; }

    [XmlElement(ElementName = "O_Tip_Ozellik_Icon")]
    public string? OTipOzellikIcon { get; set; }
  }
}
