using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenhadaSahafOtomasyon
{
    internal class tarih
    {
        public string tarihgetir()
        {
            DateTime tarih = DateTime.Now;
            int day = tarih.Day;
            int mounth = tarih.Month;
            int year = tarih.Year;
            string gun = day.ToString();
            string ay = mounth.ToString();
            string yil = year.ToString();
            string tarihKayit = gun + "." + ay + "." + yil;
            
            return tarihKayit;
        }

        public string ayGetir()
        {
            DateTime tarih = DateTime.Now;
            int mounth = tarih.Month;
            int year = tarih.Year;
            string ay = mounth.ToString();
            string yil = year.ToString();
            string tarihKayit = ay + "." + yil;

            return tarihKayit;
        }
    }
}
