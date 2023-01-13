using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenhadaSahafOtomasyon
{
    public partial class kitapEkle : Form
    {
        public kitapEkle()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();

        yeniKitapEkle kitapKaydet = new yeniKitapEkle();
        kitapSat satinAlınanKitap = new kitapSat();
        gunlukHaraketler gunlukHaraketler = new gunlukHaraketler();
        tarih tarih = new tarih();

        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void Yayinevi_TextChanged(object sender, EventArgs e)
        {
        }

        private void resim_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Resim_Txt.Text = openFileDialog1.FileName;
        }

        private void KitapEkle_btn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            string mesaj = "adlı kitap eklendi";
            baglanti.Open();
            kitapKaydet.ekle(KitapAdi_Txt, YazarAdi_Txt, Yayinci_Txt, KitapTuru_Txt, Raf_Txt, SatmaFiyati_Txt, SatinAlmaFiyati_Txt, Resim_Txt, Ozet_Txt);
            satinAlınanKitap.satınAl(SatinAlmaFiyati_Txt);
            gunlukHaraketler.hareketler(mesaj, KitapAdi_Txt);
            KitapAdi_Txt.Clear();
            YazarAdi_Txt.Clear();
            Yayinci_Txt.Clear();
            Raf_Txt.Clear();
            SatmaFiyati_Txt.Clear();
            SatinAlmaFiyati_Txt.Clear();
            Resim_Txt.Clear();
            Ozet_Txt.Clear();
            baglanti.Close();
            KitapTuru_Txt.SelectedItem = null;
            KitapAdi_Txt.Focus();

        }
        
        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }
    }
}
