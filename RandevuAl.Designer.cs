namespace VeterinerOtomasyonu
{
    partial class RandevuAl
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
            this.müşteriGirisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDatabaseDataSet = new VeterinerOtomasyonu.ProjeDatabaseDataSet();
            this.müşteriGirisTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSetTableAdapters.MüşteriGirisTableAdapter();
            this.musteritctxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPetCipNo = new System.Windows.Forms.ComboBox();
            this.musteriRandevulariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projeDatabaseDataSet2 = new VeterinerOtomasyonu.ProjeDatabaseDataSet2();
            this.projeDatabaseDataSet1 = new VeterinerOtomasyonu.ProjeDatabaseDataSet1();
            this.musteriRandevulariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriRandevulariTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSet1TableAdapters.MusteriRandevulariTableAdapter();
            this.musteriRandevulariTableAdapter1 = new VeterinerOtomasyonu.ProjeDatabaseDataSet2TableAdapters.MusteriRandevulariTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVeterinerID = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSaatler = new System.Windows.Forms.ComboBox();
            this.projeDatabaseDataSet3 = new VeterinerOtomasyonu.ProjeDatabaseDataSet3();
            this.hayvanVeSahipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hayvanVeSahipTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSet3TableAdapters.HayvanVeSahipTableAdapter();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.btnRandevuDuzenle = new System.Windows.Forms.Button();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RandevuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petCipNoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeterinerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandevuSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandevuTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriRandevulariBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projeDatabaseDataSet4 = new VeterinerOtomasyonu.ProjeDatabaseDataSet4();
            this.musteriRandevulariTableAdapter2 = new VeterinerOtomasyonu.ProjeDatabaseDataSet4TableAdapters.MusteriRandevulariTableAdapter();
            this.btnVeterinerList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriGirisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriRandevulariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriRandevulariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanVeSahipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriRandevulariBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // müşteriGirisBindingSource
            // 
            this.müşteriGirisBindingSource.DataMember = "MüşteriGiris";
            this.müşteriGirisBindingSource.DataSource = this.projeDatabaseDataSet;
            // 
            // projeDatabaseDataSet
            // 
            this.projeDatabaseDataSet.DataSetName = "ProjeDatabaseDataSet";
            this.projeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müşteriGirisTableAdapter
            // 
            this.müşteriGirisTableAdapter.ClearBeforeFill = true;
            // 
            // musteritctxt
            // 
            this.musteritctxt.Location = new System.Drawing.Point(374, 35);
            this.musteritctxt.Margin = new System.Windows.Forms.Padding(5);
            this.musteritctxt.Multiline = true;
            this.musteritctxt.Name = "musteritctxt";
            this.musteritctxt.ReadOnly = true;
            this.musteritctxt.Size = new System.Drawing.Size(209, 32);
            this.musteritctxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(121, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(122, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pet Çip No:";
            // 
            // cmbPetCipNo
            // 
            this.cmbPetCipNo.DataSource = this.musteriRandevulariBindingSource1;
            this.cmbPetCipNo.DisplayMember = "PetCipNoID";
            this.cmbPetCipNo.FormattingEnabled = true;
            this.cmbPetCipNo.Location = new System.Drawing.Point(374, 86);
            this.cmbPetCipNo.Name = "cmbPetCipNo";
            this.cmbPetCipNo.Size = new System.Drawing.Size(209, 34);
            this.cmbPetCipNo.TabIndex = 3;
            this.cmbPetCipNo.ValueMember = "PetCipNoID";
            // 
            // musteriRandevulariBindingSource1
            // 
            this.musteriRandevulariBindingSource1.DataMember = "MusteriRandevulari";
            this.musteriRandevulariBindingSource1.DataSource = this.projeDatabaseDataSet2;
            // 
            // projeDatabaseDataSet2
            // 
            this.projeDatabaseDataSet2.DataSetName = "ProjeDatabaseDataSet2";
            this.projeDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeDatabaseDataSet1
            // 
            this.projeDatabaseDataSet1.DataSetName = "ProjeDatabaseDataSet1";
            this.projeDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriRandevulariBindingSource
            // 
            this.musteriRandevulariBindingSource.DataMember = "MusteriRandevulari";
            this.musteriRandevulariBindingSource.DataSource = this.projeDatabaseDataSet1;
            // 
            // musteriRandevulariTableAdapter
            // 
            this.musteriRandevulariTableAdapter.ClearBeforeFill = true;
            // 
            // musteriRandevulariTableAdapter1
            // 
            this.musteriRandevulariTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(122, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Veteriner ID:";
            // 
            // cmbVeterinerID
            // 
            this.cmbVeterinerID.FormattingEnabled = true;
            this.cmbVeterinerID.Location = new System.Drawing.Point(374, 140);
            this.cmbVeterinerID.Name = "cmbVeterinerID";
            this.cmbVeterinerID.Size = new System.Drawing.Size(209, 34);
            this.cmbVeterinerID.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(374, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(376, 32);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Randevu Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Randevu Saati:";
            // 
            // cmbSaatler
            // 
            this.cmbSaatler.FormattingEnabled = true;
            this.cmbSaatler.Items.AddRange(new object[] {
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
            this.cmbSaatler.Location = new System.Drawing.Point(374, 248);
            this.cmbSaatler.Name = "cmbSaatler";
            this.cmbSaatler.Size = new System.Drawing.Size(209, 34);
            this.cmbSaatler.TabIndex = 9;
            // 
            // projeDatabaseDataSet3
            // 
            this.projeDatabaseDataSet3.DataSetName = "ProjeDatabaseDataSet3";
            this.projeDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hayvanVeSahipBindingSource
            // 
            this.hayvanVeSahipBindingSource.DataMember = "HayvanVeSahip";
            this.hayvanVeSahipBindingSource.DataSource = this.projeDatabaseDataSet3;
            // 
            // hayvanVeSahipTableAdapter
            // 
            this.hayvanVeSahipTableAdapter.ClearBeforeFill = true;
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Location = new System.Drawing.Point(842, 46);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(205, 74);
            this.btnRandevuAl.TabIndex = 10;
            this.btnRandevuAl.Text = "Randevu \r\nAl";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // btnRandevuDuzenle
            // 
            this.btnRandevuDuzenle.Location = new System.Drawing.Point(842, 145);
            this.btnRandevuDuzenle.Name = "btnRandevuDuzenle";
            this.btnRandevuDuzenle.Size = new System.Drawing.Size(205, 74);
            this.btnRandevuDuzenle.TabIndex = 11;
            this.btnRandevuDuzenle.Text = "Randevu Düzenle";
            this.btnRandevuDuzenle.UseVisualStyleBackColor = true;
            this.btnRandevuDuzenle.Click += new System.EventHandler(this.btnRandevuDuzenle_Click);
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Location = new System.Drawing.Point(842, 225);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(205, 74);
            this.btnRandevuSil.TabIndex = 12;
            this.btnRandevuSil.Text = "Randevu \r\nSil";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RandevuID,
            this.MusteriTC,
            this.petCipNoIDDataGridViewTextBoxColumn,
            this.VeterinerID,
            this.RandevuSaat,
            this.RandevuTarihi});
            this.dataGridView1.DataSource = this.musteriRandevulariBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(78, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // RandevuID
            // 
            this.RandevuID.DataPropertyName = "RandevuID";
            this.RandevuID.HeaderText = "RandevuID";
            this.RandevuID.MinimumWidth = 6;
            this.RandevuID.Name = "RandevuID";
            this.RandevuID.ReadOnly = true;
            this.RandevuID.Width = 125;
            // 
            // MusteriTC
            // 
            this.MusteriTC.DataPropertyName = "MusteriTC";
            this.MusteriTC.HeaderText = "MusteriTC";
            this.MusteriTC.MinimumWidth = 6;
            this.MusteriTC.Name = "MusteriTC";
            this.MusteriTC.Width = 125;
            // 
            // petCipNoIDDataGridViewTextBoxColumn
            // 
            this.petCipNoIDDataGridViewTextBoxColumn.DataPropertyName = "PetCipNoID";
            this.petCipNoIDDataGridViewTextBoxColumn.HeaderText = "PetCipNoID";
            this.petCipNoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petCipNoIDDataGridViewTextBoxColumn.Name = "petCipNoIDDataGridViewTextBoxColumn";
            this.petCipNoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // VeterinerID
            // 
            this.VeterinerID.DataPropertyName = "VeterinerID";
            this.VeterinerID.HeaderText = "VeterinerID";
            this.VeterinerID.MinimumWidth = 6;
            this.VeterinerID.Name = "VeterinerID";
            this.VeterinerID.Width = 125;
            // 
            // RandevuSaat
            // 
            this.RandevuSaat.DataPropertyName = "RandevuSaat";
            this.RandevuSaat.HeaderText = "RandevuSaat";
            this.RandevuSaat.MinimumWidth = 6;
            this.RandevuSaat.Name = "RandevuSaat";
            this.RandevuSaat.Width = 125;
            // 
            // RandevuTarihi
            // 
            this.RandevuTarihi.DataPropertyName = "RandevuTarihi";
            this.RandevuTarihi.HeaderText = "RandevuTarihi";
            this.RandevuTarihi.MinimumWidth = 6;
            this.RandevuTarihi.Name = "RandevuTarihi";
            this.RandevuTarihi.Width = 125;
            // 
            // musteriRandevulariBindingSource2
            // 
            this.musteriRandevulariBindingSource2.DataMember = "MusteriRandevulari";
            this.musteriRandevulariBindingSource2.DataSource = this.projeDatabaseDataSet4;
            // 
            // projeDatabaseDataSet4
            // 
            this.projeDatabaseDataSet4.DataSetName = "ProjeDatabaseDataSet4";
            this.projeDatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriRandevulariTableAdapter2
            // 
            this.musteriRandevulariTableAdapter2.ClearBeforeFill = true;
            // 
            // btnVeterinerList
            // 
            this.btnVeterinerList.Location = new System.Drawing.Point(605, 141);
            this.btnVeterinerList.Name = "btnVeterinerList";
            this.btnVeterinerList.Size = new System.Drawing.Size(180, 31);
            this.btnVeterinerList.TabIndex = 14;
            this.btnVeterinerList.Text = "Veterinerleri Gör";
            this.btnVeterinerList.UseVisualStyleBackColor = true;
            this.btnVeterinerList.Click += new System.EventHandler(this.btnVeterinerList_Click);
            // 
            // RandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 513);
            this.Controls.Add(this.btnVeterinerList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRandevuSil);
            this.Controls.Add(this.btnRandevuDuzenle);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.cmbSaatler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbVeterinerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPetCipNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.musteritctxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RandevuAl";
            this.Text = "RandevuAl";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.RandevuAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.müşteriGirisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriRandevulariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriRandevulariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanVeSahipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriRandevulariBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProjeDatabaseDataSet projeDatabaseDataSet;
        private System.Windows.Forms.BindingSource müşteriGirisBindingSource;
        private ProjeDatabaseDataSetTableAdapters.MüşteriGirisTableAdapter müşteriGirisTableAdapter;
        private System.Windows.Forms.TextBox musteritctxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPetCipNo;
        private ProjeDatabaseDataSet1 projeDatabaseDataSet1;
        private System.Windows.Forms.BindingSource musteriRandevulariBindingSource;
        private ProjeDatabaseDataSet1TableAdapters.MusteriRandevulariTableAdapter musteriRandevulariTableAdapter;
        private ProjeDatabaseDataSet2 projeDatabaseDataSet2;
        private System.Windows.Forms.BindingSource musteriRandevulariBindingSource1;
        private ProjeDatabaseDataSet2TableAdapters.MusteriRandevulariTableAdapter musteriRandevulariTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVeterinerID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSaatler;
        private ProjeDatabaseDataSet3 projeDatabaseDataSet3;
        private System.Windows.Forms.BindingSource hayvanVeSahipBindingSource;
        private ProjeDatabaseDataSet3TableAdapters.HayvanVeSahipTableAdapter hayvanVeSahipTableAdapter;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Button btnRandevuDuzenle;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjeDatabaseDataSet4 projeDatabaseDataSet4;
        private System.Windows.Forms.BindingSource musteriRandevulariBindingSource2;
        private ProjeDatabaseDataSet4TableAdapters.MusteriRandevulariTableAdapter musteriRandevulariTableAdapter2;
        private System.Windows.Forms.Button btnVeterinerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandevuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn petCipNoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeterinerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandevuSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandevuTarihi;
    }
}