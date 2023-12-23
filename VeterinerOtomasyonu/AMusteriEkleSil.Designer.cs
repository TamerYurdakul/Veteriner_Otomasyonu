namespace VeterinerOtomasyonu
{
    partial class AMusteriEkleSil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAMusteriEkle = new System.Windows.Forms.Button();
            this.btnAMusteriDuzenle = new System.Windows.Forms.Button();
            this.btnAMusteriSil = new System.Windows.Forms.Button();
            this.txtMusteriSifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projeDatabaseDataSet14 = new VeterinerOtomasyonu.ProjeDatabaseDataSet14();
            this.müşteriGirisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.müşteriGirisTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSet14TableAdapters.MüşteriGirisTableAdapter();
            this.musteriTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMusteriTc = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriGirisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Şifre:";
            // 
            // btnAMusteriEkle
            // 
            this.btnAMusteriEkle.Location = new System.Drawing.Point(544, 48);
            this.btnAMusteriEkle.Name = "btnAMusteriEkle";
            this.btnAMusteriEkle.Size = new System.Drawing.Size(121, 52);
            this.btnAMusteriEkle.TabIndex = 2;
            this.btnAMusteriEkle.Text = "Ekle";
            this.btnAMusteriEkle.UseVisualStyleBackColor = true;
            this.btnAMusteriEkle.Click += new System.EventHandler(this.btnAMusteriEkle_Click);
            // 
            // btnAMusteriDuzenle
            // 
            this.btnAMusteriDuzenle.Location = new System.Drawing.Point(544, 106);
            this.btnAMusteriDuzenle.Name = "btnAMusteriDuzenle";
            this.btnAMusteriDuzenle.Size = new System.Drawing.Size(121, 52);
            this.btnAMusteriDuzenle.TabIndex = 3;
            this.btnAMusteriDuzenle.Text = "Düzenle";
            this.btnAMusteriDuzenle.UseVisualStyleBackColor = true;
            this.btnAMusteriDuzenle.Click += new System.EventHandler(this.btnAMusteriDuzenle_Click);
            // 
            // btnAMusteriSil
            // 
            this.btnAMusteriSil.Location = new System.Drawing.Point(544, 164);
            this.btnAMusteriSil.Name = "btnAMusteriSil";
            this.btnAMusteriSil.Size = new System.Drawing.Size(121, 52);
            this.btnAMusteriSil.TabIndex = 4;
            this.btnAMusteriSil.Text = "Sil";
            this.btnAMusteriSil.UseVisualStyleBackColor = true;
            this.btnAMusteriSil.Click += new System.EventHandler(this.btnAMusteriSil_Click);
            // 
            // txtMusteriSifre
            // 
            this.txtMusteriSifre.Location = new System.Drawing.Point(278, 86);
            this.txtMusteriSifre.Name = "txtMusteriSifre";
            this.txtMusteriSifre.Size = new System.Drawing.Size(156, 32);
            this.txtMusteriSifre.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriTcDataGridViewTextBoxColumn,
            this.musteriSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.müşteriGirisBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(100, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(382, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // projeDatabaseDataSet14
            // 
            this.projeDatabaseDataSet14.DataSetName = "ProjeDatabaseDataSet14";
            this.projeDatabaseDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müşteriGirisBindingSource
            // 
            this.müşteriGirisBindingSource.DataMember = "MüşteriGiris";
            this.müşteriGirisBindingSource.DataSource = this.projeDatabaseDataSet14;
            // 
            // müşteriGirisTableAdapter
            // 
            this.müşteriGirisTableAdapter.ClearBeforeFill = true;
            // 
            // musteriTcDataGridViewTextBoxColumn
            // 
            this.musteriTcDataGridViewTextBoxColumn.DataPropertyName = "MusteriTc";
            this.musteriTcDataGridViewTextBoxColumn.HeaderText = "MusteriTc";
            this.musteriTcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriTcDataGridViewTextBoxColumn.Name = "musteriTcDataGridViewTextBoxColumn";
            this.musteriTcDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriSifreDataGridViewTextBoxColumn
            // 
            this.musteriSifreDataGridViewTextBoxColumn.DataPropertyName = "MusteriSifre";
            this.musteriSifreDataGridViewTextBoxColumn.HeaderText = "MusteriSifre";
            this.musteriSifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriSifreDataGridViewTextBoxColumn.Name = "musteriSifreDataGridViewTextBoxColumn";
            this.musteriSifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // txtMusteriTc
            // 
            this.txtMusteriTc.Location = new System.Drawing.Point(278, 35);
            this.txtMusteriTc.Mask = "00000000000";
            this.txtMusteriTc.Name = "txtMusteriTc";
            this.txtMusteriTc.Size = new System.Drawing.Size(156, 32);
            this.txtMusteriTc.TabIndex = 8;
            this.txtMusteriTc.ValidatingType = typeof(int);
            // 
            // AMusteriEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 373);
            this.Controls.Add(this.txtMusteriTc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMusteriSifre);
            this.Controls.Add(this.btnAMusteriSil);
            this.Controls.Add(this.btnAMusteriDuzenle);
            this.Controls.Add(this.btnAMusteriEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AMusteriEkleSil";
            this.Text = "AMusteriEkleSil";
            this.Load += new System.EventHandler(this.AMusteriEkleSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriGirisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAMusteriEkle;
        private System.Windows.Forms.Button btnAMusteriDuzenle;
        private System.Windows.Forms.Button btnAMusteriSil;
        private System.Windows.Forms.TextBox txtMusteriSifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjeDatabaseDataSet14 projeDatabaseDataSet14;
        private System.Windows.Forms.BindingSource müşteriGirisBindingSource;
        private ProjeDatabaseDataSet14TableAdapters.MüşteriGirisTableAdapter müşteriGirisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox txtMusteriTc;
    }
}