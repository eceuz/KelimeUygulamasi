namespace KelimeUygulamasi
{
    partial class Istatistik
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
            groupBox1 = new GroupBox();
            ogrenilenler = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            ogrenmeAsamasinda = new FlowLayoutPanel();
            cikis_btn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ogrenilenler);
            groupBox1.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 222);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenilen Kelimeler";
            // 
            // ogrenilenler
            // 
            ogrenilenler.AutoScroll = true;
            ogrenilenler.FlowDirection = FlowDirection.TopDown;
            ogrenilenler.Font = new Font("Arial Narrow", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            ogrenilenler.Location = new Point(6, 39);
            ogrenilenler.Name = "ogrenilenler";
            ogrenilenler.Size = new Size(182, 177);
            ogrenilenler.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ogrenmeAsamasinda);
            groupBox2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(224, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(202, 222);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Öğrenme Aşamasındaki Kelimeler";
            // 
            // ogrenmeAsamasinda
            // 
            ogrenmeAsamasinda.AutoScroll = true;
            ogrenmeAsamasinda.FlowDirection = FlowDirection.TopDown;
            ogrenmeAsamasinda.Font = new Font("Arial Narrow", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            ogrenmeAsamasinda.Location = new Point(6, 39);
            ogrenmeAsamasinda.Name = "ogrenmeAsamasinda";
            ogrenmeAsamasinda.Size = new Size(190, 177);
            ogrenmeAsamasinda.TabIndex = 0;
            ogrenmeAsamasinda.WrapContents = false;
            // 
            // cikis_btn
            // 
            cikis_btn.Location = new Point(170, 426);
            cikis_btn.Name = "cikis_btn";
            cikis_btn.Size = new Size(94, 29);
            cikis_btn.TabIndex = 2;
            cikis_btn.Text = "Çıkış";
            cikis_btn.UseVisualStyleBackColor = true;
            cikis_btn.Click += cikis_btn_Click;
            // 
            // Istatistik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 181, 208);
            ClientSize = new Size(438, 558);
            Controls.Add(cikis_btn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "Istatistik";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Istatistik";
            Load += Istatistik_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private FlowLayoutPanel ogrenilenler;
        private GroupBox groupBox2;
        private FlowLayoutPanel ogrenmeAsamasinda;
        private Button cikis_btn;
    }
}