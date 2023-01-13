using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenhadaSahafOtomasyon
{
    public partial class kitaplar : Form
    {
        public kitaplar()
        {
            InitializeComponent();
        }
        
        BaglantiSinif bgl = new BaglantiSinif();
        kitapSat satis = new kitapSat();
        gunlukHaraketler gunlukHaraketler = new gunlukHaraketler();
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void listele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            baglanti.Open();
            string a = "SELECT id, kitapAdi, yazarAdi, yayinevi, kitapTuru, raf, satmaFiyati, satinAlmaFiyati, resim, özet FROM kitaplar";

            DataTable data = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(a, baglanti);
            dataAdapter.Fill(data);

            kitapListesi.DataSource = data;

            baglanti.Close();
        }

        private void kitaplar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void aramaCubugu_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            // Textboxa girilen her harf için veri tabanından kitapAdi kısmına göre eşleşen verileri çektik.
            baglanti.Open();
            SqlDataAdapter kitapAra = new SqlDataAdapter("select * from kitaplar where kitapAdi like '%" + aramaCubugu.Text + "%'", baglanti);
            DataSet arananKitap = new DataSet();
            kitapAra.Fill(arananKitap);
            kitapListesi.DataSource = arananKitap.Tables[0];
            baglanti.Close();
        }

        private void KitapTuru_Txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            // seçilen kitap türünü kullanarak veritabanındaki kitapTuru  sutunundaki eşleşen verileri tabloya çektik.
            baglanti.Open();
            SqlDataAdapter turAra = new SqlDataAdapter("select * from kitaplar where kitapTuru like '%" + kitapTuruAra.Text + "%'", baglanti);
            DataSet arananTur = new DataSet();
            turAra.Fill(arananTur);
            kitapListesi.DataSource = arananTur.Tables[0];
            baglanti.Close();

        }
        
        private void kitapListesi_DoubleClick(object sender, EventArgs e)
        {
            // seçilen satırdaki verileri stun numaralarına göre textbox'lara yazdırdık.
            Txt_id.Text = kitapListesi.CurrentRow.Cells[0].Value.ToString();
            Txt_kitapAdi.Text = kitapListesi.CurrentRow.Cells[1].Value.ToString();
            Txt_yazarAdi.Text = kitapListesi.CurrentRow.Cells[2].Value.ToString();
            Txt_yayinevi.Text = kitapListesi.CurrentRow.Cells[3].Value.ToString();
            Txt_kitapTuru.Text = kitapListesi.CurrentRow.Cells[4].Value.ToString();
            Txt_raf.Text = kitapListesi.CurrentRow.Cells[5].Value.ToString();
            Txt_fiyat.Text = kitapListesi.CurrentRow.Cells[6].Value.ToString();
            Txt_satinAlmaFiyati.Text = kitapListesi.CurrentRow.Cells[7].Value.ToString();
            Txt_resim.Text = kitapListesi.CurrentRow.Cells[8].Value.ToString();
            Txt_ozet.Text = kitapListesi.CurrentRow.Cells[9].Value.ToString();
            kitapResmi.ImageLocation = Txt_resim.Text;
        }
        

        private void kitapSat_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            string mesaj = "adlı kitap satıldı.";
            baglanti.Open();
            SqlCommand sat = new SqlCommand("delete from kitaplar where id=@id", baglanti);
            sat.Parameters.AddWithValue("@id", Txt_id.Text);
            sat.ExecuteNonQuery();
            // verileri sildikten sonra tabloyu güncellemek için tekrar bu yapıyı kullandık.
            //this.kitaplarTableAdapter.Fill(this.sahafOtomasyonuDataSet.kitaplar);
            listele();

            baglanti.Close();
            satis.Sat(Txt_fiyat);
            gunlukHaraketler.hareketler(mesaj,Txt_kitapAdi);
        }

        private void kitapSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            string mesaj = "adlı kitap silindi.";
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from kitaplar where id=@id", baglanti);
            sil.Parameters.AddWithValue("@id", Txt_id.Text);
            sil.ExecuteNonQuery();
            // verileri sildikten sonra tabloyu güncellemek için tekrar bu yapıyı kullandık.
            //this.kitaplarTableAdapter.Fill(this.sahafOtomasyonuDataSet.kitaplar);
            listele();

            baglanti.Close();
            gunlukHaraketler.hareketler(mesaj, Txt_kitapAdi);
        }

        private void resim_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Txt_resim.Text = openFileDialog1.FileName;
        }

        

        private void bilgiGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            string mesaj = "adlı kitabın bilgileri güncellendi.";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE kitaplar SET kitapAdi=@kitapAdi , yazarAdi=@yazarAdi , yayinevi=@yayinevi , kitapTuru=@kitapTuru , raf=@raf , satmaFiyati=@fiyat , satinAlmaFiyati=@satinAlmaFiyati , resim=@resim , özet=@ozet WHERE id=@id",baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(Txt_id.Text)); ;
            komut.Parameters.AddWithValue("@kitapAdi",Txt_kitapAdi.Text);
            komut.Parameters.AddWithValue("@yazarAdi", Txt_yazarAdi.Text);
            komut.Parameters.AddWithValue("@yayinevi", Txt_yayinevi.Text);
            komut.Parameters.AddWithValue("@kitapTuru", Txt_kitapTuru.Text);
            komut.Parameters.AddWithValue("@raf", Txt_raf.Text);
            komut.Parameters.AddWithValue("@fiyat", Txt_fiyat.Text);
            komut.Parameters.AddWithValue("@satinAlmaFiyati", Txt_satinAlmaFiyati.Text);
            komut.Parameters.AddWithValue("@resim", Txt_resim.Text);
            komut.Parameters.AddWithValue("@ozet", Txt_ozet.Text);
            komut.ExecuteNonQuery(); 
            baglanti.Close();
            gunlukHaraketler.hareketler(mesaj, Txt_kitapAdi);
            //this.kitaplarTableAdapter.Fill(this.sahafOtomasyonuDataSet.kitaplar);
            listele();

        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }
    }
}
