using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VeterinerOtomasyonu
{
    public partial class AAdminEkleSil : Form
    {
        private const string connectionString = "Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True";

        public AAdminEkleSil()
        {
            InitializeComponent();
        }

        private void AAdminEkleSil_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde DataGridView'i doldur
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Veritabanından verileri çekme sorgusu
                    string selectQuery = "SELECT AdminID, AdminAd, AdminSifre FROM AdminGiris";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // DataGridView'e verileri ekleme
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private bool IsAdminAdUnique(string adminAd)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Aynı admin adı olup olmadığını kontrol eden sorgu
                    string checkQuery = "SELECT COUNT(*) FROM AdminGiris WHERE AdminAd = @AdminAd";
                    using (SqlCommand cmd = new SqlCommand(checkQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@AdminAd", adminAd);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Eğer count 0 ise admin adı benzersizdir
                        return count == 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return false;
            }
        }

        private void btnAAdminEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Aynı admin adının olup olmadığını kontrol et
                if (!IsAdminAdUnique(txtAdminAd.Text))
                {
                    MessageBox.Show("Bu admin adı zaten kullanılıyor. Lütfen farklı bir admin adı seçin.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO AdminGiris (AdminAd, AdminSifre) VALUES (@AdminAd, @AdminSifre)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@AdminAd", txtAdminAd.Text);
                        cmd.Parameters.AddWithValue("@AdminSifre", txtAdminSifre.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Yeni admin başarıyla eklendi.");
                    }
                }

                // DataGridView'i güncelle
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnAAdminSil_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Veritabanından silme işlemi için SQL sorgusu (AdminID üzerinden)
                    string deleteQuery = "DELETE FROM AdminGiris WHERE AdminID = @AdminID";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        // Parametreyi ekleyin
                        cmd.Parameters.AddWithValue("@AdminID", int.Parse(txtAdminID.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Admin başarıyla silindi.");
                        else
                            MessageBox.Show("Belirtilen admin bulunamadı.");
                    }
                }

                // DataGridView'i güncelle
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnAAdminDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                // Aynı admin adının olup olmadığını kontrol et
                if (!IsAdminAdUnique(txtAdminAd.Text))
                {
                    MessageBox.Show("Bu admin adı zaten kullanılıyor. Lütfen farklı bir admin adı seçin.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Veritabanında güncelleme işlemi için SQL sorgusu (AdminID üzerinden)
                    string updateQuery = "UPDATE AdminGiris SET AdminAd = @AdminAd, AdminSifre = @AdminSifre WHERE AdminID = @AdminID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        // Parametreleri ekleyin
                        cmd.Parameters.AddWithValue("@AdminID", int.Parse(txtAdminID.Text));
                        cmd.Parameters.AddWithValue("@AdminAd", txtAdminAd.Text);
                        cmd.Parameters.AddWithValue("@AdminSifre", txtAdminSifre.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Admin başarıyla güncellendi.");
                        else
                            MessageBox.Show("Belirtilen admin bulunamadı.");
                    }
                }

                // DataGridView'i güncelle
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView'deki bir hücreye tıklandığında çalışacak olan olay işleyici
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // TextBox'lara verileri yazma
                txtAdminID.Text = row.Cells[2].Value.ToString();
                txtAdminAd.Text = row.Cells[0].Value.ToString();
                txtAdminSifre.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
