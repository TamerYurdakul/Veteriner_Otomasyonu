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
    public partial class veterinerbilgi : Form
    {
        public veterinerbilgi()
        {
            InitializeComponent();
        }

        private void veterinerbilgi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projeDatabaseDataSet5.Veteriner' table. You can move, or remove it, as needed.
            this.veterinerTableAdapter.Fill(this.projeDatabaseDataSet5.Veteriner);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
