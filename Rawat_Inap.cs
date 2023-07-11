using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_akhir
{
    public partial class Rawat_Inap : Form
    {
        public Rawat_Inap()
        {
            InitializeComponent();
        }

        private void Piket_Harian_Dokter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmas_superDataSet3.Jadwal_Perawat_Pasien' table. You can move, or remove it, as needed.
            this.jadwal_Perawat_PasienTableAdapter.Fill(this.puskesmas_superDataSet3.Jadwal_Perawat_Pasien);
            // TODO: This line of code loads data into the 'puskesmas_superDataSet2.Perawat' table. You can move, or remove it, as needed.
            this.perawatTableAdapter.Fill(this.puskesmas_superDataSet2.Perawat);
            // TODO: This line of code loads data into the 'puskesmas_superDataSet1.Jadwal_Pengurus_Kamar' table. You can move, or remove it, as needed.
            this.jadwal_Pengurus_KamarTableAdapter.Fill(this.puskesmas_superDataSet1.Jadwal_Pengurus_Kamar);
            // TODO: This line of code loads data into the 'puskesmas_superDataSet.Kamar' table. You can move, or remove it, as needed.
            this.kamarTableAdapter.Fill(this.puskesmas_superDataSet.Kamar);

        }
    }
}
