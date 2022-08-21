using static BiletAll.Entity.Enums.Enums;

namespace BiletAll.Entity.Models {
  public class Yolcu:BaseEntity {
    public string? Ad { get; set; }
    public string? Soyad { get; set; }
    public DateTime? DogumTarihi { get; set; }
    public string? TcNo { get; set; }
    public Cinsiyet? Cinsiyet { get; set; }
  }
}
