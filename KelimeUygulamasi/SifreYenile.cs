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

namespace KelimeUygulamasi
{
    public partial class SifreYenile : Form
    {
        SqlConnection cn = new SqlConnection("Server=.;Database=KelimeUygulamasi;Trusted_Connection=True;");


        public SifreYenile()
        {

            InitializeComponent();

            //parolanın yazılacağı kısmı görünmez yaptık.
            label2.Visible = false;
            label3.Visible = false;
            txt_parola.Visible = false;
            txt_parolaTekrar.Visible = false;
            btn_guncelle.Visible = false;
        }

        private void btn_dogrula_Click(object sender, EventArgs e)
        {
            //e-posta doğrulama
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Kullanicilar WHERE Email = @email", cn);
            cmd.Parameters.AddWithValue("@email", txt_eposta.Text);
            int sonuc = (int)cmd.ExecuteScalar();
            cn.Close();

            if (sonuc > 0)
            {
                //e-posta doğrulandıysa şifre yaz
                label2.Visible = true;
                label3.Visible = true;
                txt_parola.Visible = true;
                txt_parolaTekrar.Visible = true;
                btn_guncelle.Visible = true;

                label1.Visible = false;
                txt_eposta.Visible = false;
                btn_dogrula.Visible = false;
                MessageBox.Show("E-postanız doğrulandı.");
            }
            else
            {
                MessageBox.Show("Bu e-postaya kayıtlı kullanıcı bulunamadı..");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_parola.Text == txt_parolaTekrar.Text)
            {
                //yazılan şifreler aynıysa kullanıcının şifresini değiştir. 
                cn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET password = @password WHERE Email = @email", cn);
                cmd.Parameters.AddWithValue("@password", txt_parola.Text);
                cmd.Parameters.AddWithValue("@email", txt_eposta.Text);
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Şifreniz güncellendi.");
                this.Close();
                girisEkran GirisEkran = new girisEkran();
                GirisEkran.Show();
            }
            else
                MessageBox.Show("Girdiğiniz şifreler uyuşmuyor.");



        }
    }
}
