namespace KelimeUygulamasi
{
    partial class SifreYenile
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
            txt_eposta = new TextBox();
            label1 = new Label();
            btn_guncelle = new Button();
            label2 = new Label();
            label3 = new Label();
            txt_parolaTekrar = new TextBox();
            txt_parola = new TextBox();
            btn_dogrula = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txt_eposta
            // 
            txt_eposta.Location = new Point(115, 96);
            txt_eposta.Name = "txt_eposta";
            txt_eposta.Size = new Size(203, 27);
            txt_eposta.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 73);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 7;
            label1.Text = "Lütfen e-postanızı giriniz";
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(133, 377);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(154, 28);
            btn_guncelle.TabIndex = 2;
            btn_guncelle.Text = "Şifreyi Yenile";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 205);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 7;
            label2.Text = "Yeni parola";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 276);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 7;
            label3.Text = "Yeni parola tekrar";
            // 
            // txt_parolaTekrar
            // 
            txt_parolaTekrar.Location = new Point(115, 299);
            txt_parolaTekrar.Name = "txt_parolaTekrar";
            txt_parolaTekrar.PasswordChar = '●';
            txt_parolaTekrar.Size = new Size(203, 27);
            txt_parolaTekrar.TabIndex = 5;
            // 
            // txt_parola
            // 
            txt_parola.Location = new Point(115, 228);
            txt_parola.Name = "txt_parola";
            txt_parola.PasswordChar = '●';
            txt_parola.Size = new Size(203, 27);
            txt_parola.TabIndex = 6;
            // 
            // btn_dogrula
            // 
            btn_dogrula.Location = new Point(140, 144);
            btn_dogrula.Name = "btn_dogrula";
            btn_dogrula.Size = new Size(159, 29);
            btn_dogrula.TabIndex = 8;
            btn_dogrula.Text = "Doğrula";
            btn_dogrula.UseVisualStyleBackColor = true;
            btn_dogrula.Click += btn_dogrula_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(147, 30);
            label4.Name = "label4";
            label4.Size = new Size(152, 31);
            label4.TabIndex = 9;
            label4.Text = "Şifreyi  Sıfırla";
            // 
            // SifreYenile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 181, 208);
            ClientSize = new Size(438, 558);
            Controls.Add(label4);
            Controls.Add(btn_dogrula);
            Controls.Add(txt_parola);
            Controls.Add(txt_parolaTekrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_guncelle);
            Controls.Add(label1);
            Controls.Add(txt_eposta);
            Name = "SifreYenile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SifreYenile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_eposta;
        private Label label1;
        private Button btn_guncelle;
        private Label label2;
        private Label label3;
        private TextBox txt_parolaTekrar;
        private TextBox txt_parola;
        private Button btn_dogrula;
        private Label label4;
    }
}