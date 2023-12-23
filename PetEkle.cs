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
    public partial class PetEkle : Form
    {
        private string tcNo;
        public PetEkle(string tcNo)
        {
            this.tcNo = tcNo;
            InitializeComponent();
        }

        private void PetEkle_Load(object sender, EventArgs e)
        {
            txtTcNo.Text=tcNo;
        }

        private void btnMusteriPetKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                // Establish a connection to your SQL Server
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True"))
                {
                    connection.Open();

                    // Insert data into "HayvanVeSahip" table
                 

                    // Insert data into "Pet" table
                    string petInsertQuery = "INSERT INTO Pet (PetCipID,PetAd,PetTur,PetCins,PetYas) VALUES (@PetCipID, @PetAd,@PetTur,@PetCins,@PetYas)";
                    using (SqlCommand cmdPet = new SqlCommand(petInsertQuery, connection))
                    {
                        cmdPet.Parameters.AddWithValue("@PetCipID", txtPetCipNo.Text);
                        cmdPet.Parameters.AddWithValue("@PetAd", txtPetAdi.Text);
                        cmdPet.Parameters.AddWithValue("@PetTur", cmbPetTur.Text);
                        cmdPet.Parameters.AddWithValue("@PetCins",txtPetCins.Text);
                        cmdPet.Parameters.AddWithValue("@PetYas", Convert.ToInt32(cmbPetYas.Text));
                        // Add other parameters for "OtherPetColumns" in your table

                        // Execute the query
                        cmdPet.ExecuteNonQuery();
                    }
                    string hayvanVeSahipInsertQuery = "INSERT INTO HayvanVeSahip (PetCipID,MusteriTC) VALUES (@PetCipID, @TcNo)";
                    using (SqlCommand cmdHayvanVeSahip = new SqlCommand(hayvanVeSahipInsertQuery, connection))
                    {
                        cmdHayvanVeSahip.Parameters.AddWithValue("@PetCipID", txtPetCipNo.Text);
                        cmdHayvanVeSahip.Parameters.AddWithValue("@TcNo", txtTcNo.Text);
                        // Add other parameters for "OtherColumns" in your table

                        // Execute the query
                        cmdHayvanVeSahip.ExecuteNonQuery();
                    }
                    connection.Close();

                }

                MessageBox.Show("Data inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMusteriPetListele_Click(object sender, EventArgs e)
        {
            
            MPetListele mPetListele = new MPetListele(tcNo);
            mPetListele.ShowDialog();
        }
    }
}
