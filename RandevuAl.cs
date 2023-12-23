using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinerOtomasyonu
{
    public partial class RandevuAl : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True");
        private string tcNo;

        public RandevuAl(string tcNo)
        {
            InitializeComponent();
            this.tcNo = tcNo;

            
        }
        
        private void RandevuAl_Load(object sender, EventArgs e)
        {

            
            // TODO: This line of code loads data into the 'projeDatabaseDataSet4.MusteriRandevulari' table. You can move, or remove it, as needed.
            this.musteriRandevulariTableAdapter2.Fill(this.projeDatabaseDataSet4.MusteriRandevulari);
            string query = "SELECT * FROM MusteriRandevulari WHERE MusteriTC = @tcNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@tcNo", this.tcNo);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            // TODO: This line of code loads data into the 'projeDatabaseDataSet3.HayvanVeSahip' table. You can move, or remove it, as needed.
            this.hayvanVeSahipTableAdapter.Fill(this.projeDatabaseDataSet3.HayvanVeSahip);
            // TODO: This line of code loads data into the 'projeDatabaseDataSet2.MusteriRandevulari' table. You can move, or remove it, as needed.
            this.musteriRandevulariTableAdapter1.Fill(this.projeDatabaseDataSet2.MusteriRandevulari);
            // TODO: This line of code loads data into the 'projeDatabaseDataSet1.MusteriRandevulari' table. You can move, or remove it, as needed.
            
            musteritctxt.Text = tcNo;
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

    

        private void btnVeterinerList_Click(object sender, EventArgs e)
        {
            this.Hide();
            veterinerbilgi veterinerbilgi = new veterinerbilgi();
            veterinerbilgi.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            musteritctxt.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbPetCipNo.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbVeterinerID.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbSaatler.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dateTimePicker1.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnRandevuDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                // Seçilen randevuyu düzenlemek için SQL sorgusu
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                int randevuID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value); // Varsayılan olarak randevuID'nin 0. hücrede olduğunu varsayalım
                string query = "UPDATE MusteriRandevulari SET PetCipNoID = @petCipNo, VeterinerID = @veterinerID, RandevuSaat = @saat, RandevuTarihi = @tarih WHERE RandevuID = @randevuID";
                SqlCommand command = new SqlCommand(query, connection);

                // Parametre değerlerini atama
                command.Parameters.AddWithValue("@randevuID", randevuID);
                command.Parameters.AddWithValue("@petCipNo", cmbPetCipNo.Text);
                command.Parameters.AddWithValue("@veterinerID", cmbVeterinerID.Text);
                command.Parameters.AddWithValue("@saat", cmbSaatler.Text);
                command.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);

                // Veritabanı bağlantısını aç
                connection.Open();

                // Sorguyu çalıştır
                command.ExecuteNonQuery();

                // Veritabanı bağlantısını kapat
                connection.Close();

                // DataGridView'i güncelle
                RefreshDataGridView();

                // Diğer gerekli işlemleri ekleyebilirsiniz
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu düzenlerken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            try
            {
                // Randevu almak için SQL sorgusu
                string query = "INSERT INTO MusteriRandevulari (MusteriTC, PetCipNoID, VeterinerID, RandevuSaat, RandevuTarihi) VALUES (@tcNo, @petCipNo, @veterinerID, @saat, @tarih)";
                SqlCommand command = new SqlCommand(query, connection);

                // Parametre değerlerini atama
                command.Parameters.AddWithValue("@tcNo", tcNo);
                command.Parameters.AddWithValue("@petCipNo", cmbPetCipNo.Text);
                command.Parameters.AddWithValue("@veterinerID", cmbVeterinerID.Text);
                command.Parameters.AddWithValue("@saat", cmbSaatler.Text);
                command.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);

                // Veritabanı bağlantısını aç
                connection.Open();

                // Sorguyu çalıştır
                command.ExecuteNonQuery();

                // Veritabanı bağlantısını kapat
                connection.Close();

                // DataGridView'i güncelle
                RefreshDataGridView();

                // Diğer gerekli işlemleri ekleyebilirsiniz
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu alırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            try
            {
                // Seçilen randevuyu silmek için SQL sorgusu
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                int randevuID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value); // Varsayılan olarak randevuID'nin 0. hücrede olduğunu varsayalım
                string query = "DELETE FROM MusteriRandevulari WHERE RandevuID = @randevuID";
                SqlCommand command = new SqlCommand(query, connection);

                // Parametre değerini atama
                command.Parameters.AddWithValue("@randevuID", randevuID);

                // Veritabanı bağlantısını aç
                connection.Open();

                // Sorguyu çalıştır
                command.ExecuteNonQuery();

                // Veritabanı bağlantısını kapat
                connection.Close();

                // DataGridView'i güncelle
                RefreshDataGridView();

                // Diğer gerekli işlemleri ekleyebilirsiniz
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu silerken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void RefreshDataGridView()
        {
            string query = "SELECT * FROM MusteriRandevulari WHERE MusteriTC = @tcNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@tcNo", this.tcNo);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
