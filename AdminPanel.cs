using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinerOtomasyonu
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            

        }

        private void btnKullanıcıEkleSil_Click(object sender, EventArgs e)
        {
            this.Hide();
            AMusteriEkleSil aMusteriEkleSil = new AMusteriEkleSil(); 
            aMusteriEkleSil.ShowDialog();
        }

        private void btnAdminEkleSil_Click(object sender, EventArgs e)
        {
            AAdminEkleSil aAdminEkleSil = new AAdminEkleSil();  
            aAdminEkleSil.ShowDialog();
        }

        private void btnVetEkleSil_Click(object sender, EventArgs e)
        {
            VetEkleSil vetEkleSil = new VetEkleSil();   
            vetEkleSil.ShowDialog();
        }

        private void btnMusteriveHayvan_Click(object sender, EventArgs e)
        {
            MusteriPetiliskilendir musteriPetiliskilendir = new MusteriPetiliskilendir();
            musteriPetiliskilendir.ShowDialog();
        }

        private void btnRandevularıGoster_Click(object sender, EventArgs e)
        {
            RandevularıGoster randevularıGoster = new RandevularıGoster();
            randevularıGoster.ShowDialog();
        }

        private void btnMuayeOlustur_Click(object sender, EventArgs e)
        {
            MuayeneOlustur muayeneOlustur = new MuayeneOlustur();
            muayeneOlustur.ShowDialog();
        }

        private void btnGecmisMuayeneKayıtlari_Click(object sender, EventArgs e)
        {

        }

        private void btnFaturaOlustur_Click(object sender, EventArgs e)
        {

        }
    }
}
