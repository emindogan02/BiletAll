using static BiletAll.Entity.Enums.Enums;

namespace BiletAll.Entity.Models {
  public class Sefer:BaseEntity {
    public string? KalkisNokta { get; set; }
    public string? VarisNokta { get; set; }
    public DateTime? VarisTarihi { get; set; }
    public DateTime? KalkisTarihi { get; set; }
    public SeferTipi? SeferTipi { get; set; }
    public string? Peron { get; set; }
    public string? YaklasikVarisSuresi { get; set; }
    public int FirmaId { get; set; }
    public Firma? Firma { get; set; }
    public List<Pnr>? Pnrlar { get; set; }
  }
}
