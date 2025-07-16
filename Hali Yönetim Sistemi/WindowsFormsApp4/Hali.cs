using System;

namespace WindowsFormsApp4
{
    public enum HaliDurumu
    {
        Yikamada,
        TeslimEdildi
    }

    public class Hali
    {
        private const decimal MetrekareBasinaUcret = 20.0m;

        public int HaliId { get; set; }
        public decimal Metrekare { get; set; }
        public DateTime AlinmaTarihi { get; set; }
        public DateTime TahminiTeslimTarihi { get; set; }
        public HaliDurumu Durum { get; set; }
        public decimal Ucret { get; private set; }
        public int MusteriId { get; set; }

        public Hali()
        {
            AlinmaTarihi = DateTime.Now;
            TahminiTeslimTarihi = DateTime.Now.AddDays(3);
            Durum = HaliDurumu.Yikamada;
        }

        public Hali(decimal metrekare, int musteriId)
        {
            Metrekare = metrekare;
            AlinmaTarihi = DateTime.Now;
            TahminiTeslimTarihi = DateTime.Now.AddDays(3);
            Durum = HaliDurumu.Yikamada;
            MusteriId = musteriId;
            UcretHesapla();
        }

        public void UcretHesapla()
        {
            Ucret = Metrekare * MetrekareBasinaUcret;
        }

        public void HaliTeslimEdildi()
        {
            Durum = HaliDurumu.TeslimEdildi;
        }

        public override string ToString()
        {
            return $"{Metrekare}m² Halý - {AlinmaTarihi.ToShortDateString()} - {Ucret}TL - {Durum}";
        }
    }
}
