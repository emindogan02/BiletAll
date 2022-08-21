
namespace BiletAll.Entity.Models {
  public class Pnr:BaseEntity {
    public DateTime? IslemTarihi { get; set; }
    public string? PnrNo { get; set; }
    public int SeferId { get; set; }
    public Sefer? Sefer { get; set; }
  }
}
