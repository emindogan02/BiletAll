using static BiletAll.Entity.Enums.Enums;

namespace BiletAll.WebService.Dto.Response {
  public class YolcularResponseDTO {
    public string? YolcuAd { get; set; }
    public string? Telefon { get; set; }
    public Cinsiyet? Cinsiyet { get; set; }
    public string? Email { get; set; }
    public int? KoltukNo { get; set; }
  }
}
