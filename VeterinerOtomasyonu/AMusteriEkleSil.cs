using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VeterinerOtomasyonu
{
    public partial class AMusteriEkleSil : Form
    {
        private const string connectionString = "Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True";

        public AMusteriEkleSil()
        {
            InitializeComponent();
        }

        private void AMusteriEkleSil_Load(object sender, EventArgs e)
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
                    string selectQuery = "SELECT MusteriTc, MusteriSifre FROM MüşteriGiris";

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

        private bool IsMusteriTcUnique(string musteriTc)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Aynı müşteri TC'sinin olup olmadığını kontrol eden sorgu
                    string checkQuery = "SELECT COUNT(*) FROM MüşteriGiris WHERE MusteriTc = @MusteriTc";
                    using (SqlCommand cmd = new SqlCommand(checkQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MusteriTc", musteriTc);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Eğer count 0 ise müşteri TC benzersizdir
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

        private void DeleteAssociatedData(SqlConnection connection, string musteriTc)
        {
            SqlTransaction transaction = null;

            try
            {
                // Transaction başlat
                transaction = connection.BeginTransaction();

                // PetCipID'leri al
                List<string> petCipIds = new List<string>();
                string selectPetCipIdQuery = "SELECT PetCipID FROM HayvanVeSahip WHERE MusteriTC = @MusteriTC";
                using (SqlCommand cmd = new SqlCommand(selectPetCipIdQuery, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@MusteriTC", musteriTc);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int petCipIdInt = reader.GetInt32(0); // Veriyi int olarak oku
                            string petCipId = petCipIdInt.ToString(); // int değerini string'e dönüştür
                            petCipIds.Add(petCipId); // Listeye ekle
                        }
                    }
                }

                // Diğer tablolardaki verileri silme işlemi için SQL sorguları
                string[] deleteQueries = new string[]
                {
            "DELETE FROM HayvanVeSahip WHERE MusteriTC = @MusteriTC",
            "DELETE FROM Muayene WHERE PetCipID IN (SELECT PetCipID FROM HayvanVeSahip WHERE MusteriTC = @MusteriTC)",
            "DELETE FROM MusteriRandevulari WHERE MusteriTC = @MusteriTC",
                    // Diğer tablolar varsa buraya ekleyebilirsiniz
                };

                foreach (var deleteQuery in deleteQueries)
                {
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MusteriTC", musteriTc);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Pet tablosundan müşteriye ait hayvan bilgilerini silme işlemi
                foreach (var petCipId in petCipIds)
                {
                    string deletePetQuery = "DELETE FROM Pet WHERE PetCipID = @PetCipID";
                    using (SqlCommand cmd = new SqlCommand(deletePetQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@PetCipID", petCipId);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Müşteriyi silme işlemi
                string deleteMusteriQuery = "DELETE FROM MüşteriGiris WHERE MusteriTc = @MusteriTC";
                using (SqlCommand cmd = new SqlCommand(deleteMusteriQuery, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@MusteriTC", musteriTc);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Müşteri başarıyla silindi ve ilgili bilgiler temizlendi.");
                        // Commit işlemi
                        transaction.Commit();
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen müşteri bulunamadı.");
                        // Hata durumunda geri alma işlemi
                        transaction.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda geri alma işlemi
                transaction?.Rollback();
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }





        private void btnAMusteriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Aynı müşteri TC'sinin olup olmadığını kontrol et
                if (!IsMusteriTcUnique(txtMusteriTc.Text))
                {
                    MessageBox.Show("Bu müşteri TC zaten kullanılıyor. Lütfen farklı bir müşteri TC seçin.");
                    return;
                }

                // TC numarasının 11 haneli olup olmadığını kontrol et
                if (txtMusteriTc.Text.Length != 11)
                {
                    MessageBox.Show("Müşteri TC numarası 11 haneli olmalıdır.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO MüşteriGiris (MusteriTc, MusteriSifre) VALUES (@MusteriTc, @MusteriSifre)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MusteriTc", txtMusteriTc.Text);
                        cmd.Parameters.AddWithValue("@MusteriSifre", txtMusteriSifre.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Yeni müşteri başarıyla eklendi.");
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

        private void btnAMusteriSil_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // İlgili diğer tablolardaki verileri temizle
                    DeleteAssociatedData(connection, txtMusteriTc.Text);
                }

                // DataGridView'i güncelle
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnAMusteriDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Veritabanında güncelleme işlemi için SQL sorgusu (MusteriTc üzerinden)
                    string updateQuery = "UPDATE MüşteriGiris SET MusteriSifre = @MusteriSifre WHERE MusteriTc = @MusteriTc";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        // Parametreleri ekleyin
                        cmd.Parameters.AddWithValue("@MusteriTc", txtMusteriTc.Text);
                        cmd.Parameters.AddWithValue("@MusteriSifre", txtMusteriSifre.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Müşteri başarıyla güncellendi.");
                        else
                            MessageBox.Show("Belirtilen müşteri bulunamadı.");
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
                txtMusteriTc.Text = row.Cells[0].Value.ToString();
                txtMusteriSifre.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
