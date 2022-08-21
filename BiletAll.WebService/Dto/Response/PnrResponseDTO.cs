using static BiletAll.Entity.Enums.Enums;

namespace BiletAll.WebService.Dto.Response {
  public class PnrResponseDTO {
    public string? KalkisNokta { get; set; }
    public string? VarisNokta { get; set; }
    public DateTime? Tarih { get; set; }
    public DateTime? Saat { get; set; }
    public string? PnrNo { get; set; }
    public string? Logo { get; set; }
    public string? YaklasikSure { get; set; }
    public decimal Fiyat { get; set; }
    public string? YolcuAd { get; set; }
    public string? Telefon { get; set; }
    public Cinsiyet? Cinsiyet { get; set; }
    public string? Email { get; set; }
    public int? KoltukNo { get; set; }
    public Durum? Durum { get; set; }
    public SeferTipi? SeferTipi { get; set; }
    public string? Peron { get; set; }
  }
}
