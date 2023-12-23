namespace VeterinerOtomasyonu
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            this.projeDatabaseDataSet = new VeterinerOtomasyonu.ProjeDatabaseDataSet();
            this.adminGirisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminGirisTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSetTableAdapters.AdminGirisTableAdapter();
            this.hayvanBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hayvanBilgiTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSetTableAdapters.HayvanBilgiTableAdapter();
            this.musteriHayvanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteri_HayvanTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSetTableAdapters.Musteri_HayvanTableAdapter();
            this.müşteriGirisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.müşteriGirisTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSetTableAdapters.MüşteriGirisTableAdapter();
            this.btnKullanıcıEkleSil = new System.Windows.Forms.Button();
            this.btnAdminEkleSil = new System.Windows.Forms.Button();
            this.btnVetEkleSil = new System.Windows.Forms.Button();
            this.btnMusteriveHayvan = new System.Windows.Forms.Button();
            this.btnRandevularıGoster = new System.Windows.Forms.Button();
            this.btnGecmisMuayeneKayıtlari = new System.Windows.Forms.Button();
            this.btnFaturaOlustur = new System.Windows.Forms.Button();
            this.btnMuayeOlustur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminGirisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriHayvanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriGirisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projeDatabaseDataSet
            // 
            this.projeDatabaseDataSet.DataSetName = "ProjeDatabaseDataSet";
            this.projeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminGirisBindingSource
            // 
            this.adminGirisBindingSource.DataMember = "AdminGiris";
            this.adminGirisBindingSource.DataSource = this.projeDatabaseDataSet;
            // 
            // adminGirisTableAdapter
            // 
            this.adminGirisTableAdapter.ClearBeforeFill = true;
            // 
            // hayvanBilgiBindingSource
            // 
            this.hayvanBilgiBindingSource.DataMember = "HayvanBilgi";
            this.hayvanBilgiBindingSource.DataSource = this.projeDatabaseDataSet;
            // 
            // hayvanBilgiTableAdapter
            // 
            this.hayvanBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // musteriHayvanBindingSource
            // 
            this.musteriHayvanBindingSource.DataMember = "Musteri_Hayvan";
            this.musteriHayvanBindingSource.DataSource = this.projeDatabaseDataSet;
            // 
            // musteri_HayvanTableAdapter
            // 
            this.musteri_HayvanTableAdapter.ClearBeforeFill = true;
            // 
            // müşteriGirisBindingSource
            // 
            this.müşteriGirisBindingSource.DataMember = "MüşteriGiris";
            this.müşteriGirisBindingSource.DataSource = this.projeDatabaseDataSet;
            // 
            // müşteriGirisTableAdapter
            // 
            this.müşteriGirisTableAdapter.ClearBeforeFill = true;
            // 
            // btnKullanıcıEkleSil
            // 
            this.btnKullanıcıEkleSil.Location = new System.Drawing.Point(164, 63);
            this.btnKullanıcıEkleSil.Name = "btnKullanıcıEkleSil";
            this.btnKullanıcıEkleSil.Size = new System.Drawing.Size(143, 116);
            this.btnKullanıcıEkleSil.TabIndex = 0;
            this.btnKullanıcıEkleSil.Text = "Kullanıcı Ekle/Sil";
            this.btnKullanıcıEkleSil.UseVisualStyleBackColor = true;
            this.btnKullanıcıEkleSil.Click += new System.EventHandler(this.btnKullanıcıEkleSil_Click);
            // 
            // btnAdminEkleSil
            // 
            this.btnAdminEkleSil.Location = new System.Drawing.Point(339, 63);
            this.btnAdminEkleSil.Name = "btnAdminEkleSil";
            this.btnAdminEkleSil.Size = new System.Drawing.Size(143, 116);
            this.btnAdminEkleSil.TabIndex = 1;
            this.btnAdminEkleSil.Text = "Admin Ekle/Sil";
            this.btnAdminEkleSil.UseVisualStyleBackColor = true;
            this.btnAdminEkleSil.Click += new System.EventHandler(this.btnAdminEkleSil_Click);
            // 
            // btnVetEkleSil
            // 
            this.btnVetEkleSil.Location = new System.Drawing.Point(525, 63);
            this.btnVetEkleSil.Name = "btnVetEkleSil";
            this.btnVetEkleSil.Size = new System.Drawing.Size(143, 116);
            this.btnVetEkleSil.TabIndex = 2;
            this.btnVetEkleSil.Text = "Veteriner Ekle/Sil";
            this.btnVetEkleSil.UseVisualStyleBackColor = true;
            this.btnVetEkleSil.Click += new System.EventHandler(this.btnVetEkleSil_Click);
            // 
            // btnMusteriveHayvan
            // 
            this.btnMusteriveHayvan.Location = new System.Drawing.Point(697, 63);
            this.btnMusteriveHayvan.Name = "btnMusteriveHayvan";
            this.btnMusteriveHayvan.Size = new System.Drawing.Size(143, 116);
            this.btnMusteriveHayvan.TabIndex = 3;
            this.btnMusteriveHayvan.Text = "Müşteri-Pet İlişkilendir";
            this.btnMusteriveHayvan.UseVisualStyleBackColor = true;
            this.btnMusteriveHayvan.Click += new System.EventHandler(this.btnMusteriveHayvan_Click);
            // 
            // btnRandevularıGoster
            // 
            this.btnRandevularıGoster.Location = new System.Drawing.Point(164, 218);
            this.btnRandevularıGoster.Name = "btnRandevularıGoster";
            this.btnRandevularıGoster.Size = new System.Drawing.Size(143, 116);
            this.btnRandevularıGoster.TabIndex = 4;
            this.btnRandevularıGoster.Text = "Randevuları Göster";
            this.btnRandevularıGoster.UseVisualStyleBackColor = true;
            this.btnRandevularıGoster.Click += new System.EventHandler(this.btnRandevularıGoster_Click);
            // 
            // btnGecmisMuayeneKayıtlari
            // 
            this.btnGecmisMuayeneKayıtlari.Location = new System.Drawing.Point(525, 218);
            this.btnGecmisMuayeneKayıtlari.Name = "btnGecmisMuayeneKayıtlari";
            this.btnGecmisMuayeneKayıtlari.Size = new System.Drawing.Size(143, 116);
            this.btnGecmisMuayeneKayıtlari.TabIndex = 5;
            this.btnGecmisMuayeneKayıtlari.Text = "Geçmiş Muayene Kayıtları";
            this.btnGecmisMuayeneKayıtlari.UseVisualStyleBackColor = true;
            this.btnGecmisMuayeneKayıtlari.Click += new System.EventHandler(this.btnGecmisMuayeneKayıtlari_Click);
            // 
            // btnFaturaOlustur
            // 
            this.btnFaturaOlustur.Location = new System.Drawing.Point(697, 218);
            this.btnFaturaOlustur.Name = "btnFaturaOlustur";
            this.btnFaturaOlustur.Size = new System.Drawing.Size(143, 116);
            this.btnFaturaOlustur.TabIndex = 6;
            this.btnFaturaOlustur.Text = "Fatura Oluştur";
            this.btnFaturaOlustur.UseVisualStyleBackColor = true;
            this.btnFaturaOlustur.Click += new System.EventHandler(this.btnFaturaOlustur_Click);
            // 
            // btnMuayeOlustur
            // 
            this.btnMuayeOlustur.Location = new System.Drawing.Point(339, 218);
            this.btnMuayeOlustur.Name = "btnMuayeOlustur";
            this.btnMuayeOlustur.Size = new System.Drawing.Size(143, 116);
            this.btnMuayeOlustur.TabIndex = 7;
            this.btnMuayeOlustur.Text = "Muayene Oluştur";
            this.btnMuayeOlustur.UseVisualStyleBackColor = true;
            this.btnMuayeOlustur.Click += new System.EventHandler(this.btnMuayeOlustur_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 542);
            this.Controls.Add(this.btnMuayeOlustur);
            this.Controls.Add(this.btnFaturaOlustur);
            this.Controls.Add(this.btnGecmisMuayeneKayıtlari);
            this.Controls.Add(this.btnRandevularıGoster);
            this.Controls.Add(this.btnMusteriveHayvan);
            this.Controls.Add(this.btnVetEkleSil);
            this.Controls.Add(this.btnAdminEkleSil);
            this.Controls.Add(this.btnKullanıcıEkleSil);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminGirisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriHayvanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriGirisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ProjeDatabaseDataSet projeDatabaseDataSet;
        private System.Windows.Forms.BindingSource adminGirisBindingSource;
        private ProjeDatabaseDataSetTableAdapters.AdminGirisTableAdapter adminGirisTableAdapter;
        private System.Windows.Forms.BindingSource hayvanBilgiBindingSource;
        private ProjeDatabaseDataSetTableAdapters.HayvanBilgiTableAdapter hayvanBilgiTableAdapter;
        private System.Windows.Forms.BindingSource musteriHayvanBindingSource;
        private ProjeDatabaseDataSetTableAdapters.Musteri_HayvanTableAdapter musteri_HayvanTableAdapter;
        private System.Windows.Forms.BindingSource müşteriGirisBindingSource;
        private ProjeDatabaseDataSetTableAdapters.MüşteriGirisTableAdapter müşteriGirisTableAdapter;
        private System.Windows.Forms.Button btnKullanıcıEkleSil;
        private System.Windows.Forms.Button btnAdminEkleSil;
        private System.Windows.Forms.Button btnVetEkleSil;
        private System.Windows.Forms.Button btnMusteriveHayvan;
        private System.Windows.Forms.Button btnRandevularıGoster;
        private System.Windows.Forms.Button btnGecmisMuayeneKayıtlari;
        private System.Windows.Forms.Button btnFaturaOlustur;
        private System.Windows.Forms.Button btnMuayeOlustur;
    }
}