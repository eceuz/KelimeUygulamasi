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
    public partial class Istatistik : Form
    {
        int aktifKullaniciId;

        SqlConnection cn = new SqlConnection("Server=.;Database=KelimeUygulamasi;Trusted_Connection=True;");
        public Istatistik()
        {
            InitializeComponent();
            aktifKullaniciId = KullaniciBilgi.KullaniciId;
        }

        private void Istatistik_Load(object sender, EventArgs e)
        {

            cn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT bk.BilmeSayisi, k.word AS Kelime
FROM BilinenKelimeler bk
JOIN Kelimeler k ON bk.KelimeId = k.Id
WHERE bk.KullaniciId = @id", cn);
            cmd.Parameters.AddWithValue("@id", KullaniciBilgi.KullaniciId);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string kelime = dr["Kelime"].ToString();
                int sayi = Convert.ToInt32(dr["BilmeSayisi"]);

                Label lbl = new Label();
                lbl.Text = $"{kelime} - {sayi} kez bilindi";
                lbl.AutoSize = true;

                if (sayi >= 6)
                    ogrenilenler.Controls.Add(lbl);
                else
                    ogrenmeAsamasinda.Controls.Add(lbl);
            }

            dr.Close();
            cn.Close();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
        }
    }
}

