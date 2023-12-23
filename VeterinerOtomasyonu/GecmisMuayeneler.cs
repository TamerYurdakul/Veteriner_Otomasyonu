using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VeterinerOtomasyonu
{
    public partial class GecmisMuayeneler : Form
    {
        private string musteriTC;

        public GecmisMuayeneler(string musteriTC)
        {
            InitializeComponent();
            this.musteriTC = musteriTC;
        }

        private void GecmisMuayeneler_Load(object sender, EventArgs e)
        {
            // Müşterinin geçmiş randevularını getiren sorgu
            string query = "SELECT Muayene.MuayeneID, Muayene.PetCipID, Muayene.MuayeneTarihi, Muayene.MuayeneNotu, TedaviMasraflari.TedaviTarihi, TedaviMasraflari.TedaviAciklama, TedaviMasraflari.Masraf " +
                           "FROM Muayene " +
                           "JOIN TedaviMasraflari ON Muayene.MuayeneID = TedaviMasraflari.MuayeneID " +
                           "WHERE Muayene.PetCipID IN (SELECT PetCipID FROM HayvanVeSahip WHERE MusteriTC = @MusteriTC)";

            // Veritabanı bağlantısı
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True"))
            {
                connection.Open();
                // Parametreli sorgu kullanımı
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MusteriTC", musteriTC);

                    // Verileri çekme
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'e veriyi yükleme
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
    }
}
