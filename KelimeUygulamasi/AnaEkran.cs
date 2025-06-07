using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeUygulamasi
{
    public partial class AnaEkran : Form
    {

        int aktifKullaniciId;
        String aktifKullaniciAdi;


        public AnaEkran()
        {
            aktifKullaniciId = KullaniciBilgi.KullaniciId;
            aktifKullaniciAdi = KullaniciBilgi.KullaniciAdi;

            InitializeComponent();
        }

        private void wordle_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wordle wordle = new Wordle();
            wordle.Show();
        }

        private void quiz_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quiz quiz = new Quiz();
            quiz.Show();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            hosgeldin.Text = $"HOŞGELDİN {aktifKullaniciAdi}";
        }

        private void ayarlar_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }

        private void istatistik_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Istatistik istatistik = new Istatistik();
            istatistik.Show();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            
            KullaniciBilgi.KullaniciId = 0; 
            this.Hide();
            girisEkran giris = new girisEkran();
            giris.Show();

        }
    }
}
