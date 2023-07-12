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
    public partial class PengurusKamar : Form
    {
        public PengurusKamar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PengurusKamar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmas_superDataSet6.Jadwal_Pengurus_Kamar' table. You can move, or remove it, as needed.
            this.jadwal_Pengurus_KamarTableAdapter.Fill(this.puskesmas_superDataSet6.Jadwal_Pengurus_Kamar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih Baris yang akan di update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idJadwal = dataGridView1.SelectedRows[0].Cells["id_piket_harian_dokter"].Value.ToString();
            string hari = textBox1.Text;
            string idPerawat = textBox2.Text;
            string idkamar = textBox3.Text;

            if (idJadwal == "")
            {
                MessageBox.Show("id piket tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (hari == "")
            {
                MessageBox.Show("Masukan hari", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idPerawat == "")
            {
                MessageBox.Show("Masukan id perawat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idkamar == "")
            {
                MessageBox.Show("Masukan id kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
