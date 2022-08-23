using BiletAll.WebService.Abstract;
using BiletAll.WebService.Dto.Request;
using BiletAll.WebService.Dto.Response;
using BiletAll.WebService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace BiletAll_Mvc.Controllers {
  public class HomeController : Controller {

    private IMemoryCache _cache;

    private readonly IBiletAllService _biletAllService;
    public HomeController(IBiletAllService biletAllService, IMemoryCache cache) {
      _biletAllService = biletAllService;
      _cache = cache;
    }
    [HttpGet]
    public async Task<IActionResult> AnaSayfa() {
      string cacheKey = "karanoktalar";
      if (_cache.TryGetValue(cacheKey, out List<KaraNokta> data)) {
        return View(data);
      } else {
        var karanoktalar = await _biletAllService.KaraNoktaGetirAsync();

        var cacheEntryOptions = new MemoryCacheEntryOptions()
          .SetSlidingExpiration(TimeSpan.FromMinutes(1))
          .SetAbsoluteExpiration(TimeSpan.FromMinutes(1))
          .SetPriority(CacheItemPriority.Normal);
        _cache.Set(cacheKey, karanoktalar, cacheEntryOptions);
        return View(karanoktalar);
      }
    }
    [HttpPost]
    public async Task<IActionResult> AnaSayfa(SeferAraRequest request) {
      var seferler = await _biletAllService.SeferAraAsync(request);
      TempData["Seferler"] = JsonConvert.SerializeObject(seferler);
      return RedirectToAction("Seferler", "Home");
    }

    [HttpGet]
    public IActionResult Seferler() {
      SeferlerResponseDTO? seferler = JsonConvert.DeserializeObject<SeferlerResponseDTO>((string)TempData["Seferler"]);
      return View(seferler);
    }

    [HttpGet]
    public IActionResult SeferDetay() {
      return PartialView("_SeferDetayPartial");
    }

    [HttpGet]
    public IActionResult PnrSorgulama() {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> PnrSorgulama(PnrSorguRequestDTO request) {
      var result = await _biletAllService.PnrSorgulama(request);
        TempData["PnrYolcu"] = JsonConvert.SerializeObject(result);
        return RedirectToAction("PnrDetay", "Home");
      
    }

    public IActionResult PnrDetay() {
      List<PnrResponseDTO>? pnrYolcu = JsonConvert.DeserializeObject<List<PnrResponseDTO>>((string)TempData["PnrYolcu"]);
      return View(pnrYolcu);
    }
  }
}