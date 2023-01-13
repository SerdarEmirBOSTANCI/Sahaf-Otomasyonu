using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenhadaSahafOtomasyon
{
    
    internal class kitapSat
    {
        tarih tarih = new tarih();
        BaglantiSinif bgl = new BaglantiSinif();
        SqlCommand sat;
        
        
        
        public void Sat(TextBox Txt_fiyat)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            baglanti.Open();
            sat = new SqlCommand();
            sat.Connection = baglanti;
            sat.CommandText = "insert into ciro values('" + Txt_fiyat.Text + "' ,'"+ tarih.tarihgetir() + "')";
            sat.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Satıldı");
            

        }

        public void satınAl(TextBox Txt_satinAlmaFiyati)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            baglanti.Open();
            string satinAlinanKitap = "-"+Txt_satinAlmaFiyati.Text;
            SqlCommand satinAl = new SqlCommand("insert into ciro values('"+satinAlinanKitap+ "', '"+ tarih.tarihgetir() +"')", baglanti);
            satinAl.ExecuteNonQuery();
            baglanti.Close();
        }

    }
}
