using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VeterinerOtomasyonu
{
    public partial class VetEkleSil : Form
    {
    
        private string connectionString = "Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True";


        public VetEkleSil()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        private void btnVetEkle_Click(object sender, EventArgs e)
        {
            // VeterinerID benzersiz olmalıdır
            if (IsVeterinerIDUnique(cmbVetID.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Veteriner (VeterinerID, VeterinerAd, VeterinerSoyad) VALUES (@ID, @Ad, @Soyad)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ID", cmbVetID.Text);
                    command.Parameters.AddWithValue("@Ad", txtVetAd.Text);
                    command.Parameters.AddWithValue("@Soyad", txtVetSoyad.Text);

                    command.ExecuteNonQuery();

                    // Yeni bir kayıt ekledikten sonra DataGridView'i yenileyin
                    this.veterinerTableAdapter.Fill(this.projeDatabaseDataSet10.Veteriner);
                }
            }
            else
            {
                MessageBox.Show("Bu VeterinerID zaten kullanımda. Lütfen farklı bir VeterinerID seçin.");
            }
        }

        private bool IsVeterinerIDUnique(string vetID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Veteriner WHERE VeterinerID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", vetID);

                int count = (int)command.ExecuteScalar();

                return count == 0;
            }
        }

        private void btnVetDuzenle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbVetID.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Veteriner SET VeterinerAd = @Ad, VeterinerSoyad = @Soyad WHERE VeterinerID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ID", cmbVetID.Text);
                    command.Parameters.AddWithValue("@Ad", txtVetAd.Text);
                    command.Parameters.AddWithValue("@Soyad", txtVetSoyad.Text);

                    command.ExecuteNonQuery();

                    // Bir kaydı düzenledikten sonra DataGridView'i yenileyin
                    this.veterinerTableAdapter.Fill(this.projeDatabaseDataSet10.Veteriner);
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir veteriner kaydı seçin.");
            }
        }

        private void btnVetSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbVetID.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Veteriner WHERE VeterinerID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ID", cmbVetID.Text);

                    command.ExecuteNonQuery();

                    // Bir kaydı sildikten sonra DataGridView'i yenileyin
                    this.veterinerTableAdapter.Fill(this.projeDatabaseDataSet10.Veteriner);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir veteriner kaydı seçin.");
            }
        }

        private void VetEkleSil_Load(object sender, EventArgs e)
        {
            this.veterinerTableAdapter.Fill(this.projeDatabaseDataSet10.Veteriner);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cmbVetID.Text = row.Cells[0].Value.ToString();
                txtVetAd.Text = row.Cells[1].Value.ToString();
                txtVetSoyad.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
