namespace BiletAll.WebService.Dto.Response {
  public class SeferlerResponseDTO {
    public int Id { get; set; }
    public string? Logo { get; set; }
    public string? FirmaAd { get; set; }
    public string? Vakit { get; set; }
    public string? VarisNokta { get; set; }
    public string? KalkisNokta { get; set; }
    public decimal Fiyat { get; set; }
    public DateTime Saat { get; set; }
    public string? OtobusKoltukYerlesim { get; set; }
    public string? SeyahatSuresi { get; set; }
  }
}
