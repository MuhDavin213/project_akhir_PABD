using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_akhir
{
    public partial class PerawatPasien : Form
    {
        public PerawatPasien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox8.Enabled = true;
            textBox7.Enabled = true;
            textBox6.Enabled = true;
            button1.Enabled = true;
        }

        private void PerawatPasien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmas_superDataSet7.Jadwal_Perawat_Pasien' table. You can move, or remove it, as needed.
            this.jadwal_Perawat_PasienTableAdapter.Fill(this.puskesmas_superDataSet7.Jadwal_Perawat_Pasien);

        }
    }
}
