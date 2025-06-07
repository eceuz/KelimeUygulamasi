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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KelimeUygulamasi
{
    public partial class girisEkran : Form
    {
        //veritabanı bağlantısı
        String connectionString = "Data Source=.;Initial Catalog=kelimeUygulamasi;Integrated Security=True ";
        public girisEkran()
        {
            InitializeComponent();
        }



        private void kayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //kayıt ekranı açılıyor.
            this.Hide();
            KayitOl kayitEkran = new KayitOl();
            kayitEkran.Show();
        }

        private void giris_btn_Click(object sender, EventArgs e)
        {

            string Username = kullaniciAdi.Text;
            string Password = parola.Text;

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                string query = "SELECT Id FROM Kullanicilar WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@username", kullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@password", parola.Text);

                object result = cmd.ExecuteScalar();
                //kullanıcı adı ve parola veritabanında kayıtlıysa kişi giriş yapıyor.
                if (result != null)
                {

                    int KullaniciId = Convert.ToInt32(result);


                    KullaniciBilgi.KullaniciId = KullaniciId;
                    KullaniciBilgi.KullaniciAdi = Username;


                    AnaEkran anaEkran = new AnaEkran();
                    anaEkran.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("KAYIT BULUNAMADI!");
                }
            }
        }

        private void sifreYenileme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SifreYenile sifreYenile = new SifreYenile();
            sifreYenile.Show();
        }
    }
}
