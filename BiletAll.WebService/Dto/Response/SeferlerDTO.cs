namespace BiletAll.WebService.Dto.Response {
  public class SeferlerDTO {
    public int ID { get; set; }
    public string? Logo { get; set; }
    public string? FirmaAdi { get; set; }
    public string? Vakit { get; set; }
    public string? VarisNokta { get; set; }
    public string? KalkisNokta { get; set; }
    public decimal BiletFiyatiInternet { get; set; }
    public DateTime YerelInternetSaat { get; set; }
    public string? OtobusKoltukYerlesimTipi { get; set; }
    public string? SeyahatSuresi { get; set; }
    public string? OTipOzellik { get; set; }
  }
}
