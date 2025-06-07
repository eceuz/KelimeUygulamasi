namespace KelimeUygulamasi
{
    partial class KayitOl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kayit_btn = new Button();
            isim = new TextBox();
            soyisim = new TextBox();
            kullaniciAdi = new TextBox();
            eposta = new TextBox();
            parola = new TextBox();
            parola_tekrar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            giris = new LinkLabel();
            SuspendLayout();
            // 
            // kayit_btn
            // 
            kayit_btn.Cursor = Cursors.Hand;
            kayit_btn.Location = new Point(165, 438);
            kayit_btn.Name = "kayit_btn";
            kayit_btn.Size = new Size(94, 29);
            kayit_btn.TabIndex = 0;
            kayit_btn.Text = "Kayıt Ol";
            kayit_btn.UseVisualStyleBackColor = true;
            kayit_btn.Click += kayit_btn_Click;
            // 
            // isim
            // 
            isim.Location = new Point(118, 126);
            isim.Name = "isim";
            isim.Size = new Size(191, 27);
            isim.TabIndex = 1;
            // 
            // soyisim
            // 
            soyisim.Location = new Point(118, 179);
            soyisim.Name = "soyisim";
            soyisim.Size = new Size(191, 27);
            soyisim.TabIndex = 2;
            // 
            // kullaniciAdi
            // 
            kullaniciAdi.Location = new Point(118, 232);
            kullaniciAdi.Name = "kullaniciAdi";
            kullaniciAdi.Size = new Size(191, 27);
            kullaniciAdi.TabIndex = 3;
            // 
            // eposta
            // 
            eposta.Location = new Point(118, 285);
            eposta.Name = "eposta";
            eposta.Size = new Size(191, 27);
            eposta.TabIndex = 4;
            // 
            // parola
            // 
            parola.Location = new Point(118, 338);
            parola.Name = "parola";
            parola.Size = new Size(191, 27);
            parola.TabIndex = 5;
            parola.UseSystemPasswordChar = true;
            // 
            // parola_tekrar
            // 
            parola_tekrar.Location = new Point(118, 391);
            parola_tekrar.Name = "parola_tekrar";
            parola_tekrar.Size = new Size(191, 27);
            parola_tekrar.TabIndex = 6;
            parola_tekrar.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 103);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 7;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 156);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 209);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 9;
            label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 262);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 10;
            label4.Text = "E-posta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 315);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "Parola";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 368);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 12;
            label6.Text = "Parola tekrar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.Location = new Point(71, 21);
            label7.Name = "label7";
            label7.Size = new Size(307, 69);
            label7.TabIndex = 13;
            label7.Text = "KELİMEM";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F);
            label8.Location = new Point(127, 488);
            label8.Name = "label8";
            label8.Size = new Size(110, 19);
            label8.TabIndex = 14;
            label8.Text = "Hesabın var mı ?";
            // 
            // giris
            // 
            giris.AutoSize = true;
            giris.Cursor = Cursors.Hand;
            giris.Font = new Font("Segoe UI", 8F);
            giris.Location = new Point(243, 488);
            giris.Name = "giris";
            giris.Size = new Size(62, 19);
            giris.TabIndex = 15;
            giris.TabStop = true;
            giris.Text = "Giriş yap";
            giris.LinkClicked += giris_LinkClicked;
            // 
            // KayitOl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 181, 208);
            ClientSize = new Size(438, 558);
            Controls.Add(giris);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(parola_tekrar);
            Controls.Add(parola);
            Controls.Add(eposta);
            Controls.Add(kullaniciAdi);
            Controls.Add(soyisim);
            Controls.Add(isim);
            Controls.Add(kayit_btn);
            Name = "KayitOl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KayitOl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button kayit_btn;
        private TextBox isim;
        private TextBox soyisim;
        private TextBox kullaniciAdi;
        private TextBox eposta;
        private TextBox parola;
        private TextBox parola_tekrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private LinkLabel giris;
    }
}