using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenhadaSahafOtomasyon
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitaplar kitaplar = new kitaplar();
            kitaplar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitapEkle kitapEkle = new kitapEkle();
            kitapEkle.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oduncVer oduncVer = new oduncVer();
            oduncVer.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gunlukHareketler gunlukHareketler = new gunlukHareketler();
            gunlukHareketler.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aylikCiro aylikCiro = new aylikCiro();
            aylikCiro.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kullaniciBilgileri kullaniciBilgileri = new kullaniciBilgileri();
            kullaniciBilgileri.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
