using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private HaliYonetimSistemi _yonetimSistemi;

        public Form1()
        {
            InitializeComponent();
            _yonetimSistemi = new HaliYonetimSistemi();

            OrnekVerileriYukle();

            MusteriListesiniGuncelle();
            HaliListesiniGuncelle();
        }

        private void OrnekVerileriYukle()
        {
            var musteri1 = _yonetimSistemi.MusteriEkle("Ahmet", "Yılmaz", "05551234567", "Kadıköy, İstanbul");
            var musteri2 = _yonetimSistemi.MusteriEkle("Ayşe", "Kaya", "05559876543", "Beşiktaş, İstanbul");

            _yonetimSistemi.HaliEkle(musteri1.MusteriId, 12.5m);
            _yonetimSistemi.HaliEkle(musteri1.MusteriId, 8.3m);
            _yonetimSistemi.HaliEkle(musteri2.MusteriId, 15.7m);
        }

        private void MusteriListesiniGuncelle()
        {
            lstMusteriler.Items.Clear();
            var musteriler = _yonetimSistemi.TumMusterileriGetir();
            foreach (var musteri in musteriler)
            {
                lstMusteriler.Items.Add(musteri);
            }
        }

        private void HaliListesiniGuncelle()
        {
            lstHalilar.Items.Clear();
            cmbHalilar.Items.Clear();

            if (rbTumHalilar.Checked)
            {
                if (lstMusteriler.SelectedItem is Musteri seciliMusteri)
                {
                    // Seçili müşterinin halılarını göster
                    var halilar = _yonetimSistemi.MusterininHalilariniGetir(seciliMusteri.MusteriId);
                    foreach (var hali in halilar)
                    {
                        lstHalilar.Items.Add(hali);
                        cmbHalilar.Items.Add(hali);
                    }
                }
            }
            else if (rbYikamadakiHalilar.Checked)
            {
                if (lstMusteriler.SelectedItem is Musteri seciliMusteri)
                {
                    // Seçili müşterinin yıkamadaki halılarını göster
                    var halilar = _yonetimSistemi.YikamadakiHalilariGetir()
                        .Where(h => h.MusteriId == seciliMusteri.MusteriId)
                        .ToList();
                    foreach (var hali in halilar)
                    {
                        lstHalilar.Items.Add(hali);
                        cmbHalilar.Items.Add(hali);
                    }
                }
                else
                {
                    // Müşteri seçilmediyse listeyi boş bırak
                    // Böylece "Tüm Halılar" ve "Yıkamadaki Halılar" aynı davranışı sergiler
                }
            }
            else if (rbTeslimEdilenHalilar.Checked)
            {
                if (lstMusteriler.SelectedItem is Musteri seciliMusteri)
                {
                    // Seçili müşterinin teslim edilen halılarını göster
                    var halilar = _yonetimSistemi.TeslimEdilenHalilariGetir()
                        .Where(h => h.MusteriId == seciliMusteri.MusteriId)
                        .ToList();
                    foreach (var hali in halilar)
                    {
                        lstHalilar.Items.Add(hali);
                        cmbHalilar.Items.Add(hali);
                    }
                }
                else
                {
                    // Müşteri seçilmediyse listeyi boş bırak
                }
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtTelefon.Text) || string.IsNullOrWhiteSpace(txtAdres.Text))
            {
                MessageBox.Show("Lütfen tüm müşteri bilgilerini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _yonetimSistemi.MusteriEkle(txtAd.Text, txtSoyad.Text, txtTelefon.Text, txtAdres.Text);
            MusteriListesiniGuncelle();

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtAdres.Text = "";
        }

        private void btnHaliEkle_Click(object sender, EventArgs e)
        {
            if (lstMusteriler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMetrekare.Text, out decimal metrekare) || metrekare <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir metrekare değeri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var musteri = (Musteri)lstMusteriler.SelectedItem;
            _yonetimSistemi.HaliEkle(musteri.MusteriId, metrekare);
            HaliListesiniGuncelle();

            txtMetrekare.Text = "";
        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbHalilar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen durumu güncellenecek bir halı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hali = (Hali)cmbHalilar.SelectedItem;
            _yonetimSistemi.HaliDurumuGuncelle(hali.HaliId, HaliDurumu.TeslimEdildi);
            HaliListesiniGuncelle();
        }

        private void lstMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            HaliListesiniGuncelle();
        }

        private void rbTumHalilar_CheckedChanged(object sender, EventArgs e)
        {
            HaliListesiniGuncelle();
        }

        private void rbYikamadakiHalilar_CheckedChanged(object sender, EventArgs e)
        {
            HaliListesiniGuncelle();
        }

        private void rbTeslimEdilenHalilar_CheckedChanged(object sender, EventArgs e)
        {
            HaliListesiniGuncelle();
        }
    }
}
