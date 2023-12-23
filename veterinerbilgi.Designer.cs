namespace VeterinerOtomasyonu
{
    partial class veterinerbilgi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.veterinerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinerAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinerSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDatabaseDataSet5 = new VeterinerOtomasyonu.ProjeDatabaseDataSet5();
            this.veterinerTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSet5TableAdapters.VeterinerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.veterinerIDDataGridViewTextBoxColumn,
            this.veterinerAdDataGridViewTextBoxColumn,
            this.veterinerSoyadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.veterinerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 176);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // veterinerIDDataGridViewTextBoxColumn
            // 
            this.veterinerIDDataGridViewTextBoxColumn.DataPropertyName = "VeterinerID";
            this.veterinerIDDataGridViewTextBoxColumn.HeaderText = "VeterinerID";
            this.veterinerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veterinerIDDataGridViewTextBoxColumn.Name = "veterinerIDDataGridViewTextBoxColumn";
            this.veterinerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.veterinerIDDataGridViewTextBoxColumn.Width = 103;
            // 
            // veterinerAdDataGridViewTextBoxColumn
            // 
            this.veterinerAdDataGridViewTextBoxColumn.DataPropertyName = "VeterinerAd";
            this.veterinerAdDataGridViewTextBoxColumn.HeaderText = "VeterinerAd";
            this.veterinerAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veterinerAdDataGridViewTextBoxColumn.Name = "veterinerAdDataGridViewTextBoxColumn";
            this.veterinerAdDataGridViewTextBoxColumn.ReadOnly = true;
            this.veterinerAdDataGridViewTextBoxColumn.Width = 107;
            // 
            // veterinerSoyadDataGridViewTextBoxColumn
            // 
            this.veterinerSoyadDataGridViewTextBoxColumn.DataPropertyName = "VeterinerSoyad";
            this.veterinerSoyadDataGridViewTextBoxColumn.HeaderText = "VeterinerSoyad";
            this.veterinerSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veterinerSoyadDataGridViewTextBoxColumn.Name = "veterinerSoyadDataGridViewTextBoxColumn";
            this.veterinerSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.veterinerSoyadDataGridViewTextBoxColumn.Width = 130;
            // 
            // veterinerBindingSource
            // 
            this.veterinerBindingSource.DataMember = "Veteriner";
            this.veterinerBindingSource.DataSource = this.projeDatabaseDataSet5;
            // 
            // projeDatabaseDataSet5
            // 
            this.projeDatabaseDataSet5.DataSetName = "ProjeDatabaseDataSet5";
            this.projeDatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veterinerTableAdapter
            // 
            this.veterinerTableAdapter.ClearBeforeFill = true;
            // 
            // veterinerbilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 176);
            this.Controls.Add(this.dataGridView1);
            this.Name = "veterinerbilgi";
            this.Text = "veterinerbilgi";
            this.Load += new System.EventHandler(this.veterinerbilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjeDatabaseDataSet5 projeDatabaseDataSet5;
        private System.Windows.Forms.BindingSource veterinerBindingSource;
        private ProjeDatabaseDataSet5TableAdapters.VeterinerTableAdapter veterinerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinerAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinerSoyadDataGridViewTextBoxColumn;
    }
}