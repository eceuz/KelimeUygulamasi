using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;
using MaxMind.Db;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;






namespace KelimeUygulamasi
{
    public partial class Quiz : Form
    {
        int aktifKullaniciId;

        SqlConnection cn = new SqlConnection("Server=.;Database=KelimeUygulamasi;Trusted_Connection=True;");

        List<Kelime> kelimeler = new List<Kelime>();//kelimeler çekiliyor
        public Quiz()
        {
            aktifKullaniciId = KullaniciBilgi.KullaniciId;//giris yapan kullaniciyi aliyoruz
            InitializeComponent();
            Kelimeler();
            Gorsel();



        }
        public void Kelimeler()
        {

            kelimeler.Clear();
            cn.Open();
            int soruSayisi = Properties.Settings1.Default.QuizSoruSayisi;//kullanicinin deðiþtirdiði soru sayýsý 

            //6 tekrar prensibine göre sorularý seçiyor
            string query = $@"
       SELECT TOP {soruSayisi} k.Id, k.word, k.translation, k.gorselURL
FROM Kelimeler k
LEFT JOIN BilinenKelimeler bk ON bk.KelimeId = k.Id AND bk.KullaniciId = @kId
WHERE 
    bk.BilmeSayisi IS NULL
    OR (
        bk.BilmeSayisi = 1 AND DATEADD(DAY, 1, bk.SonTekrarTarihi) <= GETDATE()
    )
    OR (
        bk.BilmeSayisi = 2 AND DATEADD(DAY, 7, bk.SonTekrarTarihi) <= GETDATE()
    )
    OR (
        bk.BilmeSayisi = 3 AND DATEADD(DAY, 30, bk.SonTekrarTarihi) <= GETDATE()
    )
    OR (
        bk.BilmeSayisi = 4 AND DATEADD(DAY, 90, bk.SonTekrarTarihi) <= GETDATE()
    )
    OR (
        bk.BilmeSayisi = 5 AND DATEADD(DAY, 180, bk.SonTekrarTarihi) <= GETDATE()
    )
    OR (
        bk.BilmeSayisi = 6 AND DATEADD(DAY, 365, bk.SonTekrarTarihi) <= GETDATE()
    )
ORDER BY NEWID()
";

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@kId", aktifKullaniciId);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Kelime k = new Kelime();
                k.Id = Convert.ToInt32(reader["Id"]);
                k.Ingilizce = reader["word"].ToString();
                k.Turkce = reader["translation"].ToString();
                k.GorselURL = reader["gorselURL"].ToString();
                kelimeler.Add(k);
            }


            reader.Close();
            cn.Close();
        }

        int currentIndex = 0;
        public void Gorsel()

        {

            if (kelimeler.Count > 0 && currentIndex < kelimeler.Count)
            {
                try
                {
                    pictureBox.Load(kelimeler[currentIndex].GorselURL);

                }
                catch
                {
                    MessageBox.Show("Resim yüklenemedi.");
                }
                turkceKelime.Text = kelimeler[currentIndex].Turkce;
            }
        }

     

        private void btn_gec_Click(object sender, EventArgs e)
        {
          //diðer kelimeye geçiyor
            currentIndex++;
            if (currentIndex < kelimeler.Count)
            {
                Gorsel();
                ingilizceAnlam.Text = "";
                kontrol.Text = "";
            }
            else
            {
                MessageBox.Show("Quiz tamamlandý!");
                this.Hide();
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();
            }


        }

        private void btn_kontrol_Click(object sender, EventArgs e)
        {

            //verilen cevabýn doðruluðu kontrol ediliyor
            if (currentIndex < kelimeler.Count)
            {
                string girilenCevap = ingilizceAnlam.Text.Trim().ToLower();
                string dogruCevap = kelimeler[currentIndex].Ingilizce.Trim().ToLower();
                int kelimeId = kelimeler[currentIndex].Id;


                if (girilenCevap == dogruCevap)
                {
                    kontrol.Text = "Doðru cevap!";
                    kontrol.ForeColor = Color.Green;
                    GuncelleVeyaEkleKelime(kelimeId, true);

                }
                else
                {
                    kontrol.Text = "Yanlýþ cevap!";
                    kontrol.ForeColor = Color.Red;

                }

            }

        }

      
        private void GuncelleVeyaEkleKelime(int kelimeId, bool dogru)
        {
            cn.Open();
            //kullanicinin bildiði kelimeleri kaydediyor
            string updateQuery = @"
        IF EXISTS (SELECT 1 FROM BilinenKelimeler WHERE KullaniciId = @kullaniciId AND KelimeId = @kelimeId)
        BEGIN
            UPDATE BilinenKelimeler
            SET 
                BilmeSayisi = CASE 
                                    WHEN @dogru = 1 AND BilmeSayisi < 6 THEN BilmeSayisi + 1
                                    ELSE BilmeSayisi
                                END,
                SonTekrarTarihi = GETDATE()
            WHERE KullaniciId = @kullaniciId AND KelimeId = @kelimeId
        END
        ELSE
        BEGIN
            INSERT INTO BilinenKelimeler (KullaniciId, KelimeId, BilmeSayisi, SonTekrarTarihi)
            VALUES (@kullaniciId, @kelimeId, CASE WHEN @dogru = 1 THEN 1 ELSE 0 END, GETDATE())
        END
    ";

            SqlCommand cmd = new SqlCommand(updateQuery, cn);
            cmd.Parameters.AddWithValue("@kullaniciId", aktifKullaniciId);
            cmd.Parameters.AddWithValue("@kelimeId", kelimeId);
            cmd.Parameters.AddWithValue("@dogru", dogru ? 1 : 0);
            cmd.ExecuteNonQuery();

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
    




