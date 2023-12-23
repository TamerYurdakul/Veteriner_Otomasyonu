using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinerOtomasyonu
{
    public partial class MusteriGiris : Form
    {
        public MusteriGiris()
        {
            InitializeComponent();
        }

        public static string tcNo;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            tcNo = mskTcNo.Text;
            String MusteriTCNo = mskTcNo.Text;
            string MusteriSifre = txtMusteriSifre.Text;
            try
            {
                // Bağlantı açılır.
                baglanti.Open();

                // SQL sorgusu oluşturulur (tablonuz ve sütun adlarınıza göre düzenleyin).
                string sqlSorgusu = "SELECT COUNT(*) FROM MüşteriGiris WHERE MusteriTC = @b1 AND MusteriSifre = @b2";

                // SqlCommand oluşturulur.
                using (SqlCommand komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    // Parametreler eklenir.
                    komut.Parameters.AddWithValue("@b1", MusteriTCNo);
                    komut.Parameters.AddWithValue("@b2", MusteriSifre);

                    // Sorgu çalıştırılır.
                    int kullaniciSayisi = (int)komut.ExecuteScalar();

                    // Kullanıcı varsa, giriş başarılıdır.
                    if (kullaniciSayisi > 0)
                    {
                        this.Hide();
                        MusteriPanel MusteriPanel = new MusteriPanel(tcNo);
                        MusteriPanel.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantı kapatılır.
                baglanti.Close();
            }

        }

        private void MusteriGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
