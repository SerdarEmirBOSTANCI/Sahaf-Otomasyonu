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
    public partial class kullaniciBilgileri : Form
    {
        public kullaniciBilgileri()
        {
            InitializeComponent();
        }
       
        BaglantiSinif bgl = new BaglantiSinif();



        private void geri_btn_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE girisPaneli SET kullaniciAdi=@kullaniciAdi , sifre=@sifre , mail=@mail , telefonNo=@telefonNo , dukkanAdi=@dukkanAdi WHERE id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(id_txt.Text)); 
            komut.Parameters.AddWithValue("@kullaniciAdi", kullanici_txt.Text);
            komut.Parameters.AddWithValue("@sifre", sifre_txt.Text);
            komut.Parameters.AddWithValue("@mail", mail_txt.Text);
            komut.Parameters.AddWithValue("@telefonNo", telNo_txt.Text);
            komut.Parameters.AddWithValue("@dukkanAdi", dukkan_txt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void listele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            baglanti.Open();
            string a = "SELECT id, kullaniciAdi, sifre, mail, telefonNo, dukkanAdi FROM girisPaneli";

            DataTable data = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(a, baglanti);
            dataAdapter.Fill(data);

            kayitListesi.DataSource = data;

            baglanti.Close();
        }

        private void kullaniciBilgileri_Load(object sender, EventArgs e)
        {
            
                listele();

        }

        private void kayitListesi_DoubleClick(object sender, EventArgs e)
        {
            id_txt.Text = kayitListesi.CurrentRow.Cells[0].Value.ToString();
            kullanici_txt.Text = kayitListesi.CurrentRow.Cells[1].Value.ToString();
            sifre_txt.Text = kayitListesi.CurrentRow.Cells[2].Value.ToString();
            mail_txt.Text = kayitListesi.CurrentRow.Cells[3].Value.ToString();
            telNo_txt.Text = kayitListesi.CurrentRow.Cells[4].Value.ToString();
            dukkan_txt.Text = kayitListesi.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
