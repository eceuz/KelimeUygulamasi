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
    public partial class KayitOl : Form
    {
       
        String connectionString = "Data Source=.;Initial Catalog=kelimeUygulamasi;Integrated Security=True ";
        public KayitOl()
        {
            InitializeComponent();
        }

        private void giris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            girisEkran giris = new girisEkran();
            giris.Show();
        }

        private void kayit_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))

            {
                //parolalar eşleşiyorsa veritabanına kaydediyor.
                if (parola.Text == parola_tekrar.Text)
                {
                    cn.Open();
                    string query = "INSERT INTO Kullanicilar (name,surname,username,Email,password) VALUES(@name,@surname,@username,@Email,@password)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@name", isim.Text);
                    cmd.Parameters.AddWithValue("@surname", soyisim.Text);
                    cmd.Parameters.AddWithValue("@username", kullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@Email", eposta.Text);
                    cmd.Parameters.AddWithValue("@password", parola.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarılı");

                    cn.Close();

                    this.Close();
                    girisEkran Giris = new girisEkran();
                    Giris.Show();
              }
                else
                    MessageBox.Show("Girdiğiniz şifreler aynı değil.");




            }
        }
    }
}
