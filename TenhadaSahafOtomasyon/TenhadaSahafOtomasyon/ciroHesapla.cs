using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenhadaSahafOtomasyon
{
    internal class ciroHesapla
    {
        BaglantiSinif bgl = new BaglantiSinif(); decimal bakiye;
        string yedekBakiye;
        decimal aylikBakiye;
        public decimal aylikCiro(TextBox kira, TextBox Fatura, TextBox tarih)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);
            baglanti.Open();
            SqlCommand bakiyeGoster = new SqlCommand("Select bakiye FROM aylikGelir", baglanti);
            SqlDataReader oku = bakiyeGoster.ExecuteReader();

            try
            {
                while (oku.Read())
                {
                    yedekBakiye = (string)oku["bakiye"];
                    bakiye += Convert.ToDecimal(yedekBakiye);
                }
                aylikBakiye = bakiye;
                bakiyeGoster.Dispose();
                oku.Close();
            }
            catch (Exception)
            {
            }
            baglanti.Close();

            decimal aylikKira = Convert.ToDecimal(kira.Text);
            decimal aylikFatura = Convert.ToDecimal(Fatura.Text);
            decimal AylikCiro = aylikBakiye-(aylikKira+aylikFatura);




            return AylikCiro;
        }
    }
}
