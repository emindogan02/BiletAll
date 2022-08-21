using static BiletAll.Entity.Enums.Enums;

namespace BiletAll.Entity.Models {
  public class PnrYolcu:BaseEntity {
    public int? KoltukNo { get; set; }
    public decimal Fiyat { get; set; }
    public Durum? Durum { get; set; }
    public int PnrId { get; set; }
    public Pnr? Pnr { get; set; }
    public int YolcuId { get; set; }
    public Yolcu? Yolcu { get; set; }
    public string? Telefon { get; set; }
    public string? Email { get; set; }
  }
}
