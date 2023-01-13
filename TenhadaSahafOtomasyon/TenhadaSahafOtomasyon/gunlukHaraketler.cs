using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenhadaSahafOtomasyon
{
   

    internal class gunlukHaraketler
    {

        BaglantiSinif bgl = new BaglantiSinif(); SqlCommand komut;
        tarih tarih = new tarih();
        public void hareketler(string islem, TextBox nesne)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            baglanti.Open();
            string hareketKayit = nesne.Text +" "+ islem;
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "insert into gunlukHareketler values('"+tarih.tarihgetir()+"' ,'"+hareketKayit+"')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            
        }
    }
}
