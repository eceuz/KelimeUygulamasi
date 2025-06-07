namespace KelimeUygulamasi
{
    partial class Wordle
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
            aciklama = new Label();
            cikis_btn = new Button();
            yeniden = new Button();
            kontrol_btn = new Button();
            SuspendLayout();
            // 
            // aciklama
            // 
            aciklama.AutoSize = true;
            aciklama.Location = new Point(63, 427);
            aciklama.Name = "aciklama";
            aciklama.Size = new Size(0, 20);
            aciklama.TabIndex = 1;
            aciklama.TextAlign = ContentAlignment.TopCenter;
            // 
            // cikis_btn
            // 
            cikis_btn.Location = new Point(111, 455);
            cikis_btn.Name = "cikis_btn";
            cikis_btn.Size = new Size(94, 29);
            cikis_btn.TabIndex = 2;
            cikis_btn.Text = "çıkış";
            cikis_btn.UseVisualStyleBackColor = true;
            cikis_btn.Click += cikis_btn_Click;
            // 
            // yeniden
            // 
            yeniden.Location = new Point(211, 455);
            yeniden.Name = "yeniden";
            yeniden.Size = new Size(94, 29);
            yeniden.TabIndex = 3;
            yeniden.Text = "tekrar oyna";
            yeniden.UseVisualStyleBackColor = true;
            yeniden.Click += yeniden_Click;
            // 
            // kontrol_btn
            // 
            kontrol_btn.Location = new Point(165, 388);
            kontrol_btn.Name = "kontrol_btn";
            kontrol_btn.Size = new Size(94, 29);
            kontrol_btn.TabIndex = 4;
            kontrol_btn.Text = "Kontrol Et";
            kontrol_btn.UseVisualStyleBackColor = true;
            kontrol_btn.Click += kontrol_btn_Click_1;
            // 
            // Wordle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 181, 208);
            ClientSize = new Size(434, 554);
            Controls.Add(kontrol_btn);
            Controls.Add(yeniden);
            Controls.Add(cikis_btn);
            Controls.Add(aciklama);
            Name = "Wordle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wordle";
            Load += Wordale_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label aciklama;
        private Button cikis_btn;
        private Button yeniden;
        private Button kontrol_btn;
    }
}