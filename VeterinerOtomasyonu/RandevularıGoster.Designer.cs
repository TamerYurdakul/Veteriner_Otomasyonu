namespace VeterinerOtomasyonu
{
    partial class RandevularıGoster
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
            this.cmbMusteriTc = new System.Windows.Forms.ComboBox();
            this.müşteriGirisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDatabaseDataSet17 = new VeterinerOtomasyonu.ProjeDatabaseDataSet17();
            this.cmbPetCipNoID = new System.Windows.Forms.ComboBox();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDatabaseDataSet18 = new VeterinerOtomasyonu.ProjeDatabaseDataSet18();
            this.cmbVeteriner = new System.Windows.Forms.ComboBox();
            this.veterinerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDatabaseDataSet19 = new VeterinerOtomasyonu.ProjeDatabaseDataSet19();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbRandevuSaat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petCipNoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriRandevulariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDatabaseDataSet16 = new VeterinerOtomasyonu.ProjeDatabaseDataSet16();
            this.btnRandevuEkle = new System.Windows.Forms.Button();
            this.btnRandevuDuzenle = new System.Windows.Forms.Button();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.lblRandevuID = new System.Windows.Forms.Label();
            this.musteriRandevulariTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSet16TableAdapters.MusteriRandevulariTableAdapter();
            this.müşteriGirisTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSet17TableAdapters.MüşteriGirisTableAdapter();
            this.petTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSet18TableAdapters.PetTableAdapter();
            this.veterinerTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSet19TableAdapters.VeterinerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriGirisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriRandevulariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMusteriTc
            // 
            this.cmbMusteriTc.DataSource = this.müşteriGirisBindingSource;
            this.cmbMusteriTc.DisplayMember = "MusteriTc";
            this.cmbMusteriTc.FormattingEnabled = true;
            this.cmbMusteriTc.Location = new System.Drawing.Point(332, 41);
            this.cmbMusteriTc.Name = "cmbMusteriTc";
            this.cmbMusteriTc.Size = new System.Drawing.Size(216, 34);
            this.cmbMusteriTc.TabIndex = 0;
            this.cmbMusteriTc.ValueMember = "MusteriTc";
            // 
            // müşteriGirisBindingSource
            // 
            this.müşteriGirisBindingSource.DataMember = "MüşteriGiris";
            this.müşteriGirisBindingSource.DataSource = this.projeDatabaseDataSet17;
            // 
            // projeDatabaseDataSet17
            // 
            this.projeDatabaseDataSet17.DataSetName = "ProjeDatabaseDataSet17";
            this.projeDatabaseDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbPetCipNoID
            // 
            this.cmbPetCipNoID.DataSource = this.petBindingSource;
            this.cmbPetCipNoID.DisplayMember = "PetCipID";
            this.cmbPetCipNoID.FormattingEnabled = true;
            this.cmbPetCipNoID.Location = new System.Drawing.Point(332, 95);
            this.cmbPetCipNoID.Name = "cmbPetCipNoID";
            this.cmbPetCipNoID.Size = new System.Drawing.Size(216, 34);
            this.cmbPetCipNoID.TabIndex = 1;
            this.cmbPetCipNoID.ValueMember = "PetCipID";
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataMember = "Pet";
            this.petBindingSource.DataSource = this.projeDatabaseDataSet18;
            // 
            // projeDatabaseDataSet18
            // 
            this.projeDatabaseDataSet18.DataSetName = "ProjeDatabaseDataSet18";
            this.projeDatabaseDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbVeteriner
            // 
            this.cmbVeteriner.DataSource = this.veterinerBindingSource;
            this.cmbVeteriner.DisplayMember = "VeterinerID";
            this.cmbVeteriner.FormattingEnabled = true;
            this.cmbVeteriner.Location = new System.Drawing.Point(332, 150);
            this.cmbVeteriner.Name = "cmbVeteriner";
            this.cmbVeteriner.Size = new System.Drawing.Size(216, 34);
            this.cmbVeteriner.TabIndex = 2;
            this.cmbVeteriner.ValueMember = "VeterinerID";
            // 
            // veterinerBindingSource
            // 
            this.veterinerBindingSource.DataMember = "Veteriner";
            this.veterinerBindingSource.DataSource = this.projeDatabaseDataSet19;
            // 
            // projeDatabaseDataSet19
            // 
            this.projeDatabaseDataSet19.DataSetName = "ProjeDatabaseDataSet19";
            this.projeDatabaseDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(332, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(355, 32);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // cmbRandevuSaat
            // 
            this.cmbRandevuSaat.FormattingEnabled = true;
            this.cmbRandevuSaat.Items.AddRange(new object[] {
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45",
            "16:00",
            "16:15",
            "16:30",
            "16:45",
            "17:00",
            "17:15",
            "17:30",
            "17:45",
            "18:00"});
            this.cmbRandevuSaat.Location = new System.Drawing.Point(332, 277);
            this.cmbRandevuSaat.Name = "cmbRandevuSaat";
            this.cmbRandevuSaat.Size = new System.Drawing.Size(216, 34);
            this.cmbRandevuSaat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(139, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Müşteri TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(139, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pet Çip ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(139, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Veteriner ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(139, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Randevu Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(139, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Randevu Saat:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriTCDataGridViewTextBoxColumn,
            this.petCipNoIDDataGridViewTextBoxColumn,
            this.veterinerIDDataGridViewTextBoxColumn,
            this.randevuTarihiDataGridViewTextBoxColumn,
            this.randevuSaatDataGridViewTextBoxColumn,
            this.randevuIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriRandevulariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(144, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(862, 262);
            this.dataGridView1.TabIndex = 10;
            // 
            // musteriTCDataGridViewTextBoxColumn
            // 
            this.musteriTCDataGridViewTextBoxColumn.DataPropertyName = "MusteriTC";
            this.musteriTCDataGridViewTextBoxColumn.HeaderText = "MusteriTC";
            this.musteriTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriTCDataGridViewTextBoxColumn.Name = "musteriTCDataGridViewTextBoxColumn";
            this.musteriTCDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // petCipNoIDDataGridViewTextBoxColumn
            // 
            this.petCipNoIDDataGridViewTextBoxColumn.DataPropertyName = "PetCipNoID";
            this.petCipNoIDDataGridViewTextBoxColumn.HeaderText = "PetCipNoID";
            this.petCipNoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petCipNoIDDataGridViewTextBoxColumn.Name = "petCipNoIDDataGridViewTextBoxColumn";
            this.petCipNoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.petCipNoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // veterinerIDDataGridViewTextBoxColumn
            // 
            this.veterinerIDDataGridViewTextBoxColumn.DataPropertyName = "VeterinerID";
            this.veterinerIDDataGridViewTextBoxColumn.HeaderText = "VeterinerID";
            this.veterinerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veterinerIDDataGridViewTextBoxColumn.Name = "veterinerIDDataGridViewTextBoxColumn";
            this.veterinerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.veterinerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuTarihiDataGridViewTextBoxColumn
            // 
            this.randevuTarihiDataGridViewTextBoxColumn.DataPropertyName = "RandevuTarihi";
            this.randevuTarihiDataGridViewTextBoxColumn.HeaderText = "RandevuTarihi";
            this.randevuTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuTarihiDataGridViewTextBoxColumn.Name = "randevuTarihiDataGridViewTextBoxColumn";
            this.randevuTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevuTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuSaatDataGridViewTextBoxColumn
            // 
            this.randevuSaatDataGridViewTextBoxColumn.DataPropertyName = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.HeaderText = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuSaatDataGridViewTextBoxColumn.Name = "randevuSaatDataGridViewTextBoxColumn";
            this.randevuSaatDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevuSaatDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuIDDataGridViewTextBoxColumn
            // 
            this.randevuIDDataGridViewTextBoxColumn.DataPropertyName = "RandevuID";
            this.randevuIDDataGridViewTextBoxColumn.HeaderText = "RandevuID";
            this.randevuIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuIDDataGridViewTextBoxColumn.Name = "randevuIDDataGridViewTextBoxColumn";
            this.randevuIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevuIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriRandevulariBindingSource
            // 
            this.musteriRandevulariBindingSource.DataMember = "MusteriRandevulari";
            this.musteriRandevulariBindingSource.DataSource = this.projeDatabaseDataSet16;
            // 
            // projeDatabaseDataSet16
            // 
            this.projeDatabaseDataSet16.DataSetName = "ProjeDatabaseDataSet16";
            this.projeDatabaseDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRandevuEkle
            // 
            this.btnRandevuEkle.Location = new System.Drawing.Point(801, 52);
            this.btnRandevuEkle.Name = "btnRandevuEkle";
            this.btnRandevuEkle.Size = new System.Drawing.Size(205, 43);
            this.btnRandevuEkle.TabIndex = 11;
            this.btnRandevuEkle.Text = "Randevu Ekle";
            this.btnRandevuEkle.UseVisualStyleBackColor = true;
            this.btnRandevuEkle.Click += new System.EventHandler(this.btnRandevuEkle_Click);
            // 
            // btnRandevuDuzenle
            // 
            this.btnRandevuDuzenle.Location = new System.Drawing.Point(801, 118);
            this.btnRandevuDuzenle.Name = "btnRandevuDuzenle";
            this.btnRandevuDuzenle.Size = new System.Drawing.Size(205, 43);
            this.btnRandevuDuzenle.TabIndex = 12;
            this.btnRandevuDuzenle.Text = "Randevu Düzenle";
            this.btnRandevuDuzenle.UseVisualStyleBackColor = true;
            this.btnRandevuDuzenle.Click += new System.EventHandler(this.btnRandevuDuzenle_Click);
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Location = new System.Drawing.Point(801, 181);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(205, 43);
            this.btnRandevuSil.TabIndex = 13;
            this.btnRandevuSil.Text = "Randevu Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // lblRandevuID
            // 
            this.lblRandevuID.AutoSize = true;
            this.lblRandevuID.Location = new System.Drawing.Point(644, 98);
            this.lblRandevuID.Name = "lblRandevuID";
            this.lblRandevuID.Size = new System.Drawing.Size(70, 26);
            this.lblRandevuID.TabIndex = 14;
            this.lblRandevuID.Text = "label6";
            this.lblRandevuID.Visible = false;
            // 
            // musteriRandevulariTableAdapter
            // 
            this.musteriRandevulariTableAdapter.ClearBeforeFill = true;
            // 
            // müşteriGirisTableAdapter
            // 
            this.müşteriGirisTableAdapter.ClearBeforeFill = true;
            // 
            // petTableAdapter
            // 
            this.petTableAdapter.ClearBeforeFill = true;
            // 
            // veterinerTableAdapter
            // 
            this.veterinerTableAdapter.ClearBeforeFill = true;
            // 
            // RandevularıGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 695);
            this.Controls.Add(this.lblRandevuID);
            this.Controls.Add(this.btnRandevuSil);
            this.Controls.Add(this.btnRandevuDuzenle);
            this.Controls.Add(this.btnRandevuEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRandevuSaat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbVeteriner);
            this.Controls.Add(this.cmbPetCipNoID);
            this.Controls.Add(this.cmbMusteriTc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RandevularıGoster";
            this.Text = "RandevularıGoster";
            this.Load += new System.EventHandler(this.RandevularıGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.müşteriGirisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriRandevulariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteriTc;
        private System.Windows.Forms.ComboBox cmbPetCipNoID;
        private System.Windows.Forms.ComboBox cmbVeteriner;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbRandevuSaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRandevuEkle;
        private System.Windows.Forms.Button btnRandevuDuzenle;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.Label lblRandevuID;
        private ProjeDatabaseDataSet16 projeDatabaseDataSet16;
        private System.Windows.Forms.BindingSource musteriRandevulariBindingSource;
        private ProjeDatabaseDataSet16TableAdapters.MusteriRandevulariTableAdapter musteriRandevulariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petCipNoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuIDDataGridViewTextBoxColumn;
        private ProjeDatabaseDataSet17 projeDatabaseDataSet17;
        private System.Windows.Forms.BindingSource müşteriGirisBindingSource;
        private ProjeDatabaseDataSet17TableAdapters.MüşteriGirisTableAdapter müşteriGirisTableAdapter;
        private ProjeDatabaseDataSet18 projeDatabaseDataSet18;
        private System.Windows.Forms.BindingSource petBindingSource;
        private ProjeDatabaseDataSet18TableAdapters.PetTableAdapter petTableAdapter;
        private ProjeDatabaseDataSet19 projeDatabaseDataSet19;
        private System.Windows.Forms.BindingSource veterinerBindingSource;
        private ProjeDatabaseDataSet19TableAdapters.VeterinerTableAdapter veterinerTableAdapter;
    }
}