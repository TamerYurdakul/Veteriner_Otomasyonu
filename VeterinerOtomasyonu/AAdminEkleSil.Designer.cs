namespace VeterinerOtomasyonu
{
    partial class AAdminEkleSil
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
            this.txtAdminAd = new System.Windows.Forms.TextBox();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAAdminEkle = new System.Windows.Forms.Button();
            this.btnAAdminSil = new System.Windows.Forms.Button();
            this.adminGirisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDatabaseDataSet8 = new VeterinerOtomasyonu.ProjeDatabaseDataSet8();
            this.adminGirisTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSet8TableAdapters.AdminGirisTableAdapter();
            this.btnAAdminDuzenle = new System.Windows.Forms.Button();
            this.projeDatabaseDataSet12 = new VeterinerOtomasyonu.ProjeDatabaseDataSet12();
            this.adminGirisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adminGirisTableAdapter1 = new VeterinerOtomasyonu.ProjeDatabaseDataSet12TableAdapters.AdminGirisTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adminGirisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminGirisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdminAd
            // 
            this.txtAdminAd.Location = new System.Drawing.Point(294, 76);
            this.txtAdminAd.Name = "txtAdminAd";
            this.txtAdminAd.Size = new System.Drawing.Size(160, 32);
            this.txtAdminAd.TabIndex = 0;
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Location = new System.Drawing.Point(294, 117);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.Size = new System.Drawing.Size(160, 32);
            this.txtAdminSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin Şifre:";
            // 
            // btnAAdminEkle
            // 
            this.btnAAdminEkle.Location = new System.Drawing.Point(511, 65);
            this.btnAAdminEkle.Name = "btnAAdminEkle";
            this.btnAAdminEkle.Size = new System.Drawing.Size(144, 32);
            this.btnAAdminEkle.TabIndex = 9;
            this.btnAAdminEkle.Text = "Ekle";
            this.btnAAdminEkle.UseVisualStyleBackColor = true;
            this.btnAAdminEkle.Click += new System.EventHandler(this.btnAAdminEkle_Click);
            // 
            // btnAAdminSil
            // 
            this.btnAAdminSil.Location = new System.Drawing.Point(511, 173);
            this.btnAAdminSil.Name = "btnAAdminSil";
            this.btnAAdminSil.Size = new System.Drawing.Size(144, 32);
            this.btnAAdminSil.TabIndex = 10;
            this.btnAAdminSil.Text = "Sil";
            this.btnAAdminSil.UseVisualStyleBackColor = true;
            this.btnAAdminSil.Click += new System.EventHandler(this.btnAAdminSil_Click);
            // 
            // adminGirisBindingSource
            // 
            this.adminGirisBindingSource.DataMember = "AdminGiris";
            this.adminGirisBindingSource.DataSource = this.projeDatabaseDataSet8;
            // 
            // projeDatabaseDataSet8
            // 
            this.projeDatabaseDataSet8.DataSetName = "ProjeDatabaseDataSet8";
            this.projeDatabaseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminGirisTableAdapter
            // 
            this.adminGirisTableAdapter.ClearBeforeFill = true;
            // 
            // btnAAdminDuzenle
            // 
            this.btnAAdminDuzenle.Location = new System.Drawing.Point(511, 120);
            this.btnAAdminDuzenle.Name = "btnAAdminDuzenle";
            this.btnAAdminDuzenle.Size = new System.Drawing.Size(144, 32);
            this.btnAAdminDuzenle.TabIndex = 12;
            this.btnAAdminDuzenle.Text = "Düzenle";
            this.btnAAdminDuzenle.UseVisualStyleBackColor = true;
            this.btnAAdminDuzenle.Click += new System.EventHandler(this.btnAAdminDuzenle_Click);
            // 
            // projeDatabaseDataSet12
            // 
            this.projeDatabaseDataSet12.DataSetName = "ProjeDatabaseDataSet12";
            this.projeDatabaseDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminGirisBindingSource1
            // 
            this.adminGirisBindingSource1.DataMember = "AdminGiris";
            this.adminGirisBindingSource1.DataSource = this.projeDatabaseDataSet12;
            // 
            // adminGirisTableAdapter1
            // 
            this.adminGirisTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Admin ID:";
            // 
            // txtAdminID
            // 
            this.txtAdminID.Location = new System.Drawing.Point(294, 38);
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.Size = new System.Drawing.Size(160, 32);
            this.txtAdminID.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminAdDataGridViewTextBoxColumn,
            this.adminSifreDataGridViewTextBoxColumn,
            this.adminIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminGirisBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(133, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 150);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // adminAdDataGridViewTextBoxColumn
            // 
            this.adminAdDataGridViewTextBoxColumn.DataPropertyName = "AdminAd";
            this.adminAdDataGridViewTextBoxColumn.HeaderText = "AdminAd";
            this.adminAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminAdDataGridViewTextBoxColumn.Name = "adminAdDataGridViewTextBoxColumn";
            this.adminAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminSifreDataGridViewTextBoxColumn
            // 
            this.adminSifreDataGridViewTextBoxColumn.DataPropertyName = "AdminSifre";
            this.adminSifreDataGridViewTextBoxColumn.HeaderText = "AdminSifre";
            this.adminSifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminSifreDataGridViewTextBoxColumn.Name = "adminSifreDataGridViewTextBoxColumn";
            this.adminSifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminIDDataGridViewTextBoxColumn
            // 
            this.adminIDDataGridViewTextBoxColumn.DataPropertyName = "AdminID";
            this.adminIDDataGridViewTextBoxColumn.HeaderText = "AdminID";
            this.adminIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminIDDataGridViewTextBoxColumn.Name = "adminIDDataGridViewTextBoxColumn";
            this.adminIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.adminIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // AAdminEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 373);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAdminID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAAdminDuzenle);
            this.Controls.Add(this.btnAAdminSil);
            this.Controls.Add(this.btnAAdminEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdminSifre);
            this.Controls.Add(this.txtAdminAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AAdminEkleSil";
            this.Text = "AAdminEkleSil";
            this.Load += new System.EventHandler(this.AAdminEkleSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminGirisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminGirisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdminAd;
        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAAdminEkle;
        private System.Windows.Forms.Button btnAAdminSil;
        private ProjeDatabaseDataSet8 projeDatabaseDataSet8;
        private System.Windows.Forms.BindingSource adminGirisBindingSource;
        private ProjeDatabaseDataSet8TableAdapters.AdminGirisTableAdapter adminGirisTableAdapter;
        private System.Windows.Forms.Button btnAAdminDuzenle;
        private ProjeDatabaseDataSet12 projeDatabaseDataSet12;
        private System.Windows.Forms.BindingSource adminGirisBindingSource1;
        private ProjeDatabaseDataSet12TableAdapters.AdminGirisTableAdapter adminGirisTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
    }
}