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
    public partial class oduncVer : Form
    {
        public oduncVer()
        {
            InitializeComponent();
        }
        
        BaglantiSinif bgl = new BaglantiSinif();
        yeniKitapEkle oduncKitap = new yeniKitapEkle();
        gunlukHaraketler gunlukHaraketler = new gunlukHaraketler();

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void listeleKitap()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            baglanti.Open();
            string a = "SELECT id, kitapAdi, yazarAdi, yayinevi, kitapTuru, raf, satmaFiyati, satinAlmaFiyati, resim, özet FROM kitaplar";

            DataTable data = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(a, baglanti);
            dataAdapter.Fill(data);

            kitaplarListesi.DataSource = data;

            baglanti.Close();
        }
        private void listeleOduncKitap()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            baglanti.Open();
            string a = "SELECT isim, kitapAdi, yazarAdi, yayinevi, raf FROM oduncKitap";

            DataTable data = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(a, baglanti);
            dataAdapter.Fill(data);

            oduncKitaplar.DataSource = data;

            baglanti.Close();
        }
        private void oduncVer_Load(object sender, EventArgs e)
        {
            
            listeleKitap();
            
            listeleOduncKitap();





        }

        private void kitaplarListesi_DoubleClick(object sender, EventArgs e)
        { 
            kitapAd.Text = kitaplarListesi.CurrentRow.Cells[1].Value.ToString();
            yazarAd.Text = kitaplarListesi.CurrentRow.Cells[2].Value.ToString();
            yayinevi.Text = kitaplarListesi.CurrentRow.Cells[3].Value.ToString();
            raf.Text = kitaplarListesi.CurrentRow.Cells[4].Value.ToString();
        }

        private void kitapOduncVer_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            string mesaj = "adlı kitap ödünç verildi.";
            baglanti.Open();
            oduncKitap.odunc(kitapAd, yazarAd, yayinevi, raf, isimKayit);
            baglanti.Close();
            gunlukHaraketler.hareketler(mesaj, kitapAd);
            

            listeleOduncKitap();

            kitapAd.Clear();
            yazarAd.Clear();
            yayinevi.Clear();
            raf.Clear();
            isimKayit.Clear();
        }

        private void kitapIadeAl_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            string mesaj = "adlı kitap iade alındı.";
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from oduncKitap where isim=@isim", baglanti);
            sil.Parameters.AddWithValue("@isim", isimKayit.Text);
            sil.ExecuteNonQuery();
            listeleOduncKitap();
            baglanti.Close();
            gunlukHaraketler.hareketler(mesaj, kitapAd);
            kitapAd.Clear();
            yazarAd.Clear();
            yayinevi.Clear();
            raf.Clear();
            isimKayit.Clear();

        }

        private void oduncKitaplar_DoubleClick(object sender, EventArgs e)
        {
            isimKayit.Text = oduncKitaplar.CurrentRow.Cells[0].Value.ToString();
            kitapAd.Text = oduncKitaplar.CurrentRow.Cells[1].Value.ToString();
            yazarAd.Text = oduncKitaplar.CurrentRow.Cells[2].Value.ToString();
            yayinevi.Text = oduncKitaplar.CurrentRow.Cells[3].Value.ToString();
            raf.Text = oduncKitaplar.CurrentRow.Cells[4].Value.ToString();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }
    }
}
