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
    public partial class GirisYap : Form
    {
        BaglantiSinif bgl = new BaglantiSinif();

        public GirisYap()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            string sorgu = "SELECT * FROM girisPaneli where kullaniciAdi=@user AND sifre=@pass";
            
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@user", kullanici_txt.Text);
            cmd.Parameters.AddWithValue("@pass", sifre_txt.Text);
            baglanti.Open();
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                menu goster = new menu();
                goster.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();

        }

        private void kayitOl_Click(object sender, EventArgs e)
        {
            kayitOl fr = new kayitOl();
            fr.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
