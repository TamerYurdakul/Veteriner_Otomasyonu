namespace VeterinerOtomasyonu
{
    partial class PetEkle
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
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPetCipNo = new System.Windows.Forms.TextBox();
            this.txtPetCins = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMusteriPetKaydet = new System.Windows.Forms.Button();
            this.btnMusteriPetListele = new System.Windows.Forms.Button();
            this.cmbPetTur = new System.Windows.Forms.ComboBox();
            this.cmbPetYas = new System.Windows.Forms.ComboBox();
            this.txtPetAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(202, 39);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.ReadOnly = true;
            this.txtTcNo.Size = new System.Drawing.Size(160, 32);
            this.txtTcNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pet Çip No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pet Tür:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pet Cins:";
            // 
            // txtPetCipNo
            // 
            this.txtPetCipNo.Location = new System.Drawing.Point(202, 117);
            this.txtPetCipNo.Name = "txtPetCipNo";
            this.txtPetCipNo.Size = new System.Drawing.Size(160, 32);
            this.txtPetCipNo.TabIndex = 2;
            // 
            // txtPetCins
            // 
            this.txtPetCins.Location = new System.Drawing.Point(202, 200);
            this.txtPetCins.Name = "txtPetCins";
            this.txtPetCins.Size = new System.Drawing.Size(160, 32);
            this.txtPetCins.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pet Yaş:";
            // 
            // btnMusteriPetKaydet
            // 
            this.btnMusteriPetKaydet.Location = new System.Drawing.Point(518, 58);
            this.btnMusteriPetKaydet.Name = "btnMusteriPetKaydet";
            this.btnMusteriPetKaydet.Size = new System.Drawing.Size(191, 100);
            this.btnMusteriPetKaydet.TabIndex = 6;
            this.btnMusteriPetKaydet.Text = "Evcil Hayvanımı Kaydet";
            this.btnMusteriPetKaydet.UseVisualStyleBackColor = true;
            this.btnMusteriPetKaydet.Click += new System.EventHandler(this.btnMusteriPetKaydet_Click);
            // 
            // btnMusteriPetListele
            // 
            this.btnMusteriPetListele.Location = new System.Drawing.Point(518, 159);
            this.btnMusteriPetListele.Name = "btnMusteriPetListele";
            this.btnMusteriPetListele.Size = new System.Drawing.Size(191, 105);
            this.btnMusteriPetListele.TabIndex = 7;
            this.btnMusteriPetListele.Text = "Evcil Hayvanlarımı Bilgilerimi Listele";
            this.btnMusteriPetListele.UseVisualStyleBackColor = true;
            this.btnMusteriPetListele.Click += new System.EventHandler(this.btnMusteriPetListele_Click);
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
            this.cmbPetTur.Location = new System.Drawing.Point(202, 159);
            this.cmbPetTur.Name = "cmbPetTur";
            this.cmbPetTur.Size = new System.Drawing.Size(160, 34);
            this.cmbPetTur.TabIndex = 3;
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
            this.cmbPetYas.Location = new System.Drawing.Point(202, 243);
            this.cmbPetYas.Name = "cmbPetYas";
            this.cmbPetYas.Size = new System.Drawing.Size(160, 34);
            this.cmbPetYas.TabIndex = 5;
            // 
            // txtPetAdi
            // 
            this.txtPetAdi.Location = new System.Drawing.Point(202, 79);
            this.txtPetAdi.Name = "txtPetAdi";
            this.txtPetAdi.Size = new System.Drawing.Size(160, 32);
            this.txtPetAdi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pet Adı:";
            // 
            // PetEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 417);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPetAdi);
            this.Controls.Add(this.cmbPetYas);
            this.Controls.Add(this.cmbPetTur);
            this.Controls.Add(this.btnMusteriPetListele);
            this.Controls.Add(this.btnMusteriPetKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPetCins);
            this.Controls.Add(this.txtPetCipNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTcNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PetEkle";
            this.Text = "PetEkle";
            this.Load += new System.EventHandler(this.PetEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPetCipNo;
        private System.Windows.Forms.TextBox txtPetCins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMusteriPetKaydet;
        private System.Windows.Forms.Button btnMusteriPetListele;
        private System.Windows.Forms.ComboBox cmbPetTur;
        private System.Windows.Forms.ComboBox cmbPetYas;
        private System.Windows.Forms.TextBox txtPetAdi;
        private System.Windows.Forms.Label label6;
    }
}