using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp4
{
    public class HaliYonetimSistemi
    {
        private List<Musteri> _musteriler;
        private List<Hali> _halilar;
        private int _musteriIdSayaci;
        private int _haliIdSayaci;

        public HaliYonetimSistemi()
        {
            _musteriler = new List<Musteri>();
            _halilar = new List<Hali>();
            _musteriIdSayaci = 1;
            _haliIdSayaci = 1;
        }

        public Musteri MusteriEkle(string ad, string soyad, string telefonNumarasi, string adres)
        {
            var musteri = new Musteri(ad, soyad, telefonNumarasi, adres)
            {
                MusteriId = _musteriIdSayaci++
            };
            _musteriler.Add(musteri);
            return musteri;
        }

        public Hali HaliEkle(int musteriId, decimal metrekare)
        {
            var musteri = _musteriler.FirstOrDefault(m => m.MusteriId == musteriId);
            if (musteri == null)
                return null;

            var hali = new Hali(metrekare, musteriId)
            {
                HaliId = _haliIdSayaci++
            };
            _halilar.Add(hali);
            musteri.Halilar.Add(hali);
            return hali;
        }

        public bool HaliDurumuGuncelle(int haliId, HaliDurumu durum)
        {
            var hali = _halilar.FirstOrDefault(h => h.HaliId == haliId);
            if (hali == null)
                return false;

            hali.Durum = durum;
            return true;
        }

        public List<Musteri> TumMusterileriGetir()
        {
            return _musteriler;
        }

        public List<Hali> YikamadakiHalilariGetir()
        {
            return _halilar.Where(h => h.Durum == HaliDurumu.Yikamada).ToList();
        }

        public List<Hali> TeslimEdilenHalilariGetir()
        {
            return _halilar.Where(h => h.Durum == HaliDurumu.TeslimEdildi).ToList();
        }

        public List<Hali> MusterininHalilariniGetir(int musteriId)
        {
            return _halilar.Where(h => h.MusteriId == musteriId).ToList();
        }
    }
}
