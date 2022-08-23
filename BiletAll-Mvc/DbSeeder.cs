using BiletAll.Entity.Context;
using BiletAll.Entity.Enums;
using BiletAll.Entity.Models;
using BiletAll_Mvc.Helper;

namespace BiletAll_Mvc {
  public static class DbSeeder {

    public static async void Seed(IApplicationBuilder app) {
      using (var serviceScope = app.ApplicationServices.CreateScope()) {
        var _context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
        await FirmaOlustur(_context!);
      }
    }

    private static async Task FirmaOlustur(ApplicationDbContext _context) {
      if(!_context.Pnrlar!.Any(x=>x.PnrNo== "YLE068")) {
        var firma = new Firma() {
          FirmaAd = "Ünal Turizm",
          FirmaNo = 13,
          Logo = "https://s3.eu-central-1.amazonaws.com/static.obilet.com/images/partner/4071-sm.png",
          Telefon = "03281181128"
        };
        var sefer = new Sefer {
          KalkisNokta = "ADIYAMAN",
          VarisNokta = "ANKARA",
          VarisTarihi = DateTime.Now,
          KalkisTarihi = DateTime.Now,
          SeferTipi = Enums.SeferTipi.Molalı,
          Peron = "11",
          YaklasikVarisSuresi = "10-11",
          Firma = firma
        };

        var pnr = new Pnr() {
          IslemTarihi = DateTime.Now,
          PnrNo = $"{RandomPnrCodeGenerator.RandomStringChar(3)}{RandomPnrCodeGenerator.RandomStringNum(3)}",
          Sefer = sefer
        };
        var yolcu = new Yolcu() {
          Ad = "Deniz",
          Soyad = "Doğan",
          DogumTarihi = new DateTime(2000, 11, 10, 9, 5, 0),
          Cinsiyet = Enums.Cinsiyet.Kadın,
          TcNo = "12345678912"
        };

        var pnrYolcu = new PnrYolcu() {
          Yolcu = yolcu,
          Pnr = pnr,
          Durum = Enums.Durum.Biletli,
          Email = "test@hotmail.com",
          Fiyat = 400,
          KoltukNo = 9,
          Telefon = "5310214151"
        };

        await _context.PnrYolcular!.AddAsync(pnrYolcu);
        await _context.SaveChangesAsync();
      }
    }


  }
}

