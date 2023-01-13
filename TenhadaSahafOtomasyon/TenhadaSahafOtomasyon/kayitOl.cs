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
    public partial class kayitOl : Form
    {
        public kayitOl()
        {
            InitializeComponent();
        }
       
        BaglantiSinif bgl = new BaglantiSinif();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            baglanti.Open();
            string kullanici;
            string Sifre;
            string e_posta;
            string TelNo;
            string dukkan;
            kullanici = kullaniciAdi.Text;
            Sifre = sifre.Text;
            e_posta = mail.Text;
            TelNo = telNo.Text;
            dukkan = DukkanAdi.Text;
            SqlCommand komut = new SqlCommand("select * from girisPaneli where kullaniciAdi = '"+kullanici+"'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Kullanıcı Adı Alınmış");

            }
            else
            {
                oku.Close();
                SqlCommand ekle = new SqlCommand("insert into girisPaneli(kullaniciAdi,sifre,mail,telefonNo,dukkanAdi) values('" + kullanici + "' , '" + Sifre + "' , '" + e_posta + "' ,'" + TelNo + "','" + dukkan + "')", baglanti);
                ekle.ExecuteNonQuery();
                kullaniciAdi.Clear();
                sifre.Clear();
                mail.Clear();
                telNo.Clear();
                DukkanAdi.Clear(); 
                MessageBox.Show("Kayıt Başarılı");
                this.Hide();
            }
            
            
            baglanti.Close();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
