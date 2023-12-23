namespace VeterinerOtomasyonu
{
    partial class MusteriPanel
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
            this.btnRandevuIslemleri = new System.Windows.Forms.Button();
            this.btnEvcilHayvanEkle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMusteriKisiselBilgi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandevuIslemleri
            // 
            this.btnRandevuIslemleri.Location = new System.Drawing.Point(117, 114);
            this.btnRandevuIslemleri.Name = "btnRandevuIslemleri";
            this.btnRandevuIslemleri.Size = new System.Drawing.Size(260, 136);
            this.btnRandevuIslemleri.TabIndex = 0;
            this.btnRandevuIslemleri.Text = "  Randevu İşlemleri";
            this.btnRandevuIslemleri.UseVisualStyleBackColor = true;
            this.btnRandevuIslemleri.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEvcilHayvanEkle
            // 
            this.btnEvcilHayvanEkle.Location = new System.Drawing.Point(404, 275);
            this.btnEvcilHayvanEkle.Name = "btnEvcilHayvanEkle";
            this.btnEvcilHayvanEkle.Size = new System.Drawing.Size(260, 136);
            this.btnEvcilHayvanEkle.TabIndex = 1;
            this.btnEvcilHayvanEkle.Text = "Evcil Hayvan Ekle";
            this.btnEvcilHayvanEkle.UseVisualStyleBackColor = true;
            this.btnEvcilHayvanEkle.Click += new System.EventHandler(this.btnEvcilHayvanEkle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 136);
            this.button3.TabIndex = 2;
            this.button3.Text = "Geçmiş Muayeneler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMusteriKisiselBilgi
            // 
            this.btnMusteriKisiselBilgi.Location = new System.Drawing.Point(117, 275);
            this.btnMusteriKisiselBilgi.Name = "btnMusteriKisiselBilgi";
            this.btnMusteriKisiselBilgi.Size = new System.Drawing.Size(260, 136);
            this.btnMusteriKisiselBilgi.TabIndex = 3;
            this.btnMusteriKisiselBilgi.Text = "Kişisel Bilgilerini Düzenle\r\n\r\n";
            this.btnMusteriKisiselBilgi.UseVisualStyleBackColor = true;
            this.btnMusteriKisiselBilgi.Click += new System.EventHandler(this.btnMusteriKisiselBilgi_Click);
            // 
            // MusteriPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 532);
            this.Controls.Add(this.btnMusteriKisiselBilgi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEvcilHayvanEkle);
            this.Controls.Add(this.btnRandevuIslemleri);
            this.Name = "MusteriPanel";
            this.Text = "MusteriPanel";
            this.Load += new System.EventHandler(this.MusteriPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandevuIslemleri;
        private System.Windows.Forms.Button btnEvcilHayvanEkle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMusteriKisiselBilgi;
    }
}