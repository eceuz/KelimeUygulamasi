namespace KelimeUygulamasi
{
    partial class Ayarlar
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
            SoruSayisi_lbl = new Label();
            SoruSayisi = new NumericUpDown();
            kaydet_btn = new Button();
            cikis_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)SoruSayisi).BeginInit();
            SuspendLayout();
            // 
            // SoruSayisi_lbl
            // 
            SoruSayisi_lbl.AutoSize = true;
            SoruSayisi_lbl.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            SoruSayisi_lbl.Location = new Point(88, 92);
            SoruSayisi_lbl.Name = "SoruSayisi_lbl";
            SoruSayisi_lbl.Size = new Size(256, 32);
            SoruSayisi_lbl.TabIndex = 0;
            SoruSayisi_lbl.Text = "Soru Sayısı Seçiniz";
            // 
            // SoruSayisi
            // 
            SoruSayisi.BackColor = Color.FromArgb(255, 192, 255);
            SoruSayisi.Location = new Point(88, 170);
            SoruSayisi.Name = "SoruSayisi";
            SoruSayisi.Size = new Size(150, 27);
            SoruSayisi.TabIndex = 1;
            // 
            // kaydet_btn
            // 
            kaydet_btn.Location = new Point(266, 170);
            kaydet_btn.Name = "kaydet_btn";
            kaydet_btn.Size = new Size(94, 29);
            kaydet_btn.TabIndex = 2;
            kaydet_btn.Text = "Kaydet";
            kaydet_btn.UseVisualStyleBackColor = true;
            kaydet_btn.Click += kaydet_btn_Click;
            // 
            // cikis_btn
            // 
            cikis_btn.Location = new Point(163, 307);
            cikis_btn.Name = "cikis_btn";
            cikis_btn.Size = new Size(94, 29);
            cikis_btn.TabIndex = 3;
            cikis_btn.Text = "Çıkış";
            cikis_btn.UseVisualStyleBackColor = true;
            cikis_btn.Click += cikis_btn_Click;
            // 
            // Ayarlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 181, 208);
            ClientSize = new Size(438, 558);
            Controls.Add(cikis_btn);
            Controls.Add(kaydet_btn);
            Controls.Add(SoruSayisi);
            Controls.Add(SoruSayisi_lbl);
            Name = "Ayarlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ayarlar";
            ((System.ComponentModel.ISupportInitialize)SoruSayisi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SoruSayisi_lbl;
        private NumericUpDown SoruSayisi;
        private Button kaydet_btn;
        private Button cikis_btn;
    }
}