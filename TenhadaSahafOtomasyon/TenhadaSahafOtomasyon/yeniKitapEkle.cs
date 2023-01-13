using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Runtime.CompilerServices;

namespace TenhadaSahafOtomasyon
{
    internal class yeniKitapEkle
    {
        BaglantiSinif bgl = new BaglantiSinif();
        SqlCommand komut;
        SqlDataReader read;
        public void ekle(TextBox kitapAd, TextBox yazarAd, TextBox yayinevi, ComboBox tur, TextBox raf, TextBox satmaFiyati, TextBox satinAlmaFiyati, TextBox resim, TextBox ozet)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "insert into kitaplar values('"+kitapAd.Text+"','"+yazarAd.Text+"','"+yayinevi.Text+"','"+tur.Text+"','"+raf.Text+"','"+satmaFiyati.Text+"','"+satinAlmaFiyati.Text+"','"+resim.Text+"','"+ozet.Text+"')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Eklendi");

        }

        public void odunc(TextBox kitapAd, TextBox yazarAd, TextBox yayinevi, TextBox raf, TextBox isimKayit)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "insert into oduncKitap values('"+isimKayit.Text+"','" + kitapAd.Text + "','" + yazarAd.Text + "','" + yayinevi.Text + "','" + raf.Text + "')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Ödünç Verildi");

        }

    }
}
