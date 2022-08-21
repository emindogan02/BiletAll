using System.Xml.Serialization;

namespace BiletAll.WebService.Models {
	[XmlRoot(ElementName = "Table")]
	public class Sefer {
		[XmlElement(ElementName = "ID")]
		public int ID { get; set; }

		[XmlElement(ElementName = "Vakit")]
		public string? Vakit { get; set; }

		[XmlElement(ElementName = "FirmaNo")]
		public int FirmaNo { get; set; }

		[XmlElement(ElementName = "FirmaAdi")]
		public string? FirmaAdi { get; set; }

		[XmlElement(ElementName = "YerelSaat")]
		public DateTime YerelSaat { get; set; }

		[XmlElement(ElementName = "YerelInternetSaat")]
		public DateTime YerelInternetSaat { get; set; }

		[XmlElement(ElementName = "Tarih")]
		public DateTime Tarih { get; set; }

		[XmlElement(ElementName = "GunBitimi")]
		public int GunBitimi { get; set; }

		[XmlElement(ElementName = "Saat")]
		public DateTime Saat { get; set; }

		[XmlElement(ElementName = "HatNo")]
		public int HatNo { get; set; }

		[XmlElement(ElementName = "IlkKalkisYeri")]
		public string? IlkKalkisYeri { get; set; }

		[XmlElement(ElementName = "SonVarisYeri")]
		public string? SonVarisYeri { get; set; }

		[XmlElement(ElementName = "KalkisYeri")]
		public string? KalkisYeri { get; set; }

		[XmlElement(ElementName = "VarisYeri")]
		public string? VarisYeri { get; set; }

		[XmlElement(ElementName = "IlkKalkisNoktaID")]
		public int IlkKalkisNoktaID { get; set; }

		[XmlElement(ElementName = "IlkKalkisNokta")]
		public string? IlkKalkisNokta { get; set; }

		[XmlElement(ElementName = "KalkisNoktaID")]
		public int KalkisNoktaID { get; set; }

		[XmlElement(ElementName = "KalkisNokta")]
		public string? KalkisNokta { get; set; }

		[XmlElement(ElementName = "VarisNoktaID")]
		public int VarisNoktaID { get; set; }

		[XmlElement(ElementName = "VarisNokta")]
		public string? VarisNokta { get; set; }

		[XmlElement(ElementName = "SonVarisNoktaID")]
		public int SonVarisNoktaID { get; set; }

		[XmlElement(ElementName = "SonVarisNokta")]
		public string? SonVarisNokta { get; set; }

		[XmlElement(ElementName = "OtobusTipi")]
		public string? OtobusTipi { get; set; }

		[XmlElement(ElementName = "OtobusKoltukYerlesimTipi")]
		public string? OtobusKoltukYerlesimTipi { get; set; }

		[XmlElement(ElementName = "OTipAciklamasi")]
		public object? OTipAciklamasi { get; set; }

		[XmlElement(ElementName = "OtobusTelefonu")]
		public string? OtobusTelefonu { get; set; }

		[XmlElement(ElementName = "OtobusPlaka")]
		public object? OtobusPlaka { get; set; }

		[XmlElement(ElementName = "SeyahatSuresi")]
		public DateTime SeyahatSuresi { get; set; }

		[XmlElement(ElementName = "SeyahatSuresiGosterimTipi")]
		public int SeyahatSuresiGosterimTipi { get; set; }

		[XmlElement(ElementName = "YaklasikSeyahatSuresi")]
		public string? YaklasikSeyahatSuresi { get; set; }

		[XmlElement(ElementName = "BiletFiyati1")]
		public int BiletFiyati1 { get; set; }

		[XmlElement(ElementName = "BiletFiyatiInternet")]
		public int BiletFiyatiInternet { get; set; }

		[XmlElement(ElementName = "Sinif_Farki")]
		public int SinifFarki { get; set; }

		[XmlElement(ElementName = "MaxRzvZamani")]
		public int MaxRzvZamani { get; set; }

		[XmlElement(ElementName = "SeferTipi")]
		public object? SeferTipi { get; set; }

		[XmlElement(ElementName = "SeferTipiAciklamasi")]
		public string? SeferTipiAciklamasi { get; set; }

		[XmlElement(ElementName = "HatSeferNo")]
		public object? HatSeferNo { get; set; }

		[XmlElement(ElementName = "O_Tip_Sinif")]
		public int OTipSinif { get; set; }

		[XmlElement(ElementName = "SeferTakipNo")]
		public int SeferTakipNo { get; set; }

		[XmlElement(ElementName = "ToplamSatisAdedi")]
		public int ToplamSatisAdedi { get; set; }

		[XmlElement(ElementName = "DolulukKuraliVar")]
		public int DolulukKuraliVar { get; set; }

		[XmlElement(ElementName = "OTipOzellik")]
		public string? OTipOzellik { get; set; }

		[XmlElement(ElementName = "NormalBiletFiyati")]
		public int NormalBiletFiyati { get; set; }

		[XmlElement(ElementName = "DoluSeferMi")]
		public int DoluSeferMi { get; set; }

		[XmlElement(ElementName = "Tesisler")]
		public string? Tesisler { get; set; }

		[XmlElement(ElementName = "SeferBosKoltukSayisi")]
		public int SeferBosKoltukSayisi { get; set; }

		[XmlElement(ElementName = "KalkisTerminalAdi")]
		public object? KalkisTerminalAdi { get; set; }

		[XmlElement(ElementName = "KalkisTerminalAdiSaatleri")]
		public object? KalkisTerminalAdiSaatleri { get; set; }

		[XmlElement(ElementName = "MaximumRezerveTarihiSaati")]
		public DateTime MaximumRezerveTarihiSaati { get; set; }

		[XmlElement(ElementName = "Guzergah")]
		public string? Guzergah { get; set; }

		[XmlElement(ElementName = "KKZorunluMu")]
		public bool KKZorunluMu { get; set; }

		[XmlElement(ElementName = "BiletIptalAktifMi")]
		public int BiletIptalAktifMi { get; set; }

		[XmlElement(ElementName = "AcikParaKullanimAktifMi")]
		public int AcikParaKullanimAktifMi { get; set; }

		[XmlElement(ElementName = "SefereKadarIptalEdilebilmeSuresiDakika")]
		public int SefereKadarIptalEdilebilmeSuresiDakika { get; set; }

		[XmlElement(ElementName = "FirmaSeferAciklamasi")]
		public string? FirmaSeferAciklamasi { get; set; }

		[XmlElement(ElementName = "SatisYonlendirilecekMi")]
		public int SatisYonlendirilecekMi { get; set; }
	}
}
