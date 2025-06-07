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
    public partial class Ayarlar : Form
    {
        public Ayarlar()

        {
            InitializeComponent();
            SoruSayisi.Minimum = 1;
            SoruSayisi.Maximum = 10;
            SoruSayisi.Value = Properties.Settings1.Default.QuizSoruSayisi;
        }

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.QuizSoruSayisi = (int)SoruSayisi.Value;
            Properties.Settings1.Default.Save();
            MessageBox.Show("Soru sayısı değiştirildi.");
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();

        }
    }
}
