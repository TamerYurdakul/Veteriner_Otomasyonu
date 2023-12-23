using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VeterinerOtomasyonu
{
    public partial class RandevularıGoster : Form
    {
        public RandevularıGoster()
        {
            InitializeComponent();
            // Form yüklendiğinde DataGridView'i güncelle
            RefreshDataGridView();
            dataGridView1.CellClick += dataGridView1_CellClick;
            cmbMusteriTc.SelectedIndexChanged += cmbMusteriTc_SelectedIndexChanged;

        }

        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği değerleri al
            string musteriTC = cmbMusteriTc.Text;
            int petCipNoID = Convert.ToInt32(cmbPetCipNoID.SelectedValue);
            int veterinerID = Convert.ToInt32(cmbVeteriner.SelectedValue);
            DateTime randevuTarihi = dateTimePicker1.Value.Date;
            TimeSpan randevuSaat = TimeSpan.Parse(cmbRandevuSaat.Text);

            // Veritabanına bağlan
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True"))
            {
                connection.Open();

                // SQL komutunu oluştur
                string sql = "INSERT INTO MusteriRandevulari (MusteriTC, PetCipNoID, VeterinerID, RandevuTarihi, RandevuSaat) " +
                             "VALUES (@MusteriTC, @PetCipNoID, @VeterinerID, @RandevuTarihi, @RandevuSaat)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Parametreleri ata
                    command.Parameters.AddWithValue("@MusteriTC", musteriTC);
                    command.Parameters.AddWithValue("@PetCipNoID", petCipNoID);
                    command.Parameters.AddWithValue("@VeterinerID", veterinerID);
                    command.Parameters.AddWithValue("@RandevuTarihi", randevuTarihi);
                    command.Parameters.AddWithValue("@RandevuSaat", randevuSaat);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();

                    MessageBox.Show("Randevu başarıyla eklendi.");
                }
            }

            // DataGridView'i güncelle
            RefreshDataGridView();
        }

        private void btnRandevuDuzenle_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği RandevuID'yi al
            int randevuID;
            if (!int.TryParse(lblRandevuID.Text, out randevuID))
            {
                MessageBox.Show("Lütfen geçerli bir RandevuID seçin.");
                return;
            }

            // Kullanıcının güncellemek istediği değerleri al
            string musteriTC = cmbMusteriTc.Text;
            int petCipNoID = Convert.ToInt32(cmbPetCipNoID.SelectedValue);
            int veterinerID = Convert.ToInt32(cmbVeteriner.SelectedValue);
            DateTime randevuTarihi = dateTimePicker1.Value.Date;
            TimeSpan randevuSaat = TimeSpan.Parse(cmbRandevuSaat.Text);

            // Veritabanına bağlan
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True"))
            {
                connection.Open();

                // SQL komutunu oluştur
                string sql = "UPDATE MusteriRandevulari " +
                             "SET MusteriTC = @MusteriTC, PetCipNoID = @PetCipNoID, VeterinerID = @VeterinerID, RandevuTarihi = @RandevuTarihi, RandevuSaat = @RandevuSaat " +
                             "WHERE RandevuID = @RandevuID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Parametreleri ata
                    command.Parameters.AddWithValue("@MusteriTC", musteriTC);
                    command.Parameters.AddWithValue("@PetCipNoID", petCipNoID);
                    command.Parameters.AddWithValue("@VeterinerID", veterinerID);
                    command.Parameters.AddWithValue("@RandevuTarihi", randevuTarihi);
                    command.Parameters.AddWithValue("@RandevuSaat", randevuSaat);
                    command.Parameters.AddWithValue("@RandevuID", randevuID);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();

                    MessageBox.Show("Randevu başarıyla güncellendi.");
                }
            }

            // DataGridView'i güncelle
            RefreshDataGridView();
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği RandevuID'yi al
            int randevuID;
            if (!int.TryParse(lblRandevuID.Text, out randevuID))
            {
                MessageBox.Show("Lütfen geçerli bir RandevuID seçin.");
                return;
            }

            // Veritabanına bağlan
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True"))
            {
                connection.Open();

                // SQL komutunu oluştur
                string sql = "DELETE FROM MusteriRandevulari WHERE RandevuID = @RandevuID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Parametreyi ata
                    command.Parameters.AddWithValue("@RandevuID", randevuID);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();

                    MessageBox.Show("Randevu başarıyla silindi.");
                }
            }

            // DataGridView'i güncelle
            RefreshDataGridView();
        }


        // DataGridView'i güncelleyen metod
        private void RefreshDataGridView()
        {
            // Veritabanından verileri çek
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True"))
            {
                connection.Open();

                string sql = "SELECT * FROM MusteriRandevulari";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            // DataGridView'e verileri yükle
            dataGridView1.DataSource = dataTable;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Seçilen satırdaki değerleri al
                string musteriTC = row.Cells[0].Value.ToString();
                int petCipNoID = Convert.ToInt32(row.Cells[1].Value);
                int veterinerID = Convert.ToInt32(row.Cells[2].Value);
                DateTime randevuTarihi = Convert.ToDateTime(row.Cells[3].Value);
                TimeSpan randevuSaat = TimeSpan.Parse(row.Cells[4].Value.ToString());

                // ComboBox'ları güncelle
                cmbMusteriTc.Text = musteriTC;
                cmbPetCipNoID.SelectedValue = petCipNoID;
                cmbVeteriner.SelectedValue = veterinerID;
                dateTimePicker1.Value = randevuTarihi;
                cmbRandevuSaat.Text = randevuSaat.ToString();

                // Seçilen satırdaki RandevuID'yi etikete ata
                lblRandevuID.Text = row.Cells[5].Value.ToString();
            }
        }

        private void cmbMusteriTc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen müşteri TC'sini al
            string musteriTC = cmbMusteriTc.Text;

            // Veritabanından müşteri TC'sine ait petleri çek
            DataTable petDataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True"))
            {
                connection.Open();

                string sql = "SELECT PetCipID FROM HayvanVeSahip WHERE MusteriTC = @MusteriTC";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MusteriTC", musteriTC);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    try
                    {
                        adapter.Fill(petDataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Pet bilgileri çekilirken bir hata oluştu: " + ex.Message);
                        return;
                    }
                }
            }

            // ComboBox'ı temizle
            cmbPetCipNoID.DataSource = null;
            cmbPetCipNoID.Items.Clear();

            // Eğer petDataTable'da veri varsa, ComboBox'a petleri yükle
            if (petDataTable.Rows.Count > 0)
            {
                cmbPetCipNoID.DataSource = petDataTable;
                cmbPetCipNoID.DisplayMember = "PetCipID";
                cmbPetCipNoID.ValueMember = "PetCipID";
            }
            else
            {
                MessageBox.Show("Seçilen müşteriye ait pet bulunamadı.");
            }
        }




        // Form yüklendiğinde çalışan metod
        private void RandevularıGoster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projeDatabaseDataSet19.Veteriner' table. You can move, or remove it, as needed.
            this.veterinerTableAdapter.Fill(this.projeDatabaseDataSet19.Veteriner);
            // TODO: This line of code loads data into the 'projeDatabaseDataSet18.Pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.projeDatabaseDataSet18.Pet);
            // TODO: This line of code loads data into the 'projeDatabaseDataSet17.MüşteriGiris' table. You can move, or remove it, as needed.
            this.müşteriGirisTableAdapter.Fill(this.projeDatabaseDataSet17.MüşteriGiris);
            // TODO: This line of code loads data into the 'projeDatabaseDataSet16.MusteriRandevulari' table. You can move, or remove it, as needed.
            this.musteriRandevulariTableAdapter.Fill(this.projeDatabaseDataSet16.MusteriRandevulari);
        }
    }
}
