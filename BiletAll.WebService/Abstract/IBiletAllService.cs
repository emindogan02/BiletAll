using BiletAll.WebService.Dto.Request;
using BiletAll.WebService.Dto.Response;
using BiletAll.WebService.Models;

namespace BiletAll.WebService.Abstract {
  public interface IBiletAllService {
    Task<List<KaraNokta>?> KaraNoktaGetirAsync();
    Task<SeferlerResponseDTO?> SeferAraAsync(SeferAraRequest request);
    Task<List<PnrResponseDTO>?> PnrSorgulama(PnrSorguRequestDTO request);
  }
}
