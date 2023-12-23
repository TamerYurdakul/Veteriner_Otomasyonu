namespace VeterinerOtomasyonu
{
    partial class VetEkleSil
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
            this.btnVetDuzenle = new System.Windows.Forms.Button();
            this.btnVetSil = new System.Windows.Forms.Button();
            this.btnVetEkle = new System.Windows.Forms.Button();
            this.txtVetSoyad = new System.Windows.Forms.TextBox();
            this.txtVetAd = new System.Windows.Forms.TextBox();
            this.cmbVetID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projeDatabaseDataSet10 = new VeterinerOtomasyonu.ProjeDatabaseDataSet10();
            this.veterinerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinerTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSet10TableAdapters.VeterinerTableAdapter();
            this.veterinerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinerAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinerSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVetDuzenle
            // 
            this.btnVetDuzenle.Location = new System.Drawing.Point(595, 62);
            this.btnVetDuzenle.Name = "btnVetDuzenle";
            this.btnVetDuzenle.Size = new System.Drawing.Size(144, 32);
            this.btnVetDuzenle.TabIndex = 20;
            this.btnVetDuzenle.Text = "Düzenle";
            this.btnVetDuzenle.UseVisualStyleBackColor = true;
            this.btnVetDuzenle.Click += new System.EventHandler(this.btnVetDuzenle_Click);
            // 
            // btnVetSil
            // 
            this.btnVetSil.Location = new System.Drawing.Point(595, 106);
            this.btnVetSil.Name = "btnVetSil";
            this.btnVetSil.Size = new System.Drawing.Size(144, 32);
            this.btnVetSil.TabIndex = 18;
            this.btnVetSil.Text = "Sil";
            this.btnVetSil.UseVisualStyleBackColor = true;
            this.btnVetSil.Click += new System.EventHandler(this.btnVetSil_Click);
            // 
            // btnVetEkle
            // 
            this.btnVetEkle.Location = new System.Drawing.Point(595, 19);
            this.btnVetEkle.Name = "btnVetEkle";
            this.btnVetEkle.Size = new System.Drawing.Size(144, 32);
            this.btnVetEkle.TabIndex = 17;
            this.btnVetEkle.Text = "Ekle";
            this.btnVetEkle.UseVisualStyleBackColor = true;
            this.btnVetEkle.Click += new System.EventHandler(this.btnVetEkle_Click);
            // 
            // txtVetSoyad
            // 
            this.txtVetSoyad.Location = new System.Drawing.Point(318, 106);
            this.txtVetSoyad.Name = "txtVetSoyad";
            this.txtVetSoyad.Size = new System.Drawing.Size(160, 32);
            this.txtVetSoyad.TabIndex = 14;
            // 
            // txtVetAd
            // 
            this.txtVetAd.Location = new System.Drawing.Point(318, 62);
            this.txtVetAd.Name = "txtVetAd";
            this.txtVetAd.Size = new System.Drawing.Size(160, 32);
            this.txtVetAd.TabIndex = 13;
            // 
            // cmbVetID
            // 
            this.cmbVetID.FormattingEnabled = true;
            this.cmbVetID.Location = new System.Drawing.Point(318, 19);
            this.cmbVetID.Name = "cmbVetID";
            this.cmbVetID.Size = new System.Drawing.Size(160, 34);
            this.cmbVetID.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Veteriner ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Veteriner Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Veteriner Soyad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.veterinerIDDataGridViewTextBoxColumn,
            this.veterinerAdDataGridViewTextBoxColumn,
            this.veterinerSoyadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.veterinerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(151, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 150);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // projeDatabaseDataSet10
            // 
            this.projeDatabaseDataSet10.DataSetName = "ProjeDatabaseDataSet10";
            this.projeDatabaseDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veterinerBindingSource
            // 
            this.veterinerBindingSource.DataMember = "Veteriner";
            this.veterinerBindingSource.DataSource = this.projeDatabaseDataSet10;
            // 
            // veterinerTableAdapter
            // 
            this.veterinerTableAdapter.ClearBeforeFill = true;
            // 
            // veterinerIDDataGridViewTextBoxColumn
            // 
            this.veterinerIDDataGridViewTextBoxColumn.DataPropertyName = "VeterinerID";
            this.veterinerIDDataGridViewTextBoxColumn.HeaderText = "VeterinerID";
            this.veterinerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veterinerIDDataGridViewTextBoxColumn.Name = "veterinerIDDataGridViewTextBoxColumn";
            this.veterinerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // veterinerAdDataGridViewTextBoxColumn
            // 
            this.veterinerAdDataGridViewTextBoxColumn.DataPropertyName = "VeterinerAd";
            this.veterinerAdDataGridViewTextBoxColumn.HeaderText = "VeterinerAd";
            this.veterinerAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veterinerAdDataGridViewTextBoxColumn.Name = "veterinerAdDataGridViewTextBoxColumn";
            this.veterinerAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // veterinerSoyadDataGridViewTextBoxColumn
            // 
            this.veterinerSoyadDataGridViewTextBoxColumn.DataPropertyName = "VeterinerSoyad";
            this.veterinerSoyadDataGridViewTextBoxColumn.HeaderText = "VeterinerSoyad";
            this.veterinerSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veterinerSoyadDataGridViewTextBoxColumn.Name = "veterinerSoyadDataGridViewTextBoxColumn";
            this.veterinerSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // VetEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 376);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbVetID);
            this.Controls.Add(this.btnVetDuzenle);
            this.Controls.Add(this.btnVetSil);
            this.Controls.Add(this.btnVetEkle);
            this.Controls.Add(this.txtVetSoyad);
            this.Controls.Add(this.txtVetAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "VetEkleSil";
            this.Text = "VetEkleSil";
            this.Load += new System.EventHandler(this.VetEkleSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVetDuzenle;
        private System.Windows.Forms.Button btnVetSil;
        private System.Windows.Forms.Button btnVetEkle;
        private System.Windows.Forms.TextBox txtVetSoyad;
        private System.Windows.Forms.TextBox txtVetAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVetID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjeDatabaseDataSet10 projeDatabaseDataSet10;
        private System.Windows.Forms.BindingSource veterinerBindingSource;
        private ProjeDatabaseDataSet10TableAdapters.VeterinerTableAdapter veterinerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinerAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinerSoyadDataGridViewTextBoxColumn;
    }
}