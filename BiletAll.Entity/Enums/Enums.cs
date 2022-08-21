using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletAll.Entity.Enums {
  public class Enums {
    public enum Cinsiyet {
      Erkek = 1,
      Kadın = 2,
    }
    public enum Durum {
      Biletli = 1,
      Rezervasyonlu = 2,
      İptalEdildi = 3,
    }
    public enum SeferTipi {
      Molalı = 1,
      Rezervasyonlu = 2
    }
  }
}
