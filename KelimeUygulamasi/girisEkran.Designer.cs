namespace KelimeUygulamasi
{
    partial class girisEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisEkran));
            giris_btn = new Button();
            kullaniciAdi = new TextBox();
            parola = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            sifreYenileme = new LinkLabel();
            kayit = new LinkLabel();
            SuspendLayout();
            // 
            // giris_btn
            // 
            giris_btn.Cursor = Cursors.Hand;
            giris_btn.Location = new Point(61, 314);
            giris_btn.Name = "giris_btn";
            giris_btn.Size = new Size(108, 29);
            giris_btn.TabIndex = 0;
            giris_btn.Text = "GİRİŞ";
            giris_btn.UseVisualStyleBackColor = true;
            giris_btn.Click += giris_btn_Click;
            // 
            // kullaniciAdi
            // 
            kullaniciAdi.Location = new Point(45, 216);
            kullaniciAdi.Name = "kullaniciAdi";
            kullaniciAdi.Size = new Size(150, 27);
            kullaniciAdi.TabIndex = 1;
            // 
            // parola
            // 
            parola.Location = new Point(45, 272);
            parola.Name = "parola";
            parola.Size = new Size(150, 27);
            parola.TabIndex = 2;
            parola.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 181, 208);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(45, 179);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 181, 208);
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(45, 246);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 4;
            label2.Text = "Parola";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(245, 199, 226);
            label3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(61, 39);
            label3.Name = "label3";
            label3.Size = new Size(307, 69);
            label3.TabIndex = 5;
            label3.Text = "KELİMEM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(242, 181, 208);
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 362);
            label4.Name = "label4";
            label4.Size = new Size(129, 17);
            label4.TabIndex = 6;
            label4.Text = "Parolayı mı unuttun ?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(242, 181, 208);
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(12, 403);
            label5.Name = "label5";
            label5.Size = new Size(111, 17);
            label5.TabIndex = 7;
            label5.Text = "Hesabın yok mu ?";
            // 
            // sifreYenileme
            // 
            sifreYenileme.AutoSize = true;
            sifreYenileme.BackColor = Color.FromArgb(242, 181, 208);
            sifreYenileme.Cursor = Cursors.Hand;
            sifreYenileme.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            sifreYenileme.Location = new Point(147, 362);
            sifreYenileme.Name = "sifreYenileme";
            sifreYenileme.Size = new Size(34, 17);
            sifreYenileme.TabIndex = 8;
            sifreYenileme.TabStop = true;
            sifreYenileme.Text = "Tıkla";
            sifreYenileme.LinkClicked += sifreYenileme_LinkClicked;
            // 
            // kayit
            // 
            kayit.AutoSize = true;
            kayit.BackColor = Color.FromArgb(242, 181, 208);
            kayit.Cursor = Cursors.Hand;
            kayit.Font = new Font("Segoe UI", 8F);
            kayit.Location = new Point(138, 403);
            kayit.Name = "kayit";
            kayit.Size = new Size(57, 19);
            kayit.TabIndex = 9;
            kayit.TabStop = true;
            kayit.Text = "Kayıt Ol";
            kayit.LinkClicked += kayit_LinkClicked;
            // 
            // girisEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(438, 558);
            Controls.Add(kayit);
            Controls.Add(sifreYenileme);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(parola);
            Controls.Add(kullaniciAdi);
            Controls.Add(giris_btn);
            Name = "girisEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "girisEkran";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button giris_btn;
        private TextBox kullaniciAdi;
        private TextBox parola;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel sifreYenileme;
        private LinkLabel kayit;
    }
}