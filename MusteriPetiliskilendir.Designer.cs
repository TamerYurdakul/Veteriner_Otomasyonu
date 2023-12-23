namespace VeterinerOtomasyonu
{
    partial class MusteriPetiliskilendir
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtPetAdi = new System.Windows.Forms.TextBox();
            this.cmbPetYas = new System.Windows.Forms.ComboBox();
            this.cmbPetTur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPetCins = new System.Windows.Forms.TextBox();
            this.txtPetCipNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.projeDatabaseDataSet15 = new VeterinerOtomasyonu.ProjeDatabaseDataSet15();
            this.müşteriGirisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.müşteriGirisTableAdapter = new VeterinerOtomasyonu.ProjeDatabaseDataSet15TableAdapters.MüşteriGirisTableAdapter();
            this.btnPetDuzenle = new System.Windows.Forms.Button();
            this.btnPetEkle = new System.Windows.Forms.Button();
            this.btnPetSil = new System.Windows.Forms.Button();
            this.btnPetMusEkle = new System.Windows.Forms.Button();
            this.btnPetMusDuzenle = new System.Windows.Forms.Button();
            this.btnPetMusSil = new System.Windows.Forms.Button();
            this.cmbMusTcNo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriGirisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 27;
            this.label6.Text = "Pet Adı:";
            // 
            // txtPetAdi
            // 
            this.txtPetAdi.Location = new System.Drawing.Point(291, 123);
            this.txtPetAdi.Name = "txtPetAdi";
            this.txtPetAdi.Size = new System.Drawing.Size(160, 32);
            this.txtPetAdi.TabIndex = 17;
            // 
            // cmbPetYas
            // 
            this.cmbPetYas.FormattingEnabled = true;
            this.cmbPetYas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cmbPetYas.Location = new System.Drawing.Point(291, 245);
            this.cmbPetYas.Name = "cmbPetYas";
            this.cmbPetYas.Size = new System.Drawing.Size(160, 34);
            this.cmbPetYas.TabIndex = 25;
            // 
            // cmbPetTur
            // 
            this.cmbPetTur.FormattingEnabled = true;
            this.cmbPetTur.Items.AddRange(new object[] {
            "Köpek",
            "Kedi",
            "Kuş",
            "Balık",
            "Kemirgen",
            "Sürüngen",
            "Tavuk",
            "Tavşan"});
            this.cmbPetTur.Location = new System.Drawing.Point(291, 161);
            this.cmbPetTur.Name = "cmbPetTur";
            this.cmbPetTur.Size = new System.Drawing.Size(160, 34);
            this.cmbPetTur.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Pet Yaş:";
            // 
            // txtPetCins
            // 
            this.txtPetCins.Location = new System.Drawing.Point(291, 202);
            this.txtPetCins.Name = "txtPetCins";
            this.txtPetCins.Size = new System.Drawing.Size(160, 32);
            this.txtPetCins.TabIndex = 23;
            // 
            // txtPetCipNo
            // 
            this.txtPetCipNo.Location = new System.Drawing.Point(291, 81);
            this.txtPetCipNo.Name = "txtPetCipNo";
            this.txtPetCipNo.Size = new System.Drawing.Size(160, 32);
            this.txtPetCipNo.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Pet Cins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pet Tür:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pet Çip No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "TC No:";
            // 
            // projeDatabaseDataSet15
            // 
            this.projeDatabaseDataSet15.DataSetName = "ProjeDatabaseDataSet15";
            this.projeDatabaseDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müşteriGirisBindingSource
            // 
            this.müşteriGirisBindingSource.DataMember = "MüşteriGiris";
            this.müşteriGirisBindingSource.DataSource = this.projeDatabaseDataSet15;
            // 
            // müşteriGirisTableAdapter
            // 
            this.müşteriGirisTableAdapter.ClearBeforeFill = true;
            // 
            // btnPetDuzenle
            // 
            this.btnPetDuzenle.Location = new System.Drawing.Point(525, 110);
            this.btnPetDuzenle.Name = "btnPetDuzenle";
            this.btnPetDuzenle.Size = new System.Drawing.Size(247, 64);
            this.btnPetDuzenle.TabIndex = 30;
            this.btnPetDuzenle.Text = "Sistemdeki Peti Düzenle";
            this.btnPetDuzenle.UseVisualStyleBackColor = true;
            this.btnPetDuzenle.Click += new System.EventHandler(this.btnPetDuzenle_Click);
            // 
            // btnPetEkle
            // 
            this.btnPetEkle.Location = new System.Drawing.Point(525, 39);
            this.btnPetEkle.Name = "btnPetEkle";
            this.btnPetEkle.Size = new System.Drawing.Size(247, 64);
            this.btnPetEkle.TabIndex = 31;
            this.btnPetEkle.Text = "Sisteme Pet Ekle";
            this.btnPetEkle.UseVisualStyleBackColor = true;
            this.btnPetEkle.Click += new System.EventHandler(this.btnPetEkle_Click);
            // 
            // btnPetSil
            // 
            this.btnPetSil.Location = new System.Drawing.Point(525, 194);
            this.btnPetSil.Name = "btnPetSil";
            this.btnPetSil.Size = new System.Drawing.Size(247, 65);
            this.btnPetSil.TabIndex = 32;
            this.btnPetSil.Text = "Sistemdeki Peti Sil";
            this.btnPetSil.UseVisualStyleBackColor = true;
            this.btnPetSil.Click += new System.EventHandler(this.btnPetSil_Click);
            // 
            // btnPetMusEkle
            // 
            this.btnPetMusEkle.Location = new System.Drawing.Point(806, 47);
            this.btnPetMusEkle.Name = "btnPetMusEkle";
            this.btnPetMusEkle.Size = new System.Drawing.Size(224, 57);
            this.btnPetMusEkle.TabIndex = 33;
            this.btnPetMusEkle.Text = "Müşteriye Pet Ekle";
            this.btnPetMusEkle.UseVisualStyleBackColor = true;
            this.btnPetMusEkle.Click += new System.EventHandler(this.btnPetMusEkle_Click);
            // 
            // btnPetMusDuzenle
            // 
            this.btnPetMusDuzenle.Location = new System.Drawing.Point(806, 126);
            this.btnPetMusDuzenle.Name = "btnPetMusDuzenle";
            this.btnPetMusDuzenle.Size = new System.Drawing.Size(224, 57);
            this.btnPetMusDuzenle.TabIndex = 34;
            this.btnPetMusDuzenle.Text = "Müşteri Pet Düzenle";
            this.btnPetMusDuzenle.UseVisualStyleBackColor = true;
            this.btnPetMusDuzenle.Click += new System.EventHandler(this.btnPetMusDuzenle_Click);
            // 
            // btnPetMusSil
            // 
            this.btnPetMusSil.Location = new System.Drawing.Point(806, 202);
            this.btnPetMusSil.Name = "btnPetMusSil";
            this.btnPetMusSil.Size = new System.Drawing.Size(224, 57);
            this.btnPetMusSil.TabIndex = 35;
            this.btnPetMusSil.Text = "Müşteri Pet Sil";
            this.btnPetMusSil.UseVisualStyleBackColor = true;
            this.btnPetMusSil.Click += new System.EventHandler(this.btnPetMusSil_Click);
            // 
            // cmbMusTcNo
            // 
            this.cmbMusTcNo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.müşteriGirisBindingSource, "MusteriTc", true));
            this.cmbMusTcNo.FormattingEnabled = true;
            this.cmbMusTcNo.Location = new System.Drawing.Point(291, 39);
            this.cmbMusTcNo.Name = "cmbMusTcNo";
            this.cmbMusTcNo.Size = new System.Drawing.Size(160, 34);
            this.cmbMusTcNo.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 213);
            this.dataGridView1.TabIndex = 37;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(969, 324);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(578, 213);
            this.dataGridView2.TabIndex = 38;
            // 
            // MusteriPetiliskilendir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 690);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbMusTcNo);
            this.Controls.Add(this.btnPetMusSil);
            this.Controls.Add(this.btnPetMusDuzenle);
            this.Controls.Add(this.btnPetMusEkle);
            this.Controls.Add(this.btnPetSil);
            this.Controls.Add(this.btnPetEkle);
            this.Controls.Add(this.btnPetDuzenle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPetAdi);
            this.Controls.Add(this.cmbPetYas);
            this.Controls.Add(this.cmbPetTur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPetCins);
            this.Controls.Add(this.txtPetCipNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MusteriPetiliskilendir";
            this.Text = "MusteriPetiliskilendir";
            this.Load += new System.EventHandler(this.MusteriPetiliskilendir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projeDatabaseDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriGirisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPetAdi;
        private System.Windows.Forms.ComboBox cmbPetYas;
        private System.Windows.Forms.ComboBox cmbPetTur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPetCins;
        private System.Windows.Forms.TextBox txtPetCipNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ProjeDatabaseDataSet15 projeDatabaseDataSet15;
        private System.Windows.Forms.BindingSource müşteriGirisBindingSource;
        private ProjeDatabaseDataSet15TableAdapters.MüşteriGirisTableAdapter müşteriGirisTableAdapter;
        private System.Windows.Forms.Button btnPetDuzenle;
        private System.Windows.Forms.Button btnPetEkle;
        private System.Windows.Forms.Button btnPetSil;
        private System.Windows.Forms.Button btnPetMusEkle;
        private System.Windows.Forms.Button btnPetMusDuzenle;
        private System.Windows.Forms.Button btnPetMusSil;
        private System.Windows.Forms.ComboBox cmbMusTcNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}