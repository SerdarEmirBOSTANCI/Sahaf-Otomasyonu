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
    public partial class gunlukHareketler : Form
    {
        public gunlukHareketler()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();
        tarih tarih = new tarih();
        
        string yedekBakiye;
        decimal bakiye = 0;
        private void gunlukHareketler_Load(object sender, EventArgs e)
        {
            
            listele();


        }

        private void listele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            baglanti.Open();
            string a = "SELECT id, tarih, gunlukHareketler FROM gunlukHareketler";
            
            DataTable data = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(a, baglanti);
            dataAdapter.Fill(data);

            gunlukHareketListesi.DataSource = data;

            baglanti.Close();

        }

        private void gunuBitir_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            string tarihSil = tarih.tarihgetir();
            baglanti.Open();
            if (bakiye_txt.Text == "")
            {
                MessageBox.Show("Lütfen Önce Mevcut Kasa Bakiyesini Görüntüleyin.");
            }
            else
            {
                SqlCommand ciroSil = new SqlCommand("delete from ciro where tarih=@tarih", baglanti);
                ciroSil.Parameters.AddWithValue("@tarih", tarihSil);
                ciroSil.ExecuteNonQuery();
            }


            
            
            SqlCommand sil = new SqlCommand("delete from gunlukHareketler where tarih=@tarih", baglanti);
            sil.Parameters.AddWithValue("@tarih", tarihSil);
            sil.ExecuteNonQuery();
            listele();

            baglanti.Close();
            bakiye_txt.Clear();

        }

        private void bakiyeGoster_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            baglanti.Open();
            SqlCommand bakiyeGoster = new SqlCommand("Select bakiye FROM ciro", baglanti);
            SqlDataReader oku = bakiyeGoster.ExecuteReader();

            try
            {
                while (oku.Read())
                {
                    yedekBakiye = (string)oku["bakiye"];
                    bakiye += Convert.ToDecimal(yedekBakiye);
                }
                bakiye_txt.Text = bakiye.ToString();
                bakiyeGoster.Dispose();
                oku.Close();
            }
            catch (Exception)
            {
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand aylikCiro = new SqlCommand("insert into aylikGelir values('"+bakiye_txt.Text+"','"+tarih.ayGetir()+"')",baglanti);
            aylikCiro.ExecuteNonQuery();
            baglanti.Close();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }
    }
}
