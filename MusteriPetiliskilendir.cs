using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VeterinerOtomasyonu
{
    public partial class MusteriPetiliskilendir : Form
    {
        private string connectionString = "Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True";

        public MusteriPetiliskilendir()
        {
            InitializeComponent();
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView2.CellClick += DataGridView2_CellClick;
        }
        private void LoadMusteriTcData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SqlDataAdapter ve DataTable kullanarak MüşteriGiris tablosundan MusteriTc değerlerini çek
                    string query = "SELECT MusteriTc FROM MüşteriGiris";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // ComboBox'a MusteriTc değerlerini ekle
                    foreach (DataRow row in dataTable.Rows)
                    {
                        cmbMusTcNo.Items.Add(row["MusteriTc"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MusteriTc değerleri yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void MusteriPetiliskilendir_Load(object sender, EventArgs e)
        {
            LoadMusteriTcData(); // Form yüklenirken DataGridView'lere verileri yükle
            LoadData();
        }

        // Verileri DataGridView'lere yükleyen yardımcı metod
        private void LoadData()
        {
            // DataGridView1 için verileri yükle
            LoadDataGridView1Data();

            // DataGridView2 için verileri yükle
            LoadDataGridView2Data();
        }

        private void LoadDataGridView1Data()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SqlDataAdapter ve DataTable kullanarak verileri çek
                    string query = "SELECT Pet.PetCipID, Pet.PetAd, Pet.PetTur, Pet.PetCins, Pet.PetYas, HayvanVeSahip.MusteriTC " +
                                   "FROM Pet " +
                                   "INNER JOIN HayvanVeSahip ON Pet.PetCipID = HayvanVeSahip.PetCipID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView1'e DataTable'ı bağla
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void LoadDataGridView2Data()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SqlDataAdapter ve DataTable kullanarak sahibi olmayan Pet'leri çek
                    string query = "SELECT Pet.PetCipID, Pet.PetAd, Pet.PetTur, Pet.PetCins, Pet.PetYas " +
                                   "FROM Pet " +
                                   "LEFT JOIN HayvanVeSahip ON Pet.PetCipID = HayvanVeSahip.PetCipID " +
                                   "WHERE HayvanVeSahip.PetCipID IS NULL";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView2'e DataTable'ı bağla
                    dataGridView2.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sahibi olmayan Pet'leri yüklerken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnPetEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcıdan PetCipID değerini al
                    if (int.TryParse(txtPetCipNo.Text, out int petCipID))
                    {
                        // Pet tablosuna yeni bir kayıt ekleyin
                        string insertPetQuery = "INSERT INTO Pet (PetCipID, PetAd, PetTur, PetCins, PetYas) VALUES (@PetCipID, @PetAd, @PetTur, @PetCins, @PetYas)";
                        SqlCommand cmd = new SqlCommand(insertPetQuery, connection);

                        cmd.Parameters.AddWithValue("@PetCipID", petCipID);
                        cmd.Parameters.AddWithValue("@PetAd", txtPetAdi.Text);
                        cmd.Parameters.AddWithValue("@PetTur", cmbPetTur.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@PetCins", txtPetCins.Text);
                        cmd.Parameters.AddWithValue("@PetYas", Convert.ToInt32(cmbPetYas.SelectedItem.ToString()));

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Pet başarıyla eklendi.");

                        // DataGridView'leri güncelle
                        RefreshDataGridViews();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir PetCipID değeri girin.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pet eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnPetDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Pet tablosundaki bir kaydı güncelleyin
                    string updatePetQuery = "UPDATE Pet SET PetAd = @PetAd, PetTur = @PetTur, PetCins = @PetCins, PetYas = @PetYas WHERE PetCipID = @PetCipID";
                    SqlCommand cmd = new SqlCommand(updatePetQuery, connection);

                    cmd.Parameters.AddWithValue("@PetAd", txtPetAdi.Text);
                    cmd.Parameters.AddWithValue("@PetTur", cmbPetTur.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PetCins", txtPetCins.Text);
                    cmd.Parameters.AddWithValue("@PetYas", Convert.ToInt32(cmbPetYas.SelectedItem.ToString()));
                    cmd.Parameters.AddWithValue("@PetCipID", Convert.ToInt32(txtPetCipNo.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pet başarıyla güncellendi.");

                    // DataGridView'leri güncelle
                    RefreshDataGridViews();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pet güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnPetSil_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Pet tablosundan bir kaydı silin
                    string deletePetQuery = "DELETE FROM Pet WHERE PetCipID = @PetCipID";
                    SqlCommand cmd = new SqlCommand(deletePetQuery, connection);

                    cmd.Parameters.AddWithValue("@PetCipID", Convert.ToInt32(txtPetCipNo.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pet başarıyla silindi.");

                    // DataGridView'leri güncelle
                    RefreshDataGridViews();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pet silinirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnPetMusEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Pet-Müşteri ilişkisi kurun
                    string insertRelationshipQuery = "INSERT INTO HayvanVeSahip (MusteriTC, PetCipID) VALUES (@MusteriTC, @PetCipID)";
                    SqlCommand cmd = new SqlCommand(insertRelationshipQuery, connection);

                    cmd.Parameters.AddWithValue("@MusteriTC", Convert.ToInt64(cmbMusTcNo.SelectedItem.ToString()));
                    cmd.Parameters.AddWithValue("@PetCipID", Convert.ToInt32(txtPetCipNo.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Müşteri ve Pet ilişkisi başarıyla eklendi.");

                    // DataGridView'leri güncelle
                    RefreshDataGridViews();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri ve Pet ilişkisi eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnPetMusSil_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Pet-Müşteri ilişkisini silin
                    string deleteRelationshipQuery = "DELETE FROM HayvanVeSahip WHERE MusteriTC = @MusteriTC AND PetCipID = @PetCipID";
                    SqlCommand cmd = new SqlCommand(deleteRelationshipQuery, connection);

                    cmd.Parameters.AddWithValue("@MusteriTC", Convert.ToInt64(cmbMusTcNo.SelectedItem.ToString()));
                    cmd.Parameters.AddWithValue("@PetCipID", Convert.ToInt32(txtPetCipNo.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Müşteri ve Pet ilişkisi başarıyla silindi.");

                    // DataGridView'leri güncelle
                    RefreshDataGridViews();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri ve Pet ilişkisi silinirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnPetMusDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Pet-Müşteri ilişkisini güncelle
                    string updateRelationshipQuery = "UPDATE HayvanVeSahip SET MusteriTC = @MusteriTC WHERE PetCipID = @PetCipID";
                    SqlCommand cmd = new SqlCommand(updateRelationshipQuery, connection);

                    cmd.Parameters.AddWithValue("@MusteriTC", Convert.ToInt64(cmbMusTcNo.SelectedItem.ToString()));
                    cmd.Parameters.AddWithValue("@PetCipID", Convert.ToInt32(txtPetCipNo.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Müşteri ve Pet ilişkisi başarıyla güncellendi.");

                    // DataGridView'leri güncelle
                    RefreshDataGridViews();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri ve Pet ilişkisi güncellenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Populate TextBoxes with the selected row's data
                txtPetCipNo.Text = row.Cells["PetCipID"].Value.ToString();
                txtPetAdi.Text = row.Cells["PetAd"].Value.ToString();
                cmbPetTur.SelectedItem = row.Cells["PetTur"].Value.ToString();
                txtPetCins.Text = row.Cells["PetCins"].Value.ToString();
                cmbPetYas.SelectedItem = row.Cells["PetYas"].Value.ToString();
            }
        }
        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                // Populate TextBoxes with the selected row's data
                txtPetCipNo.Text = row.Cells["PetCipID"].Value.ToString();
                txtPetAdi.Text = row.Cells["PetAd"].Value.ToString();
                cmbPetTur.SelectedItem = row.Cells["PetTur"].Value.ToString();
                txtPetCins.Text = row.Cells["PetCins"].Value.ToString();
                cmbPetYas.SelectedItem = row.Cells["PetYas"].Value.ToString();
            }
        }
        // Herhangi bir ekleme, güncelleme veya silme işlemi yaptıktan sonra DataGridView'leri güncelle
        private void RefreshDataGridViews()
        {
            // DataGridView'leri temizle
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

            // Verileri tekrar yükle
            // Verileri tekrar yükle
            LoadData();
        }
    }
}
