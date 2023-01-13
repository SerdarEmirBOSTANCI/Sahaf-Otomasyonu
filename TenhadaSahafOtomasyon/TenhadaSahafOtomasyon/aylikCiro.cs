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
    public partial class aylikCiro : Form
    {
        BaglantiSinif bgl = new BaglantiSinif();
        public aylikCiro()
        {
            InitializeComponent();
        }
        tarih tarih = new tarih();
        private void aylikCiro_Load(object sender, EventArgs e)
        {
            listele();
        }


        private void listele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            baglanti.Open();
            string a = "SELECT id, bakiye, tarih FROM aylikGelir";

            DataTable data = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(a, baglanti);
            dataAdapter.Fill(data);

            aylikKayıtTablosu.DataSource = data;

            baglanti.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            tarih_txt.Text = aylikKayıtTablosu.CurrentRow.Cells[2].Value.ToString();
        }
        string yedekBakiye;
        decimal bakiye = 0;
        private void hesapla_btn_Click(object sender, EventArgs e)
        {
            ciroHesapla ciroHesapla = new ciroHesapla();
            decimal Ciro = ciroHesapla.aylikCiro(kira_txt, gider_txt, tarih_txt);
            ciro_txt.Text = Ciro.ToString()+"TL";
            

        }

        private void ayBul_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            baglanti.Open();
            string ayBul="";
            
            if (ayBul_txt.Text=="Ocak")
            {
                ayBul = "1";

            }
            else if (ayBul_txt.Text == "Şubat")
            {
                ayBul = "2";
            }
            else if (ayBul_txt.Text == "Mart")
            {
                ayBul = "3";
            }
            else if (ayBul_txt.Text == "Nisan")
            {
                ayBul = "4";
            }
            else if (ayBul_txt.Text == "Mayıs")
            {
                ayBul = "5";
            }
            else if (ayBul_txt.Text == "Haziran")
            {
                ayBul = "6";
            }
            else if (ayBul_txt.Text == "Temmuz")
            {
                ayBul = "7";
            }
            else if (ayBul_txt.Text == "Ağustos")
            {
                ayBul = "8";
            }
            else if (ayBul_txt.Text == "Eylül")
            {
                ayBul = "9";
            }
            else if (ayBul_txt.Text == "Ekim")
            {
                ayBul = "10";
            }
            else if (ayBul_txt.Text == "Kasım")
            {
                ayBul = "11";
            }
            else if (ayBul_txt.Text == "Aralık")
            {
                ayBul = "12";
            }


            SqlDataAdapter ayAra = new SqlDataAdapter("select * from aylikGelir where tarih like '%" + ayBul + "%'", baglanti);
            DataSet arananTur = new DataSet();
            ayAra.Fill(arananTur);
            aylikKayıtTablosu.DataSource = arananTur.Tables[0];
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
