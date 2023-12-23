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
    public partial class MusteriPanel : Form
    {
        private string tcNo;
        public MusteriPanel(string tcNo)
        {
            
            InitializeComponent();
            this.tcNo = tcNo;
        }
        
       

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HR90B83\\SQLEXPRESS;Initial Catalog=ProjeDatabase;Integrated Security=True");
        private void MusteriPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RandevuAl randevuAl = new RandevuAl(tcNo);
            randevuAl.ShowDialog();
            this.Close();
        }

        private void btnEvcilHayvanEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            PetEkle petEkle = new PetEkle(tcNo);
            petEkle.ShowDialog();
            this.Close();
            
        }

        private void btnMusteriKisiselBilgi_Click(object sender, EventArgs e)
        {
            this.Hide();
            MusteriKisiselBilgi musteriKisiselBilgi = new MusteriKisiselBilgi();
            musteriKisiselBilgi.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GecmisMuayeneler gecmisMuayeneler = new GecmisMuayeneler(tcNo);
            gecmisMuayeneler.ShowDialog();
            this.Close();
        }
    }
}
