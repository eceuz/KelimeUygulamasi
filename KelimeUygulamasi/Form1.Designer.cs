
namespace KelimeUygulamasi
{
    partial class Quiz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_gec = new Button();
            kontrol = new Label();
            btn_kontrol = new Button();
            ingilizceAnlam = new TextBox();
            turkceKelime = new Label();
            pictureBox = new PictureBox();
            cikis_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 181, 208);
            panel1.Controls.Add(btn_gec);
            panel1.Controls.Add(kontrol);
            panel1.Controls.Add(btn_kontrol);
            panel1.Controls.Add(ingilizceAnlam);
            panel1.Controls.Add(turkceKelime);
            panel1.Controls.Add(pictureBox);
            panel1.Location = new Point(53, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 471);
            panel1.TabIndex = 0;
          
            // 
            // btn_gec
            // 
            btn_gec.BackColor = SystemColors.ControlLight;
            btn_gec.Location = new Point(153, 366);
            btn_gec.Name = "btn_gec";
            btn_gec.Size = new Size(94, 29);
            btn_gec.TabIndex = 5;
            btn_gec.Text = "geç";
            btn_gec.UseVisualStyleBackColor = false;
            btn_gec.Click += btn_gec_Click;
            // 
            // kontrol
            // 
            kontrol.AutoSize = true;
            kontrol.Location = new Point(53, 343);
            kontrol.Name = "kontrol";
            kontrol.Size = new Size(0, 20);
            kontrol.TabIndex = 4;
            // 
            // btn_kontrol
            // 
            btn_kontrol.BackColor = SystemColors.ControlLight;
            btn_kontrol.Location = new Point(53, 366);
            btn_kontrol.Name = "btn_kontrol";
            btn_kontrol.Size = new Size(94, 29);
            btn_kontrol.TabIndex = 3;
            btn_kontrol.Text = "kontrol et";
            btn_kontrol.UseVisualStyleBackColor = false;
            btn_kontrol.Click += btn_kontrol_Click;
            // 
            // ingilizceAnlam
            // 
            ingilizceAnlam.BackColor = SystemColors.InactiveBorder;
            ingilizceAnlam.Location = new Point(53, 281);
            ingilizceAnlam.Name = "ingilizceAnlam";
            ingilizceAnlam.Size = new Size(206, 27);
            ingilizceAnlam.TabIndex = 2;
            // 
            // turkceKelime
            // 
            turkceKelime.AutoSize = true;
            turkceKelime.Location = new Point(128, 232);
            turkceKelime.Name = "turkceKelime";
            turkceKelime.Size = new Size(0, 20);
            turkceKelime.TabIndex = 1;
           
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(81, 41);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(153, 149);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
    
            // 
            // cikis_btn
            // 
            cikis_btn.BackColor = Color.FromArgb(224, 224, 224);
            cikis_btn.Location = new Point(161, 513);
            cikis_btn.Name = "cikis_btn";
            cikis_btn.Size = new Size(88, 33);
            cikis_btn.TabIndex = 1;
            cikis_btn.Text = "çıkış";
            cikis_btn.UseVisualStyleBackColor = false;
            cikis_btn.Click += cikis_btn_Click;
            // 
            // Quiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 117, 166);
            ClientSize = new Size(438, 558);
            Controls.Add(cikis_btn);
            Controls.Add(panel1);
            Name = "Quiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz";
           
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Label kontrol;
        private Button btn_kontrol;
        private TextBox ingilizceAnlam;
        private Label turkceKelime;
        private PictureBox pictureBox;
        private Button btn_gec;
        private Button cikis_btn;
    }
}
