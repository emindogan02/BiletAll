using AutoMapper;
using BiletAll.Entity.Context;
using BiletAll.Entity.Enums;
using BiletAll.Entity.Models;
using BiletAll.WebService.Abstract;
using BiletAll.WebService.Dto.Request;
using BiletAll.WebService.Dto.Response;
using BiletAll.WebService.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;

namespace BiletAll.WebService.Concrete {
  public class BiletAllService : IBiletAllService {
    private readonly ApplicationDbContext _db;
    private BiletAllReference.ServiceSoapClient _webService;
    private string xmlYetki = "<Kullanici><Adi>stajyerWS</Adi><Sifre>2324423WSs099</Sifre></Kullanici>";
    private readonly IMapper _mapper;
    public BiletAllService(ApplicationDbContext db, IMapper mapper) {
      _webService = new BiletAllReference.ServiceSoapClient(BiletAllReference.ServiceSoapClient.EndpointConfiguration.ServiceSoap);
      _db = db;
      _mapper = mapper;
    }

    public async Task<SeferlerResponseDTO?> SeferAraAsync(SeferAraRequest request) {
      try {
        string gidisDate = request.GidisDate.ToString("yyyy-MM-dd");
        string seferGetir = @"<Sefer>
                                    <FirmaNo>0</FirmaNo>
                                    <KalkisNoktaID>" + request.GidisID + @"</KalkisNoktaID>
                                    <VarisNoktaID>" + request.VarisID + @"</VarisNoktaID>
                                    <Tarih>" + gidisDate + @"</Tarih>
                                    <AraNoktaGelsin>0</AraNoktaGelsin>
                                    <IslemTipi>0</IslemTipi>
                                    <YolcuSayisi>1</YolcuSayisi>
                                    <Ip>88.230.18.217</Ip>
                               </Sefer>";
        var result = await _webService.StrIsletAsync(seferGetir, xmlYetki);

        XmlSerializer seferSerializer = new XmlSerializer(typeof(Seferler));
        TextReader seferReader = new StringReader(result.Body.StrIsletResult);
        Seferler? seferler = (Seferler?)seferSerializer.Deserialize(seferReader);

        SeferlerResponseDTO dto = new();
        dto.Seferler = new List<SeferlerDTO>();

        if (seferler != null && seferler.SeferListesi != null && seferler.SeferListesi.Count > 0) {
          foreach (var sefer in seferler.SeferListesi) {
            string seyahatSuresi = "";
            if (sefer.SeyahatSuresiGosterimTipi == 1) {
              seyahatSuresi = sefer.YaklasikSeyahatSuresi + " saat";
            } else if (sefer.SeyahatSuresiGosterimTipi == 2) {
              seyahatSuresi = sefer.SeyahatSuresi.ToString("HH:mm");
            }
            var mapping = _mapper.Map<SeferlerDTO>(sefer);
            mapping.SeyahatSuresi = seyahatSuresi;
            mapping.Logo = "https://s3.eu-central-1.amazonaws.com/static.obilet.com/images/partner/4071-sm.png";
            // Logo = "https://s3.eu-central-1.amazonaws.com/static.obilet.com/images/partner/" + sefer.FirmaNo + "-sm.png"

            dto.Seferler!.Add(mapping);
          }
          dto.OtobusOzellikler = _mapper.Map<List<OtobusOzellik>>(seferler.OTipOzellik);
          return dto;
        }
        return null;
      } catch (Exception) {

        return null;
      }

    }

    public async Task<List<KaraNokta>?> KaraNoktaGetirAsync() {
      try {
        string xmlIslem = @"<KaraNoktaGetirKomut/>";
        var result = await _webService.StrIsletAsync(xmlIslem, xmlYetki);
        XmlSerializer serializer = new XmlSerializer(typeof(KaraNoktalar));
        TextReader reader = new StringReader(result.Body.StrIsletResult);
        KaraNoktalar? karanoktalar = (KaraNoktalar?)serializer.Deserialize(reader);
        if (karanoktalar != null) {
          return karanoktalar.KaraNokta;
        }
        return null;
      } catch (Exception) {
        return null;
      }

    }

    public async Task<List<PnrResponseDTO>?> PnrSorgulama(PnrSorguRequestDTO request) {
      try {
        List<PnrResponseDTO> dto = new();

        List<PnrYolcu> pnrYolcular = _db.PnrYolcular!.Include(x => x.Pnr).ThenInclude(p => p!.Sefer).ThenInclude(s => s!.Firma).Include(x => x.Yolcu).Where(x => x.Pnr!.PnrNo == request.PnrNo && x.Durum != Enums.Durum.İptalEdildi && (x.Telefon == request.TelEmail || x.Email == request.TelEmail)).ToList();

        dto = pnrYolcular.Select(x => new PnrResponseDTO {

          Fiyat = x.Fiyat,
          Saat = x.Pnr?.Sefer?.KalkisTarihi,
          PnrNo = x.Pnr?.PnrNo,
          YolcuAd = x.Yolcu?.Ad,
          Telefon = x.Telefon,
          Cinsiyet = x.Yolcu?.Cinsiyet,
          Email = x.Email,
          Durum = x.Durum,
          KoltukNo = x.KoltukNo,
          Peron = x.Pnr?.Sefer?.Peron,
          Tarih = x.Pnr?.Sefer?.KalkisTarihi,
          KalkisNokta = x.Pnr?.Sefer?.KalkisNokta,
          SeferTipi = x.Pnr?.Sefer?.SeferTipi,
          VarisNokta = x.Pnr?.Sefer?.VarisNokta,
          YaklasikSure = x.Pnr?.Sefer?.YaklasikVarisSuresi,
          Logo = x.Pnr?.Sefer?.Firma?.Logo
        }).ToList();

        return dto;
      } catch (Exception) {
        return null;
      }
    }

  }
}