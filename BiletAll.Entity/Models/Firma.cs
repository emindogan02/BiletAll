
namespace BiletAll.Entity.Models {
  public class Firma:BaseEntity {
    public int FirmaNo { get; set; }
    public string? FirmaAd { get; set; }
    public string? Telefon { get; set; }
    public string? Logo { get; set; }
    public List<Sefer>? Seferler { get; set; }
  }
}
