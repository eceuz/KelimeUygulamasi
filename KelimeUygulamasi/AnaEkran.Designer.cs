namespace KelimeUygulamasi
{
    partial class AnaEkran
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
            panel1 = new Panel();
            cikis_btn = new Button();
            istatistik_btn = new Button();
            quiz_btn = new Button();
            wordle_btn = new Button();
            ayarlar_btn = new Button();
            hosgeldin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 181, 208);
            panel1.Controls.Add(cikis_btn);
            panel1.Controls.Add(istatistik_btn);
            panel1.Controls.Add(quiz_btn);
            panel1.Controls.Add(wordle_btn);
            panel1.Controls.Add(ayarlar_btn);
            panel1.Location = new Point(23, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 475);
            panel1.TabIndex = 0;
            // 
            // cikis_btn
            // 
            cikis_btn.Cursor = Cursors.Hand;
            cikis_btn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cikis_btn.Location = new Point(135, 430);
            cikis_btn.Name = "cikis_btn";
            cikis_btn.Size = new Size(112, 31);
            cikis_btn.TabIndex = 5;
            cikis_btn.Text = "ÇIKIŞ";
            cikis_btn.UseVisualStyleBackColor = true;
            cikis_btn.Click += cikis_btn_Click;
            // 
            // istatistik_btn
            // 
            istatistik_btn.BackgroundImage = Properties.Resources.Ekran_görüntüsü_2025_05_10_000702;
            istatistik_btn.BackgroundImageLayout = ImageLayout.Stretch;
            istatistik_btn.Cursor = Cursors.Hand;
            istatistik_btn.Location = new Point(205, 240);
            istatistik_btn.Name = "istatistik_btn";
            istatistik_btn.Size = new Size(170, 170);
            istatistik_btn.TabIndex = 4;
            istatistik_btn.UseVisualStyleBackColor = true;
            istatistik_btn.Click += istatistik_btn_Click;
            // 
            // quiz_btn
            // 
            quiz_btn.BackgroundImage = Properties.Resources.Ekran_görüntüsü_2025_05_10_000533;
            quiz_btn.BackgroundImageLayout = ImageLayout.Stretch;
            quiz_btn.Cursor = Cursors.Hand;
            quiz_btn.Location = new Point(18, 45);
            quiz_btn.Name = "quiz_btn";
            quiz_btn.Size = new Size(170, 170);
            quiz_btn.TabIndex = 3;
            quiz_btn.UseVisualStyleBackColor = true;
            quiz_btn.Click += quiz_btn_Click;
            // 
            // wordle_btn
            // 
            wordle_btn.BackgroundImage = Properties.Resources.Ekran_görüntüsü_2025_05_10_000602;
            wordle_btn.BackgroundImageLayout = ImageLayout.Stretch;
            wordle_btn.Cursor = Cursors.Hand;
            wordle_btn.Location = new Point(205, 45);
            wordle_btn.Name = "wordle_btn";
            wordle_btn.Size = new Size(170, 170);
            wordle_btn.TabIndex = 2;
            wordle_btn.UseVisualStyleBackColor = true;
            wordle_btn.Click += wordle_btn_Click;
            // 
            // ayarlar_btn
            // 
            ayarlar_btn.BackgroundImage = Properties.Resources.Ekran_görüntüsü_2025_05_10_000739;
            ayarlar_btn.BackgroundImageLayout = ImageLayout.Stretch;
            ayarlar_btn.Cursor = Cursors.Hand;
            ayarlar_btn.Location = new Point(18, 240);
            ayarlar_btn.Name = "ayarlar_btn";
            ayarlar_btn.Size = new Size(170, 170);
            ayarlar_btn.TabIndex = 1;
            ayarlar_btn.UseVisualStyleBackColor = true;
            ayarlar_btn.Click += ayarlar_btn_Click;
            // 
            // hosgeldin
            // 
            hosgeldin.AutoSize = true;
            hosgeldin.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            hosgeldin.Location = new Point(61, 14);
            hosgeldin.Name = "hosgeldin";
            hosgeldin.Size = new Size(0, 29);
            hosgeldin.TabIndex = 0;
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 117, 166);
            ClientSize = new Size(438, 558);
            Controls.Add(panel1);
            Controls.Add(hosgeldin);
            Name = "AnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaEkran";
            Load += AnaEkran_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button istatistik_btn;
        private Button quiz_btn;
        private Button wordle_btn;
        private Button ayarlar_btn;
        private Label hosgeldin;
        private Button cikis_btn;
    }
}