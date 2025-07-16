using System;
using System.Collections.Generic;

namespace WindowsFormsApp4
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelefonNumarasi { get; set; }
        public string Adres { get; set; }
        public List<Hali> Halilar { get; set; }

        public Musteri()
        {
            Halilar = new List<Hali>();
        }

        public Musteri(string ad, string soyad, string telefonNumarasi, string adres)
        {
            Ad = ad;
            Soyad = soyad;
            TelefonNumarasi = telefonNumarasi;
            Adres = adres;
            Halilar = new List<Hali>();
        }

        public override string ToString()
        {
            return $"{Ad} {Soyad} - {TelefonNumarasi}";
        }
    }
}
