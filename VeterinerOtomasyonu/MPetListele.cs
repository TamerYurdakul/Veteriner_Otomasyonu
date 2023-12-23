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
    public partial class MPetListele : Form
    {
        private string tcNo;

        public MPetListele(string tcNo)
        {
            InitializeComponent();
            this.tcNo = tcNo;
        }

        private void MPetListele_Load(object sender, EventArgs e)
        {
            // İki tabloyu birleştirilmiş sorgu ile çekme
            DataTable mergedTable = new DataTable();
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT Pet.PetAd, Pet.PetTur, Pet.PetCins, Pet.PetYas, HayvanVeSahip.HayvanSahipID, HayvanVeSahip.MusteriTC FROM Pet JOIN HayvanVeSahip ON Pet.PetCipID = HayvanVeSahip.PetCipID WHERE HayvanVeSahip.MusteriTC = @TCNo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TCNo", tcNo);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(mergedTable);
                }
            }

            // DataGridView'e veriyi yükleme
            dataGridView1.DataSource = mergedTable;
        }
    }

}
