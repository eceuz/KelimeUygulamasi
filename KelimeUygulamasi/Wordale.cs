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
    public partial class Wordle : Form
    {
        int aktifKullaniciId;

        SqlConnection cn = new SqlConnection("Server=.;Database=KelimeUygulamasi;Trusted_Connection=True;");

        int currentRow = 0;
        int maxTahmin = 6;
        string DogruKelime = "";
        TextBox[,] boxes = new TextBox[6, 5];//6 tahmin hakkı var herbiri 5 harfli

        public Wordle()

        {
            aktifKullaniciId = KullaniciBilgi.KullaniciId;

            InitializeComponent();
        }

        private void Wordale_Load(object sender, EventArgs e)
        {
            
            DogruKelime = KelimeCekme().ToUpper();
            TextBoxOlusturma(currentRow);

        }
        private string KelimeCekme()
        {
            //veritabanından 5 harfli rastgele kelime çekme
            string kelime = "";
            cn.Open();
            string query = "SELECT TOP 1 word FROM Kelimeler WHERE LEN(word)=5 ORDER BY NEWID()";
            SqlCommand cmd = new SqlCommand(query, cn);
            kelime = (string)cmd.ExecuteScalar();
            cn.Close();
            return kelime;

        }

        private void kontrol_btn_Click_1(object sender, EventArgs e)
        {
            //kullanıcının yazdığı kelimeyi harf harf konumuyla birlikte kontrol et

            string tahmin = "";
            for (int i = 0; i < 5; i++)
            {
                tahmin += boxes[currentRow, i].Text.ToUpper();
            }
            for (int i = 0; i < 5; i++)
            {
                char harf = tahmin[i];
                if (harf == DogruKelime[i])
                {
                    boxes[currentRow, i].BackColor = Color.Green;
                }
                else if (DogruKelime.Contains(harf))
                {
                    boxes[currentRow, i].BackColor = Color.Yellow;
                }
                else
                {
                    boxes[currentRow, i].BackColor = Color.Gray;
                }

                boxes[currentRow, i].ReadOnly = true;
            }

            if (tahmin == DogruKelime)
            {
                aciklama.Text = "Tebrikler!" +
                    " Doğru kelimeyi buldunuz.";
                aciklama.ForeColor = Color.Green;
                return;
            }

            currentRow++;

            if (currentRow == maxTahmin)
            {

                aciklama.Text = $"Oyun bitti! " +
                    $"Doğru kelime: {DogruKelime}";
                aciklama.ForeColor = Color.Red;
                return;
            }
            //yeni satır için kutucuk oluşturma
            TextBoxOlusturma(currentRow);

        }
        private void TextBoxOlusturma(int row)
        {
            for (int i = 0; i < 5; i++)
            {
                TextBox tb = new TextBox();
                tb.Width = 50;
                tb.Height = 50;
                tb.MaxLength = 1;
                tb.Font = new Font("Segoe UI", 20);
                tb.TextAlign = HorizontalAlignment.Center;
                tb.Location = new Point(50 + i * 50, 50 + row * 50);
                this.Controls.Add(tb);
                boxes[row, i] = tb;
            }
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
        }

        private void yeniden_Click(object sender, EventArgs e)
        {
            //onceki kutucukları temizle
            for (int i = 0; i < maxTahmin; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (boxes[i, j] != null)
                    {
                        this.Controls.Remove(boxes[i, j]);
                        boxes[i, j].Dispose();
                    }
                }
            }

            //diziyi sıfırla yeni kelime al ve ilk satırı tekrar oluştur
            boxes = new TextBox[6, 5]; 
            DogruKelime = KelimeCekme().ToUpper();
            currentRow = 0;
            aciklama.Text = "";
            aciklama.ForeColor = Color.Black;

            TextBoxOlusturma(currentRow);
        }

    }

}

